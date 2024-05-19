using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class EmployeeDAL
    {
        public static readonly Employee employeeSession = new Employee();

        public int CheckLogin(Employee employee)
        {
            int result = 0;

            using (SqlConnection connection = SQLConnector.GetConnection(0))
            {
                SqlCommand command = new SqlCommand("SP_CHECK_LOGIN", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số vào stored procedure
                command.Parameters.Add("@Username", SqlDbType.VarChar).Value = employee.Username;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = employee.Password;

                SqlParameter IdParameter = new SqlParameter("@EmployeeID", SqlDbType.VarChar, 100);
                IdParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(IdParameter);

                SqlParameter departmentId = new SqlParameter("@DepartmentID", SqlDbType.VarChar, 100);
                departmentId.Direction = ParameterDirection.Output;
                command.Parameters.Add(departmentId);

                SqlParameter roleId = new SqlParameter("@RoleID", SqlDbType.VarChar, 100);
                roleId.Direction = ParameterDirection.Output;
                command.Parameters.Add(roleId);

                //Thêm tham số đầu ra để nhận kết quả trả về
                SqlParameter resultParameter = new SqlParameter("@Result", SqlDbType.Int);
                resultParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(resultParameter);

                try
                {
                    command.ExecuteNonQuery();
                    // Đọc giá trị trả về từ tham số đầu ra
                    result = Convert.ToInt32(resultParameter.Value);
                    employeeSession.Id = IdParameter.Value.ToString();
                    employeeSession.DepartmentId = departmentId.Value.ToString();
                    employeeSession.RoleId = roleId.Value.ToString();
                    if (result == 1)
                    {
                        employeeSession.SqlUsername = employee.Username;
                        employeeSession.SqlPassword = employee.Password;
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return result;
        }

        public List<Employee> GetEmployeesByDepartment(string departmentID)
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
                using (SqlCommand cmd = new SqlCommand("SP_SELECT_EMPLOYEE_BY_DEPARTMENT", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@departmentID", departmentID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.Id = reader["employeeID"].ToString();
                            employee.Name = reader["employeeName"].ToString();
                            employee.Username = reader["username"].ToString();
                            employee.Email = reader["email"].ToString();
                            employee.DateOfBirth = (DateTime)reader["dateOfBirth"];
                            employee.TaxNumber = reader["taxNumber"].ToString();
                            if (!reader.IsDBNull(reader.GetOrdinal("basicSalary")))
                            {
                                object rawValue = reader.GetValue(reader.GetOrdinal("basicSalary"));
                                if (rawValue.GetType() == typeof(float))
                                {
                                    employee.BasicSalary = (float)rawValue;
                                }
                                else if (rawValue.GetType() == typeof(double))
                                {
                                    employee.BasicSalary = Convert.ToSingle((double)rawValue);
                                }
                                else if (rawValue.GetType() == typeof(decimal))
                                {
                                    employee.BasicSalary = Convert.ToSingle((decimal)rawValue);
                                }
                            }
                            employee.DepartmentId = reader["departmentID"].ToString();
                            employee.RoleId = reader["roleId"].ToString();

                            employees.Add(employee);
                        }
                    }
                }
                conn.Close();
            }
            return employees;
        }
        public bool InsertEmployee(Employee employee)
        {
            using (SqlConnection connection = SQLConnector.GetConnection(1))
            {
                using (SqlCommand command = new SqlCommand("SP_INSERT_EMPLOYEE", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@EmployeeID", employee.Id));
                    command.Parameters.Add(new SqlParameter("@EmployeeName", employee.Name));
                    command.Parameters.Add(new SqlParameter("@Username", employee.Username));
                    command.Parameters.Add(new SqlParameter("@Password", employee.Password));
                    command.Parameters.Add(new SqlParameter("@Email", employee.Email));
                    command.Parameters.Add(new SqlParameter("@DateOfBirth", employee.DateOfBirth));
                    command.Parameters.Add(new SqlParameter("@TaxNumber", employee.TaxNumber));
                    command.Parameters.Add(new SqlParameter("@BasicSalary", employee.BasicSalary));
                    command.Parameters.Add(new SqlParameter("@DepartmentID", employee.DepartmentId));
                    command.Parameters.Add(new SqlParameter("@RoleID", employee.RoleId));

                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error occurred while inserting the employee: " + ex.Message);
                    }
                }
            }

            return false;
        }
        public Employee GetEmployeeByID(string employeeID)
        {
            Employee employee = null;

            using (SqlConnection con = SQLConnector.GetConnection(1))
            {
                using (SqlCommand cmd = new SqlCommand("SP_SELECT_EMPLOYEE_BY_ID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employee = new Employee
                            {
                                Id = reader["employeeID"].ToString(),
                                Name = reader["employeeName"].ToString(),
                                Username = reader["username"].ToString(),
                                Email = reader["email"].ToString(),
                                DateOfBirth = Convert.ToDateTime(reader["dateOfBirth"]),
                                TaxNumber = reader["taxNumber"].ToString(),
                                BasicSalary = (float)reader.GetDouble(reader.GetOrdinal("basicSalary")),
                                DepartmentId = reader["departmentID"].ToString(),
                                RoleId = reader["roleId"].ToString(),
                                DepartmentName = reader["departmentName"].ToString(),
                                RoleName = reader["roleName"].ToString()
                            };
                        }
                    }
                }

                con.Close();
            }

            return employee;
        }

        public Employee GetManagerByDepartment(string departmentID)
        {
            string query = "SELECT * FROM employee WHERE @departmentId = departmentId AND roleId = 'R1'";

            Employee employee = new Employee();

            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@departmentId", departmentID);

                    // Execute the command and read the data
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Map the data to the Employee object
                            employee.Id = reader["employeeID"].ToString();
                            employee.Name = reader["employeeName"].ToString();
                            employee.Username = reader["username"].ToString();
                            employee.Email = reader["email"].ToString();
                            employee.DateOfBirth = Convert.ToDateTime(reader["dateOfBirth"]);
                            employee.TaxNumber = reader["taxNumber"].ToString();
                            employee.DepartmentId = reader["departmentID"].ToString();
                            employee.RoleId = reader["roleId"].ToString();
                        }
                    }
                }
            }

            return employee;
        }
        public bool DeleteEmployee(string employeeId)
        {

            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
                using (SqlCommand cmd = new SqlCommand("SP_DELETE_EMPLOYEE", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
        }
        public bool UpdateEmployee(Employee employee)
        {
            using (SqlConnection con = SQLConnector.GetConnection(1))
            {
                using (SqlCommand cmd = new SqlCommand("SP_UPDATE_EMPLOYEE", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeID", employee.Id);
                    cmd.Parameters.AddWithValue("@EmployeeName", (object)employee.Name ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Password", (object)employee.Password ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", (object)employee.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DateOfBirth", (object)employee.DateOfBirth ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@TaxNumber", (object)employee.TaxNumber ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@BasicSalary", (object)employee.BasicSalary ?? DBNull.Value);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                    finally 
                    {
                        con.Close();
                    }
                }
            }
        }


    }
}


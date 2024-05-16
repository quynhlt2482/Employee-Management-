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

        public DataTable GetEmployeesByDepartment(string departmentID)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = SQLConnector.GetConnection(1))
            {
                using (SqlCommand command = new SqlCommand("SP_SELECT_EMPLOYEE", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@departmentID", departmentID));

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    try
                    {
                        adapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error occurred while fetching employees: " + ex.Message);
                    }
                }
            }

            return dataTable;
        }
    }
}

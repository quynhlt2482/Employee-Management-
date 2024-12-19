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
    public class DepartmentDAL
    {
        public List<Department> GetAllDepartments()
        {
            var departments = new List<Department>();
            string query = "SELECT departmentID, departmentName FROM department";

            using (SqlConnection connection = SQLConnector.GetConnection(1))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string id = reader.GetString(0);
                        string name = reader.GetString(1);
                        departments.Add(new Department(id, name));
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while fetching departments: " + ex.Message);
                }
            }

            return departments;
        }

        public Department GetDepartmentByID(string departmentId)
        {
            Department department = new Department();
            string query = $"SELECT departmentID, departmentName FROM department WHERE departmentID = @departmentID";

            using (SqlConnection connection = SQLConnector.GetConnection(1))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@departmentID", departmentId);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string id = reader.GetString(0);
                        string name = reader.GetString(1);
                        department.DepartmentID = id;
                        department.DepartmentName = name;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while fetching departments: " + ex.Message);
                }
            }

            return department;
        }

        public void ChangeManager(string oldManagerID, string newManagerID)
        {
            using (SqlConnection connection = SQLConnector.GetConnection(1))
            {
                try
                {
                    SqlCommand command = new SqlCommand("SP_CHANGE_MANAGER", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số cần thiết cho stored procedure
                    command.Parameters.AddWithValue("@OldManagerID", oldManagerID);
                    command.Parameters.AddWithValue("@NewManagerID", newManagerID);

                    // Thực hiện stored procedure
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred at ChangeManager: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}

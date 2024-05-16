using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DepartmentDAL
    {
        public List<Department> GetDepartments()
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

        public List<Department> GetDepartmentByID(string departmentId)
        {
            var departments = new List<Department>();
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
    }
}

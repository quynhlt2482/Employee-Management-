using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoleDAL
    {
        public List<Role> GetAllRoles()
        {
            var roles = new List<Role>();
            string query = "SELECT * FROM role";

            using(SqlConnection con = SQLConnector.GetConnection(1))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, con);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string id = reader.GetString(0);
                        string name = reader.GetString(1);
                        roles.Add(new Role(id, name));
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while fetching roles: " + ex.Message);
                }
            }

            return roles;
        }
    }
}

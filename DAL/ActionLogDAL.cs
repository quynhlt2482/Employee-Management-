using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ActionLogDAL
    {
        public List<ActionLog> GetAllActionLogged()
        {
            List<ActionLog> actionLogs = new List<ActionLog>();

            using (System.Data.SqlClient.SqlConnection connection = SQLConnector.GetConnection(1))
            {
                string query = "SELECT loggedID, oldEmployeeName, newEmployeeName, password, oldBasicSalary, newBasicSalary, oldEmail, newEmail, oldTaxNumber, newTaxNumber, oldDateOfBirth, newDateOfBirth, updateAt, action, editUsername, editedUsername FROM actionLogged";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ActionLog actionLog = new ActionLog
                    {
                        LoggedID = Convert.ToInt32(reader["loggedID"]),
                        EditUsername = reader["editUsername"] != DBNull.Value ? reader["editUsername"].ToString() : null,
                        EditedUsername = reader["editedUsername"] != DBNull.Value ? reader["editedUsername"].ToString() : null,
                        OldEmployeeName = reader["oldEmployeeName"] != DBNull.Value ? reader["oldEmployeeName"].ToString() : null,
                        NewEmployeeName = reader["newEmployeeName"] != DBNull.Value ? reader["newEmployeeName"].ToString() : null,
                        Password = reader["password"] != DBNull.Value && Convert.ToBoolean(reader["password"]),
                        OldBasicSalary = reader["oldBasicSalary"] != DBNull.Value ? Convert.ToSingle(reader["oldBasicSalary"]) : 0,
                        NewBasicSalary = reader["newBasicSalary"] != DBNull.Value ? Convert.ToSingle(reader["newBasicSalary"]) : 0,
                        OldEmail = reader["oldEmail"] != DBNull.Value ? reader["oldEmail"].ToString() : null,
                        NewEmail = reader["newEmail"] != DBNull.Value ? reader["newEmail"].ToString() : null,
                        OldTaxNumber = reader["oldTaxNumber"] != DBNull.Value ? reader["oldTaxNumber"].ToString() : null,
                        NewTaxNumber = reader["newTaxNumber"] != DBNull.Value ? reader["newTaxNumber"].ToString() : null,
                        OldDateOfBirth = reader["oldDateOfBirth"] != DBNull.Value ? Convert.ToDateTime(reader["oldDateOfBirth"]) : DateTime.MinValue,
                        NewDateOfBirth = reader["newDateOfBirth"] != DBNull.Value ? Convert.ToDateTime(reader["newDateOfBirth"]) : DateTime.MinValue,
                        UpdateAt = reader["updateAt"] != DBNull.Value ? Convert.ToDateTime(reader["updateAt"]) : DateTime.MinValue,
                        Action = reader["action"] != DBNull.Value ? reader["action"].ToString() : null                     
                    };


                    actionLogs.Add(actionLog);
                }

                reader.Close();
            }

            return actionLogs;
        }
    }
}

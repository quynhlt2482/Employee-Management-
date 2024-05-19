using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class EmployeeContractDAL
    {
        public EmployeeContractDAL() { }

        public EmployeeContract GetInformation(string manv)

        {
            EmployeeContract contract = new EmployeeContract();
            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
               
                string query = "SELECT * FROM employmentContract WHERE employeeId = @EmployeeId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmployeeId", manv);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            {

                                contract.contractID = reader["contractID"].ToString();
                                contract.StartDate = Convert.ToDateTime(reader["startDate"]);
                                contract.EndDate = Convert.ToDateTime(reader["endDate"]);
                                contract.Status = Convert.ToBoolean(reader["status"]);
                                contract.EmployeeId = reader["employeeID"].ToString();
                                contract.ContractType = reader["contractType"].ToString();
                            };
                        }
                    }
                }
                conn.Close();
            }
            return contract;
        }
            

        public void UpdateInformation (string contractId,DateTime startDate, DateTime endDate, bool status, string contractType)
        {
            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
                using (SqlCommand command = new SqlCommand("UpdateEmploymentContract", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@contractID", contractId);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@contractType", contractType);

                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        
    }
}

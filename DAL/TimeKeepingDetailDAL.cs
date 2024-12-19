using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TimeKeepingDetailDAL
    {
        private readonly TimekeepingDetail timekeepingDetail = new TimekeepingDetail();


        public List<TimekeepingDetail> GetAllTimeKeepingDetail(string ID)
        {
            List<TimekeepingDetail> timeKeepingDetails = new List<TimekeepingDetail>();

            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {

                using (SqlCommand cmd = new SqlCommand("SelectAllFromTimeKeepingDetail", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TimekeepingDetail detail = new TimekeepingDetail
                            {
                                TkDetailID = reader.GetInt32(reader.GetOrdinal("tkDetailID")),
                                DayOfweek = reader.GetString(reader.GetOrdinal("dayOfWeek")),
                                CheckIn = reader.GetTimeSpan(reader.GetOrdinal("checkIn")),
                                CheckOut = reader.GetTimeSpan(reader.GetOrdinal("checkOut")),
                                Late = reader.GetTimeSpan(reader.GetOrdinal("late")),
                                ShiftId = reader.IsDBNull(reader.GetOrdinal("shiftID")) ? null : reader.GetString(reader.GetOrdinal("shiftID")),
                                TimekeepingId = reader.GetString(reader.GetOrdinal("timeKeepingID")),
                                EmployeeID = reader.GetString(reader.GetOrdinal("employeeID"))
                            };
                            timeKeepingDetails.Add(detail);
                        };
                        
                    }
                }
                conn.Close();
            }
            return timeKeepingDetails;
        }
    }
}

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
        public TimekeepingDetail GetTimekeepingDetail(string timekeepingID, string tkDetailID, string manv)
        {
            TimekeepingDetail timekeepingDetail = new TimekeepingDetail();

            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
                string query = " SELECT * FROM timeKeepingDetail WHERE tkDetailID = @tkDetailID and timeKeepingID = @timeKeepingID and employeeID = @employeeID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@tkDetailID", tkDetailID);
                    cmd.Parameters.AddWithValue("@timeKeepingID", timekeepingID);
                    cmd.Parameters.AddWithValue("@employeeID", manv);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            timekeepingDetail.TkDetailID = reader.GetInt32(reader.GetOrdinal("tkDetailID"));
                            timekeepingDetail.DayOfweek = reader.GetString(reader.GetOrdinal("dayOfWeek"));
                            timekeepingDetail.CheckIn = reader.GetTimeSpan(reader.GetOrdinal("checkIn"));
                            timekeepingDetail.CheckOut = reader.GetTimeSpan(reader.GetOrdinal("checkOut"));
                            timekeepingDetail.Late = reader.GetTimeSpan(reader.GetOrdinal("late"));
                            timekeepingDetail.ShiftId = reader.IsDBNull(reader.GetOrdinal("shiftID")) ? null : reader.GetString(reader.GetOrdinal("shiftID"));
                            timekeepingDetail.TimekeepingId = reader.GetString(reader.GetOrdinal("timeKeepingID"));
                            timekeepingDetail.EmployeeID = reader.GetString(reader.GetOrdinal("employeeID"));
                        };
                    }
                }
                conn.Close();
            }
            return timekeepingDetail;
        }


        public List<TimekeepingDetail> GetAllTimeKeepingDetailEmployee(string timekeepingID, string manv)
        {
            List<TimekeepingDetail> timeKeepingDetails = new List<TimekeepingDetail>();

            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {

                string query = " SELECT * FROM timeKeepingDetail WHERE timeKeepingID = @timeKeepingID and employeeID = @employeeID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@timeKeepingID", timekeepingID);
                    cmd.Parameters.AddWithValue("@employeeID", manv);

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
        public void UpdateTimeKeepingDetail(TimekeepingDetail timekeepingDetail)
        {
            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
                using (SqlCommand command = new SqlCommand("UpdateTimeKeepingDetail", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@tkDetailID", timekeepingDetail.TkDetailID);
                    command.Parameters.AddWithValue("@dayOfWeek", timekeepingDetail.DayOfweek);
                    command.Parameters.AddWithValue("@checkIn", timekeepingDetail.CheckIn);
                    command.Parameters.AddWithValue("@checkOut", timekeepingDetail.CheckOut);
                    command.Parameters.AddWithValue("@late", timekeepingDetail.Late);
                    command.Parameters.AddWithValue("@shiftID", timekeepingDetail.ShiftId);
                    command.Parameters.AddWithValue("@timeKeepingID", timekeepingDetail.TimekeepingId);
                    command.Parameters.AddWithValue("@employeeID", timekeepingDetail.EmployeeID);

                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}

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
    public class TimeKeepingDAL
    {

        public static readonly Timekeeping timekeeping = new Timekeeping();
        public TimeKeepingDAL() { }

        public void InsertTimeKeeping() {
            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
                using (SqlCommand command = new SqlCommand("InsertTimeKeeping", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }


        public bool ExitstTimeKeeping()
        {

            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
                string query = " SELECT * FROM timeKeeping WHERE year = @year AND month = @month ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    DateTime currentDate = DateTime.Now;
                    int month = currentDate.Month;
                    int year = currentDate.Year;

                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@month", month);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {                         
                            return true;
                        }
                    }
                }
                conn.Close();
            }
            return false;
        }

        public List<Timekeeping> GetAllTimeKeepingYear(int year)
        {
            List<Timekeeping> timeKeepings = new List<Timekeeping>();

            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {

                string query = " SELECT * FROM timeKeeping WHERE year = @year";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@year", year);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Timekeeping timeKeeping = new Timekeeping
                            {
                                TimeKeepingID = reader["timeKeepingID"].ToString(),
                                Year = Convert.ToInt32(reader["year"]),
                                Month = Convert.ToInt32(reader["month"])
                            };
                            timeKeepings.Add(timeKeeping);
                        }
                    }
                }
                conn.Close();
            }

            return timeKeepings;
        }

        public List<Timekeeping> GetAllTimeKeepingMonth(int month)
        {
            List<Timekeeping> timeKeepings = new List<Timekeeping>();

            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {

                string query = " SELECT * FROM timeKeeping WHERE month = @month";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@month", month);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Timekeeping timeKeeping = new Timekeeping
                            {
                                TimeKeepingID = reader["timeKeepingID"].ToString(),
                                Year = Convert.ToInt32(reader["year"]),
                                Month = Convert.ToInt32(reader["month"])
                            };
                            timeKeepings.Add(timeKeeping);
                        }
                    }
                }
                conn.Close();
            }

            return timeKeepings;
        }

        public List<Timekeeping> GetAllTimeKeepingYearMonth(int year, int month)
        {
            List<Timekeeping> timeKeepings = new List<Timekeeping>();

            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {

                string query = " SELECT * FROM timeKeeping WHERE year = @year AND month = @month";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@month", month);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Timekeeping timeKeeping = new Timekeeping
                            {
                                TimeKeepingID = reader["timeKeepingID"].ToString(),
                                Year = Convert.ToInt32(reader["year"]),
                                Month = Convert.ToInt32(reader["month"])
                            };
                            timeKeepings.Add(timeKeeping);
                        }
                    }
                }
                conn.Close();
            }

            return timeKeepings;
        }
        public List<Timekeeping> GetAllTimeKeeping()
        {
            List<Timekeeping> timeKeepings = new List<Timekeeping>();

            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
                
                using (SqlCommand cmd = new SqlCommand("SelectAllFromTimeKeeping", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Timekeeping timeKeeping = new Timekeeping
                            {
                                TimeKeepingID = reader["timeKeepingID"].ToString(),
                                Year = Convert.ToInt32(reader["year"]),
                                Month = Convert.ToInt32(reader["month"])
                            };
                            timeKeepings.Add(timeKeeping);
                        }
                    }
                }
                conn.Close();
            }

            return timeKeepings;
        }
    }
}

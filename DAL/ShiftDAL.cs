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
    public class ShiftDAL
    {
        public static readonly Shift shift = new Shift();

        public void InsertShift(Shift shift)
        {
            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
                using (SqlCommand command = new SqlCommand("InsertShift", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@shiftID", shift.ShiftID));
                    command.Parameters.Add(new SqlParameter("@shiftName", shift.ShiftName));
                    command.Parameters.Add(new SqlParameter("@startTime", shift.StartTime));
                    command.Parameters.Add(new SqlParameter("@endTime", shift.EndTime));
                    command.Parameters.Add(new SqlParameter("@totalTime", shift.TotalTime));
                    command.Parameters.Add(new SqlParameter("@coefficientSalary", shift.CoefficientSalary));

                    command.ExecuteNonQuery();

                    conn.Close();
                }
            }
        }

        public List<Shift> GetListShift()
        {
            List<Shift> shifts = new List<Shift>();

            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
                using (SqlCommand cmd = new SqlCommand("SP_Select_Shift", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Shift shift = new Shift();
                            shift.ShiftID = reader["shiftID"].ToString();
                            shift.ShiftName = reader["shiftName"].ToString();
                            shift.StartTime = (TimeSpan)reader["startTime"];
                            shift.EndTime = (TimeSpan)reader["endTime"];
                            shift.TotalTime = (TimeSpan)reader["totalTime"];
                            shift.CoefficientSalary = Convert.ToSingle(reader["coefficientSalary"]);
                            shifts.Add(shift);
                        }
                    }
                }
                conn.Close();
            }
            return shifts;
        }

        public Shift GetShift(string shiftID)
        {
            Shift shift = new Shift();

            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
                string query = " SELECT * FROM shift WHERE shiftID = @shiftID ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
        
                    cmd.Parameters.AddWithValue("@shiftID", shiftID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            {
                                shift.ShiftID = reader["shiftID"].ToString();
                                shift.ShiftName = reader["shiftName"].ToString();
                                shift.StartTime = (TimeSpan)reader["startTime"];
                                shift.EndTime = (TimeSpan)reader["endTime"];
                                shift.TotalTime = (TimeSpan)reader["totalTime"];
                                shift.CoefficientSalary = Convert.ToSingle(reader["coefficientSalary"]);
                            };
                           
                        }
                    }
                }
                conn.Close();
            }
            return shift;
        }

        public void UpdateShift (Shift shift)
        {
            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
                using (SqlCommand command = new SqlCommand("UpdateShift", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@shiftID", shift.ShiftID);
                    command.Parameters.AddWithValue("@shiftName", shift.ShiftName);
                    command.Parameters.AddWithValue("@startTime", shift.StartTime);
                    command.Parameters.AddWithValue("@endTime", shift.EndTime);
                    command.Parameters.AddWithValue("@totalTime", shift.TotalTime);
                    command.Parameters.AddWithValue("@coefficientSalary", shift.CoefficientSalary);

                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public bool DeleteShift(string ShiftID)
        {

            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
                string query = "DELETE FROM shift WHERE shiftID = @shiftID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@shiftID", ShiftID);
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
    }
}

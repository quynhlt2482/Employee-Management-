using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PayrollDAL
    {
        private readonly Payroll payroll = new Payroll();

        public void InsertPayroll(Payroll payroll)
        {
            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
                string query = "INSERT INTO payroll (payrollID, salaryAmount, workdayAmount, dayoffAmount, employeeID, timeKeepingID) " +
                               "VALUES (@PayrollID, @SalaryAmount, @WorkdayAmount, @DayoffAmount, @EmployeeID, @TimeKeepingID)";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@PayrollID", payroll.PayrollID);
                command.Parameters.AddWithValue("@SalaryAmount", payroll.SalaryAmount);
                command.Parameters.AddWithValue("@WorkdayAmount", payroll.WorkdayAmount);
                command.Parameters.AddWithValue("@DayoffAmount", payroll.DayoffAmount);
                command.Parameters.AddWithValue("@EmployeeID", payroll.EmployeeID);
                command.Parameters.AddWithValue("@TimeKeepingID", payroll.TimeKeepingID);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public bool UpdatePayroll(Payroll updatedPayroll)
        {
            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
                SqlCommand command = new SqlCommand("UpdatePayroll", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PayrollID", updatedPayroll.PayrollID);
                command.Parameters.AddWithValue("@SalaryAmount", updatedPayroll.SalaryAmount);
                command.Parameters.AddWithValue("@WorkdayAmount", updatedPayroll.WorkdayAmount);
                command.Parameters.AddWithValue("@DayoffAmount", updatedPayroll.DayoffAmount);
                command.Parameters.AddWithValue("@EmployeeID", updatedPayroll.EmployeeID);
                command.Parameters.AddWithValue("@TimeKeepingID", updatedPayroll.TimeKeepingID);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Trả về true nếu có ít nhất một hàng được cập nhật
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }
        public List<Payroll> SelectPayrollsByEmployee(string timeKeepingID, string employeeID)
        {
            List<Payroll> payrolls = new List<Payroll >();

            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
                string query = "SELECT payrollID, salaryAmount, workdayAmount, dayoffAmount, employeeID, timeKeepingID " +
                               "FROM payroll WHERE timeKeepingID = @TimeKeepingID AND employeeID = @employeeID";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@TimeKeepingID", timeKeepingID);
                command.Parameters.AddWithValue("@employeeID", employeeID);
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Payroll payroll = new Payroll
                        {
                            PayrollID = reader["payrollID"].ToString(),
                            SalaryAmount = float.Parse(reader["salaryAmount"].ToString()),
                            WorkdayAmount = float.Parse(reader["workdayAmount"].ToString()),
                            DayoffAmount = float.Parse(reader["dayoffAmount"].ToString()),
                            EmployeeID = reader["employeeID"].ToString(),
                            TimeKeepingID = reader["timeKeepingID"].ToString()
                        };
                        payrolls.Add(payroll);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return payrolls;
        }

        public Payroll SelectPayrollByEmployee(string timeKeepingID, string employeeID)
        {
            Payroll payroll = new Payroll();

            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
                string query = "SELECT payrollID, salaryAmount, workdayAmount, dayoffAmount, employeeID, timeKeepingID " +
                               "FROM payroll WHERE timeKeepingID = @TimeKeepingID AND employeeID = @employeeID";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@TimeKeepingID", timeKeepingID);
                command.Parameters.AddWithValue("@employeeID", employeeID);
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {

                        payroll.PayrollID = reader["payrollID"].ToString();
                        payroll.SalaryAmount = float.Parse(reader["salaryAmount"].ToString());
                        payroll.WorkdayAmount = float.Parse(reader["workdayAmount"].ToString());
                        payroll.DayoffAmount = float.Parse(reader["dayoffAmount"].ToString());
                        payroll.EmployeeID = reader["employeeID"].ToString();
                        payroll.TimeKeepingID = reader["timeKeepingID"].ToString();

                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return payroll;
        }

        public List<Payroll> SelectAllPayrolls(string timeKeepingID)
        {
            List<Payroll> payrolls = new List<Payroll>();

            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
                string query = "SELECT payrollID, salaryAmount, workdayAmount, dayoffAmount, employeeID, timeKeepingID " +
                               "FROM payroll WHERE timeKeepingID = @TimeKeepingID";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@TimeKeepingID", timeKeepingID);
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Payroll payroll = new Payroll
                        {
                            PayrollID = reader["payrollID"].ToString(),
                            SalaryAmount = float.Parse(reader["salaryAmount"].ToString()),
                            WorkdayAmount = float.Parse(reader["workdayAmount"].ToString()),
                            DayoffAmount = float.Parse(reader["dayoffAmount"].ToString()),
                            EmployeeID = reader["employeeID"].ToString(),
                            TimeKeepingID = reader["timeKeepingID"].ToString()
                        };
                        payrolls.Add(payroll);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return payrolls;
        }

        public bool ExitstPayrollEmployee(string timeKeepingID, string employeeID)
        {

            using (SqlConnection conn = SQLConnector.GetConnection(1))
            {
                string query = " SELECT * FROM payroll WHERE timeKeepingID = @TimeKeepingID AND employeeID = @employeeID ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    DateTime currentDate = DateTime.Now;
                    int month = currentDate.Month;
                    int year = currentDate.Year;

                    cmd.Parameters.AddWithValue("@TimeKeepingID", timeKeepingID);
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);
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

    }
}

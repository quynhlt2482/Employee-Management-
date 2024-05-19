using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Payroll
    {
        public string PayrollID { get; set; }
        public float SalaryAmount { get; set; }
        public float WorkdayAmount { get; set; }
        public float DayoffAmount { get; set; }
        public string EmployeeID { get; set; }
        public string TimeKeepingID { get; set; }

        public Payroll()
        {
        }

        public Payroll(string payrollID, float salaryAmount, float workdayAmount, float dayoffAmount, string employeeID, string timeKeepingID)
        {
            PayrollID = payrollID;
            SalaryAmount = salaryAmount;
            WorkdayAmount = workdayAmount;
            DayoffAmount = dayoffAmount;
            EmployeeID = employeeID;
            TimeKeepingID = timeKeepingID;
        }
    }
}

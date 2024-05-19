using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PayrollBUS
    {
        private readonly PayrollDAL payrollDAL = new PayrollDAL();

        public void InsertPayroll(Payroll payroll)
        {
            payrollDAL.InsertPayroll(payroll);
        }

        public List<Payroll> SelectPayrollsByEmployee(string timeKeepingID, string employeeID)
        {
            return payrollDAL.SelectPayrollsByEmployee(timeKeepingID, employeeID);
        }

        public List<Payroll> SelectAllPayrolls(string timeKeepingID)
        {
            return payrollDAL.SelectAllPayrolls(timeKeepingID);
        }

        public bool ExitstPayrollEmployee(string timeKeepingID, string employeeID)
        {
            return payrollDAL.ExitstPayrollEmployee(timeKeepingID, employeeID);
        }

        public Payroll SelectPayrollByEmployee(string timeKeepingID, string employeeID)
        {
            return payrollDAL.SelectPayrollByEmployee(timeKeepingID,employeeID);
        }

        public bool UpdatePayroll(Payroll updatedPayroll)
        {
            return payrollDAL.UpdatePayroll(updatedPayroll);
        }
    }
}

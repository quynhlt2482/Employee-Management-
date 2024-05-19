using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class EmployeeContractBUS
    {
        private readonly EmployeeContractDAL employeeDAL = new EmployeeContractDAL();

        public EmployeeContract GetEmployeeContract(string manv)
        {
            return employeeDAL.GetInformation(manv);
        }

        public void UpdateEmployeeContract(string contractId, DateTime startDate, DateTime endDate, bool status, string contractType)
        {
            employeeDAL.UpdateInformation(contractId, startDate, endDate, status, contractType);
        }
    }
}
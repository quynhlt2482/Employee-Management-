using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EmployeeContract
    {
        private string contractId;
        private DateTime startDate;
        private DateTime endDate;
        private bool status;
        private string employeeId;
        private string contractType;


        public EmployeeContract() {}
        public EmployeeContract(string contractID, DateTime startDate, DateTime endDate, bool status, string employeeId, string ContractType)
        {
            this.contractId = contractID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.status = status;
            this.employeeId = employeeId;
            this.contractType = ContractType;
        }

        public string contractID{ get => contractId; set => contractId = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public bool Status { get => status; set => status = value; }
        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public string ContractType { get => contractType; set => contractType = value; }
    }
}

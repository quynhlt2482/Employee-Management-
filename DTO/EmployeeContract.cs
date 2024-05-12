using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class EmployeeContract
    {
        private string id;
        private DateTime startDate;
        private DateTime endDate;
        private bool status;
        private string employeeId;
        private string contractTypeId;

        public EmployeeContract(string id, DateTime startDate, DateTime endDate, bool status, string employeeId, string ContractTypeId)
        {
            this.id = id;
            this.startDate = startDate;
            this.endDate = endDate;
            this.status = status;
            this.employeeId = employeeId;
            this.contractTypeId = ContractTypeId;
        }

        public string Id { get => id; set => id = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public bool Status { get => status; set => status = value; }
        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public string ContractTypeId { get => contractTypeId; set => contractTypeId = value; }
    }
}

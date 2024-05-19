using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ActionLog
    {
        public int LoggedID { get; set; }
        public string OldEmployeeName { get; set; }
        public string NewEmployeeName { get; set; }
        public bool Password { get; set; }
        public float OldBasicSalary { get; set; }
        public float NewBasicSalary { get; set; }
        public string OldEmail { get; set; }
        public string NewEmail { get; set; }
        public string OldTaxNumber { get; set; }
        public string NewTaxNumber { get; set; }
        public DateTime OldDateOfBirth { get; set; }
        public DateTime NewDateOfBirth { get; set; }
        public DateTime UpdateAt { get; set; }
        public string Action { get; set; }
        public string EditUsername { get; set; }
        public string EditedUsername { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Department
    {
        private string departmentID;
        private string departmentName;

        public Department() { }
        public Department(string id, string name)
        {
            this.DepartmentID = id;
            this.DepartmentName = name;
        }

        public string DepartmentID { get => departmentID; set => departmentID = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }
    }
}

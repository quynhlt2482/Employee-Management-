using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class Employee
    {
        private string id;
        private string name;
        private string username;
        private byte[] password;
        private string email;
        private DateTime dateOfBirth;
        private string taxCode;
        private byte[] basicSalary;
        private string departmentId;

        public Employee(string id, string name, string username, byte[] password, string email, DateTime dateOfBirth, string taxCode, byte[] basicSalary, string departmentId)
        {
            this.id = id;
            this.name = name;
            this.username = username;
            this.password = password;  
            this.email = email;
            this.dateOfBirth = dateOfBirth;
            this.TaxCode = taxCode;
            this.basicSalary = basicSalary;
            this.departmentId = departmentId;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public byte[] Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public byte[] BasicSalary { get => basicSalary; set => basicSalary = value; }
        public string DepartmentId { get => departmentId; set => departmentId = value; }
        public string TaxCode { get => taxCode; set => taxCode = value; }
    }
}

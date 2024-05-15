using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Employee
    {
        private string id;
        private string name;
        private string username;
        private string password;
        private string email;
        private DateTime dateOfBirth;
        private string taxNumber;
        private float basicSalary;
        private string departmentId;
        private string roleId;

        private string sqlUsername;
        private string sqlPassword;

        public Employee() { }

        public Employee(string id, string name, string username, string password, string email, DateTime dateOfBirth, string taxNumber, float basicSalary, string departmentId, string roleId)
        {
            this.id = id;
            this.name = name;
            this.username = username;
            this.password = password;  
            this.email = email;
            this.dateOfBirth = dateOfBirth;
            this.taxNumber = taxNumber;
            this.basicSalary = basicSalary;
            this.departmentId = departmentId;
            this.roleId = roleId;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public float BasicSalary { get => basicSalary; set => basicSalary = value; }
        public string DepartmentId { get => departmentId; set => departmentId = value; }
        public string TaxNumber { get => taxNumber; set => taxNumber = value; }
        public string RoleId { get => roleId; set => roleId = value; }
        public string SqlUsername { get => sqlUsername; set => sqlUsername = value; }
        public string SqlPassword { get => sqlPassword; set => sqlPassword = value; }
    }
}

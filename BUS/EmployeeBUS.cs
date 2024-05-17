using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class EmployeeBUS
    {
        private readonly EmployeeDAL employeeDAL = new EmployeeDAL();
        public int CheckLogin(Employee employee)
        {
            if (employee.Username == "" || employee.Password == "")
            {
                return -1;
            }
            return employeeDAL.CheckLogin(employee);
        }
        public int InsertEmployee(Employee employee)
        {
            return employeeDAL.InsertEmployee(employee);
        }
        public bool DeleteEmployee(string employeeId, string departmentId, string roleId)
        {
            if(departmentId.ToLower() == "dep3" && roleId.ToLower() == "r0")
            {
                return false;
            }
            return employeeDAL.DeleteEmployee(employeeId);
        }

        public List<Employee> GetEmployeesByDepartment(string departmentID)
        {
            return employeeDAL.GetEmployeesByDepartment(departmentID);
        }

        public Employee GetManagerByDepartment(string departmentID)
        {
            return employeeDAL.GetManagerByDepartment(departmentID);
        }
    }
}

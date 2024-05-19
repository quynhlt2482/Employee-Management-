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
        public bool InsertEmployee(Employee employee)
        {
            //nhân viên phòng HR không thể insert trên phòng HR
            if (EmployeeDAL.employeeSession.DepartmentId.ToLower() == "dep3" && 
                EmployeeDAL.employeeSession.RoleId.ToLower() == "r0" &&
                employee.DepartmentId.ToLower() == "dep3")
            {
                return false;
            }
            return employeeDAL.InsertEmployee(employee);
        }
        public bool UpdateEmployee(Employee employee, string departmentID)
        {
            //nhân viên phòng HR không thể update trên phòng HR
            if (EmployeeDAL.employeeSession.DepartmentId.ToLower() == "dep3" &&
                EmployeeDAL.employeeSession.RoleId.ToLower() == "r0" &&
                departmentID.ToLower() == "dep3")
            {
                return false;
            }
            return employeeDAL.UpdateEmployee(employee);
        }
        public bool DeleteEmployee(string employeeId, string departmentID)
        {
            //nhân viên phòng HR không thể delete trên phòng HR
            if (EmployeeDAL.employeeSession.DepartmentId.ToLower() == "dep3" &&
                EmployeeDAL.employeeSession.RoleId.ToLower() == "r0" &&
                departmentID.ToLower() == "dep3")
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
        public Employee GetEmployeeByID(string employeeID)
        {
            return employeeDAL.GetEmployeeByID(employeeID);
        }
    }
}

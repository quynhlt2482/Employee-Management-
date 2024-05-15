using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class EmployeeBUS
    {
        EmployeeDAL employDAL = new EmployeeDAL();
        public int CheckLogin(Employee employee)
        {
            if(employee.Username == "" || employee.Password == "")
            {
                return -1;
            }
            return employDAL.CheckLogin(employee);
        }
    }
}

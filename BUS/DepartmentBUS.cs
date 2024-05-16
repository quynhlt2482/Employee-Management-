using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class DepartmentBUS
    {
        private readonly DepartmentDAL departmentDAL = new DepartmentDAL();
        public List<Department> GetDepartmentByID(string departmentId)
        {
            return departmentDAL.GetDepartmentByID(departmentId);
        }

        public List<Department> GetDepartments()
        {
            return departmentDAL.GetDepartments();
        }
    }
}

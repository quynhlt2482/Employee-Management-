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
        public Department GetDepartmentByID(string departmentId)
        {
            return departmentDAL.GetDepartmentByID(departmentId);
        }

        public List<Department> GetAllDepartments()
        {
            return departmentDAL.GetAllDepartments();
        }

        public void ChangeManager(string oldManagerID, string newManagerID)
        {
            departmentDAL.ChangeManager(oldManagerID, newManagerID);
        }
    }
}

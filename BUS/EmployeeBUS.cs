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
            if(employee.Username == "" || employee.Password == "")
            {
                return -1;
            }
            return employeeDAL.CheckLogin(employee);
        }

        public DataTable GetEmployeesByDepartment(string departmentID)
        {
            DataTable dataTable = employeeDAL.GetEmployeesByDepartment(departmentID);

            // Remove the departmentID column if it exists
            if (dataTable.Columns.Contains("departmentID"))
            {
                dataTable.Columns.Remove("departmentID");
            }

            // Change column headers
            ChangeColumnHeaders(dataTable);

            // Convert roleId to readable format
            ConvertRoleIds(dataTable);

            return dataTable;
        }

        private void ChangeColumnHeaders(DataTable dataTable)
        {
            if (dataTable.Columns.Contains("employeeID"))
                dataTable.Columns["employeeID"].ColumnName = "Mã NV";

            if (dataTable.Columns.Contains("employeeName"))
                dataTable.Columns["employeeName"].ColumnName = "Tên NV";

            if (dataTable.Columns.Contains("username"))
                dataTable.Columns["username"].ColumnName = "Tên đăng nhập";

            if (dataTable.Columns.Contains("email"))
                dataTable.Columns["email"].ColumnName = "Email";

            if (dataTable.Columns.Contains("dateOfBirth"))
                dataTable.Columns["dateOfBirth"].ColumnName = "Ngày sinh";

            if (dataTable.Columns.Contains("taxNumber"))
                dataTable.Columns["taxNumber"].ColumnName = "Mã số thuế";

            if (dataTable.Columns.Contains("roleId"))
                dataTable.Columns["roleId"].ColumnName = "Chức vụ";
        }

        private void ConvertRoleIds(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["Chức vụ"].ToString() == "r0")
                {
                    row["Chức vụ"] = "Nhân viên";
                }
                else if (row["Chức vụ"].ToString() == "r1")
                {
                    row["Chức vụ"] = "Trưởng phòng";
                }
            }
        }
    }
}

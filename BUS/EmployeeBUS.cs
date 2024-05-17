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

        public List<Employee> GetEmployeesByDepartment(string departmentID)
        {
            return employeeDAL.GetEmployeesByDepartment(departmentID);
        }

        public DataTable GetDatableEmployeesByDepartment(string departmentID)
        {
            List<Employee> employees = employeeDAL.GetEmployeesByDepartment(departmentID);

            return ConvertToDataTable(employees);
        }

        private DataTable ConvertToDataTable(List<Employee> employees)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Mã NV");
            dataTable.Columns.Add("Tên NV");
            dataTable.Columns.Add("Tên đăng nhập");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Ngày sinh");
            dataTable.Columns.Add("Mã số thuế");
            dataTable.Columns.Add("Lương cơ bản", typeof(double));
            dataTable.Columns.Add("Chức vụ");

            foreach (var employee in employees)
            {
                dataTable.Rows.Add(
                    employee.Id,
                    employee.Name,
                    employee.Username,
                    employee.Email,
                    employee.DateOfBirth.ToString("dd-MM-yyyy"),
                    employee.TaxNumber,
                    employee.BasicSalary,
                    employee.RoleId
                );
            }

            FormatDataGridColumns(dataTable);

            return dataTable;
        }

        private void FormatDataGridColumns(DataTable dataTable)
        {
            // Format "Chức vụ" column
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["Chức vụ"].ToString().ToLower() == "r0")
                {
                    row["Chức vụ"] = "Nhân viên";
                }
                else if (row["Chức vụ"].ToString().ToLower() == "r1")
                {
                    row["Chức vụ"] = "Trưởng phòng";
                }
            }

            // Format "Lương cơ bản" column
            dataTable.Columns.Add("TempLương cơ bản", typeof(string));

            foreach (DataRow row in dataTable.Rows)
            {
                // Chuyển đổi giá trị "Lương cơ bản"
                if (row.IsNull("Lương cơ bản"))
                {
                    row["TempLương cơ bản"] = "*********";
                }
                else
                {
                    // Format the salary with thousands separators
                    double salary = Convert.ToDouble(row["Lương cơ bản"]);
                    row["TempLương cơ bản"] = salary.ToString("N0");
                }
            }

            // Xóa cột gốc "Lương cơ bản"
            dataTable.Columns.Remove("Lương cơ bản");

            // Đổi tên cột tạm thời thành "Lương cơ bản"
            dataTable.Columns["TempLương cơ bản"].ColumnName = "Lương cơ bản";
        }
    }
}

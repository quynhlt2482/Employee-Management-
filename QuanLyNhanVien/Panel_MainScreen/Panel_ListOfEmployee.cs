using QuanLyNhanVien.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using DAL;

namespace QuanLyNhanVien
{
    public partial class Panel_ListOfEmployee : Form
    {
        private readonly EmployeeBUS employeeBUS = new EmployeeBUS();
        private readonly DepartmentBUS departmentBUS = new DepartmentBUS();
        public Panel_ListOfEmployee()
        {
            InitializeComponent();
            AddMouseEventsToPictureBoxes();
            LoadDepartments();
            departmentCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void AddMouseEventsToPictureBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is PictureBox)
                {
                    control.MouseEnter += PictureBox_MouseEnter;
                    control.MouseLeave += PictureBox_MouseLeave;
                }
            }
        }
        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                pictureBox.Size = new Size(50, 50);
            }
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                pictureBox.Size = new Size(40, 40);
            }
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị của mục được chọn
            if (departmentCB.SelectedItem is Department selectedDepartment)
            {
                LoadEmployeesByDepartment(selectedDepartment.DepartmentID);
            }
        }

        private void LoadDepartments()
        {
            List<Department> departments;

            try
            {
                string departmentId = EmployeeDAL.employeeSession.DepartmentId;
                if (departmentId.ToLower() == "dep3")
                {
                    departments = departmentBUS.GetDepartments();
                }
                else
                {
                    departments = departmentBUS.GetDepartmentByID(departmentId);
                }

                departmentCB.DataSource = departments;
                departmentCB.DisplayMember = "DepartmentName";
                departmentCB.ValueMember = "DepartmentID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at LoadDepartments: " + ex.Message);
            }
        }

        private void LoadEmployeesByDepartment(string departmentID)
        {
            try
            {
                List<Employee> employees = employeeBUS.GetEmployeesByDepartment(departmentID);
                dtg_nhanvien.DataSource = ConvertToDataTable(employees);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error at LoadEmployeesByDepartment : {ex.Message}");
            }
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


        private void ptb_add_Click(object sender, EventArgs e)
        {
            Modal_AddEmployee addEmployeeForm = new Modal_AddEmployee(employeeBUS, departmentBUS);
            addEmployeeForm.FormClosed += new FormClosedEventHandler(ChildForm_FormClosed);
            addEmployeeForm.Show();
        }

        private void ptb_changeManager_Click(object sender, EventArgs e)
        {
            // Lấy selected item và kiểm tra nếu nó không null
            if (departmentCB.SelectedItem != null)
            {
                var selectedDepartment = (Department)departmentCB.SelectedItem;

                // Truyền cả DisplayMember và ValueMember
                Modal_ChangeManager changeManagerForm = new Modal_ChangeManager(selectedDepartment);
                changeManagerForm.FormClosed += new FormClosedEventHandler(ChildForm_FormClosed);
                changeManagerForm.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng ban.");
            }
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (departmentCB.SelectedItem is Department selectedDepartment)
            {
                LoadEmployeesByDepartment(selectedDepartment.DepartmentID);
            }
        }

        private void ptb_edit_Click(object sender, EventArgs e)
        {
            Modal_EditEmployee editEmployeeForm = new Modal_EditEmployee(employeeBUS, departmentBUS);
            editEmployeeForm.Show();
        }
    }

}

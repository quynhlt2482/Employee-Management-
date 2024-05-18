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
using QuanLyNhanVien.Panel_MainScreen;

namespace QuanLyNhanVien
{
    public partial class Panel_ListOfEmployee : Form
    {
        private readonly EmployeeBUS employeeBUS = new EmployeeBUS();
        private readonly DepartmentBUS departmentBUS = new DepartmentBUS();
        private string selectedEmployeeID;
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

        private void dtg_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_nhanvien.Rows[e.RowIndex];
                selectedEmployeeID = row.Cells["Mã NV"].Value.ToString();
            }
        }

        private void ptb_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedEmployeeID))
            {
                MessageBox.Show("Bạn chưa chọn nhân viên cần xóa !!!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa nhân viên này ?",
                                                    "Xác nhận xóa",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    bool isDeleted = employeeBUS.DeleteEmployee(selectedEmployeeID, EmployeeDAL.employeeSession.DepartmentId, EmployeeDAL.employeeSession.RoleId);
                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa nhân viên thành công !");
                        if (departmentCB.SelectedItem is Department selectedDepartment)
                        {
                            LoadEmployeesByDepartment(selectedDepartment.DepartmentID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại !!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error at delelte btn: " + ex.Message);
                }
            }
        }

        private void LoadDepartments()
        {
            try
            {
                string departmentId = EmployeeDAL.employeeSession.DepartmentId;
                if (departmentId.ToLower() == "dep3")
                {
                    List<Department> departments = departmentBUS.GetAllDepartments();
                    departmentCB.DataSource = departments;
                    departmentCB.DisplayMember = "DepartmentName";
                    departmentCB.ValueMember = "DepartmentID";
                }
                else
                {
                    Department department = departmentBUS.GetDepartmentByID(departmentId);
                    List<Department> departmentList = new List<Department>
                    { department };
                    departmentCB.DataSource = departmentList;
                    departmentCB.DisplayMember = "DepartmentName";
                    departmentCB.ValueMember = "DepartmentID";
                }
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

        private void ptb_detail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedEmployeeID))
            {
                MessageBox.Show("Bạn chưa chọn nhân viên cần xem !!!");
                return;
            } else
            {
                GUI_MainScreen mainScreen = this.ParentForm as GUI_MainScreen;

                if (mainScreen != null)
                {
                    mainScreen.OpenChildForm(new Panel_ListOfContact(selectedEmployeeID));
                }
            }
            
        }
    }

}

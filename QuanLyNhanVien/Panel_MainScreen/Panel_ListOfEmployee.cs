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
using DTO;
using DAL;

namespace QuanLyNhanVien
{
    public partial class Panel_ListOfEmployee : Form
    {
        public Panel_ListOfEmployee()
        {
            InitializeComponent();
            AddMouseEventsToPictureBoxes();
            LoadDepartments();
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

        private void dtg_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ptb_detail_Click(object sender, EventArgs e)
        {

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
            List<Department> departments = new List<Department>();
            string query = "";

            if (EmployeeDAL.employeeSession.DepartmentId == "dep3")
            {
                query = "SELECT departmentID, departmentName FROM department";
            }
            else
            {
                query = $"SELECT departmentID, departmentName FROM department WHERE departmentID = '{EmployeeDAL.employeeSession.DepartmentId}'";
            }

            using (SqlConnection connection = SQLConnector.GetConnection(1))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string id = reader.GetString(0);
                        string name = reader.GetString(1);
                        departments.Add(new Department(id, name));
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                departmentCB.DataSource = departments;
                departmentCB.DisplayMember = "DepartmentName";
                departmentCB.ValueMember = "DepartmentID";
            }
        }

        private void LoadEmployeesByDepartment(string departmentID)
        {
            // Tạo kết nối đến SQL Server
            using (SqlConnection connection = SQLConnector.GetConnection(1))
            {
                // Tạo đối tượng SqlCommand để gọi thủ tục lưu trữ
                using (SqlCommand command = new SqlCommand("SP_SELECT_EMPLOYEE", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số cho thủ tục lưu trữ
                    command.Parameters.Add(new SqlParameter("@departmentID", departmentID));

                    // Tạo SqlDataAdapter để đổ dữ liệu vào DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        // Đổ dữ liệu vào DataTable
                        adapter.Fill(dataTable);

                        if (dataTable.Columns.Contains("departmentID"))
                        {
                            dataTable.Columns.Remove("departmentID");
                        }

                        if (dtg_nhanvien.Columns["employeeID"] != null)
                            dtg_nhanvien.Columns["employeeID"].HeaderText = "Mã NV";

                        if (dtg_nhanvien.Columns["employeeName"] != null)
                            dtg_nhanvien.Columns["employeeName"].HeaderText = "Tên NV";

                        if (dtg_nhanvien.Columns["username"] != null)
                            dtg_nhanvien.Columns["username"].HeaderText = "Tên đăng nhập";

                        if (dtg_nhanvien.Columns["email"] != null)
                            dtg_nhanvien.Columns["email"].HeaderText = "Email";

                        if (dtg_nhanvien.Columns["dateOfBirth"] != null)
                            dtg_nhanvien.Columns["dateOfBirth"].HeaderText = "Ngày sinh";

                        if (dtg_nhanvien.Columns["taxNumber"] != null)
                            dtg_nhanvien.Columns["taxNumber"].HeaderText = "Mã số thuế";

                        if (dtg_nhanvien.Columns["roleId"] != null)
                            dtg_nhanvien.Columns["roleId"].HeaderText = "Chức vụ";

                        // Chuyển đổi giá trị roleId từ mã sang tên dễ đọc
                        foreach (DataRow row in dataTable.Rows)
                        {
                            if (row["roleId"].ToString() == "r0")
                            {
                                row["roleId"] = "Nhân viên";
                            }
                            else if (row["roleId"].ToString() == "r1")
                            {
                                row["roleId"] = "Trưởng phòng";
                            }
                        }

                        // Gán DataTable cho DataGridView để hiển thị
                        dtg_nhanvien.DataSource = dataTable;

                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Xử lý ngoại lệ nếu có
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }
        private void ptb_add_Click(object sender, EventArgs e)
        {
            Modal_AddEmployee p = new Modal_AddEmployee();
            p.Show();
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
                MessageBox.Show("Please select a department first.");
            }
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (departmentCB.SelectedItem is Department selectedDepartment)
            {
                LoadEmployeesByDepartment(selectedDepartment.DepartmentID);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

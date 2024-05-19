using BUS;
using DAL;
using DTO;
using QuanLyNhanVien.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien.Panel_MainScreen
{
    public partial class Panel_ListOfTimeKeepingDetail : Form
    {
        private readonly TimeKeepingDetailBUS timeKeepingDetailBUS = new TimeKeepingDetailBUS();
        private readonly DepartmentBUS departmentBUS = new DepartmentBUS();
        private readonly EmployeeBUS employeeBUS = new EmployeeBUS();
        private readonly ShiftBUS shiftBUS = new ShiftBUS();

        private string selectedTimeKeepingDetailID;
        private string TimeKeepingID;
        private string selectedEmployeeID;
        public Panel_ListOfTimeKeepingDetail(string ID)
        {
            this.TimeKeepingID = ID;
            InitializeComponent();
            AddMouseEventsToPictureBoxes();
            LoadDepartments();
            LoadTimeKeeping();        
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

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadTimeKeeping();
        }
        private void ptb_back_Click(object sender, EventArgs e)
        {
            GUI_MainScreen mainScreen = this.ParentForm as GUI_MainScreen;

            if (mainScreen != null)
            {
                mainScreen.OpenChildForm(new Panel_AllTimeKeeping());
            }
        }


        private void ptb_edit_Click(object sender, EventArgs e)
        {

            Modal_EditTimeKeepingDetail p = new Modal_EditTimeKeepingDetail(TimeKeepingID,selectedTimeKeepingDetailID,selectedEmployeeID);
            p.FormClosed += new FormClosedEventHandler(ChildForm_FormClosed);
            p.Show();
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
                cb_nhanvien.DataSource = employees;
                cb_nhanvien.DisplayMember = "name";
                cb_nhanvien.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error at LoadEmployeesByDepartment : {ex.Message}");
            }
        }
        private void LoadTimeKeeping()
        {
            try
            {
                List<TimekeepingDetail> timekeepingDetails = timeKeepingDetailBUS.GetAllTimeKeepingDetail(TimeKeepingID);
                dtg_chamcongchitiet.DataSource = ConvertToDataTable(timekeepingDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error at LoadTimeKeeping : {ex.Message}");
            }
        }

        private void LoadTimeKeepingEmployee()
        {
            try
            {
                List<TimekeepingDetail> timekeepingDetails = timeKeepingDetailBUS.GetAllTimeKeepingDetailEmployee(TimeKeepingID,selectedEmployeeID);
                dtg_chamcongchitiet.DataSource = ConvertToDataTable(timekeepingDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error at LoadTimeKeeping : {ex.Message}");
            }
        }
        private DataTable ConvertToDataTable(List<TimekeepingDetail> timekeepingDetails)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Ngày công");
            dataTable.Columns.Add("Thứ");
            dataTable.Columns.Add("Thời gian vào làm");
            dataTable.Columns.Add("Thời gian tan ca");
            dataTable.Columns.Add("Thời gian trễ");
            dataTable.Columns.Add("Ca làm");
            dataTable.Columns.Add("Mã nhân viên");


            foreach (var TimekeepingDetail in timekeepingDetails)
            {
                if (TimekeepingDetail.ShiftId == null)
                {
                    dataTable.Rows.Add(
                    TimekeepingDetail.TkDetailID,
                    TimekeepingDetail.DayOfweek,
                    TimekeepingDetail.CheckIn.ToString("hh\\:mm"),
                    TimekeepingDetail.CheckOut.ToString("hh\\:mm"),
                    TimekeepingDetail.Late.ToString("hh\\:mm"),
                    TimekeepingDetail.ShiftId,
                    TimekeepingDetail.EmployeeID
                    );
                }
                else
                {
                    dataTable.Rows.Add(
                    TimekeepingDetail.TkDetailID,
                    TimekeepingDetail.DayOfweek,
                    TimekeepingDetail.CheckIn.ToString("hh\\:mm"),
                    TimekeepingDetail.CheckOut.ToString("hh\\:mm"),
                    TimekeepingDetail.Late.ToString("hh\\:mm"),
                    shiftBUS.GetInformationShift(TimekeepingDetail.ShiftId).ShiftName,
                    TimekeepingDetail.EmployeeID
                    );
                }
                
            }

            return dataTable;
        }
        private void dtg_chamcongchitiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_chamcongchitiet.Rows[e.RowIndex];
                selectedTimeKeepingDetailID = row.Cells["Ngày công"].Value.ToString();
                selectedEmployeeID = row.Cells["Mã nhân viên"].Value.ToString();
            }
        }

        private void departmentCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (departmentCB.SelectedItem is Department selectedDepartment)
            {
                LoadEmployeesByDepartment(selectedDepartment.DepartmentID);
            }
        }

        private void cb_nhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_nhanvien.SelectedItem is Employee selectedEmployee)
            {
                selectedEmployeeID = selectedEmployee.Id;
                LoadTimeKeepingEmployee();
            }
        }
    }
}

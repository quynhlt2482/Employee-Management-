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
    public partial class Panel_ListOfPayroll : Form
    {

        private readonly DepartmentBUS departmentBUS = new DepartmentBUS();
        private readonly EmployeeBUS employeeBUS = new EmployeeBUS();
        private readonly PayrollBUS payrollBUS = new PayrollBUS();
        private string id;
        private string selectedEmployeeID;
        public Panel_ListOfPayroll(string id)
        {
            this.id = id;
            InitializeComponent();
            AddMouseEventsToPictureBoxes();
            LoadDepartments();
            LoadAllPayRoll();


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
        private void ptb_back_Click(object sender, EventArgs e)
        {
            GUI_MainScreen mainScreen = this.ParentForm as GUI_MainScreen;

            if (mainScreen != null)
            {
                mainScreen.OpenChildForm(new Panel_ListOfSalary());
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
                LoadPayRollEmployee();
            }
        }

        private void LoadPayRollEmployee()
        {
            try
            {
                List<Payroll> payrolls = payrollBUS.SelectPayrollsByEmployee(id,selectedEmployeeID);
                dtg_payroll.DataSource = ConvertToDataTable(payrolls);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error at LoadTimeKeeping : {ex.Message}");
            }
        }
        private void LoadAllPayRoll()
        {
            try
            {
                List<Payroll> payrolls = payrollBUS.SelectAllPayrolls(id);
                dtg_payroll.DataSource = ConvertToDataTable(payrolls);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error at LoadTimeKeeping : {ex.Message}");
            }
        }
        private void ptb_add_Click(object sender, EventArgs e)
        {
            if (payrollBUS.ExitstPayrollEmployee(id,selectedEmployeeID))
            {
                MessageBox.Show("Lương nhân viên này đã tồn tại");
                return; 
            }
            Modal_AddPayroll addPayroll = new Modal_AddPayroll(id,selectedEmployeeID);
            addPayroll.FormClosed += new FormClosedEventHandler(ChildForm_FormClosed);
            addPayroll.Show();
        }

        private DataTable ConvertToDataTable(List<Payroll> payrolls)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Tổng ngày làm");
            dataTable.Columns.Add("Tổng ngày nghỉ");
            dataTable.Columns.Add("Tổng tiền");
            dataTable.Columns.Add("Mã NV");

            foreach (var Payroll in payrolls)
            {

                dataTable.Rows.Add(
                    Payroll.WorkdayAmount.ToString(),
                    Payroll.DayoffAmount.ToString(),
                    Payroll.SalaryAmount.ToString(),
                    Payroll.EmployeeID
                );
            }

            return dataTable;
        }
        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadAllPayRoll();
        }

        private void ptb_edit_Click(object sender, EventArgs e)
        {
            Modal_EditPayroll editPayroll = new Modal_EditPayroll(id, selectedEmployeeID);
            editPayroll.FormClosed += new FormClosedEventHandler(ChildForm_FormClosed);
            editPayroll.Show();
        }

        private void dtg_payroll_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

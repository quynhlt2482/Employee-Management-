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
using DAL;
using DTO;
using BUS;
using ComponentFactory.Krypton.Toolkit;

namespace QuanLyNhanVien.Modal
{
    public partial class Modal_ChangeManager : KryptonForm
    {
        Department _department;
        Employee manager = new Employee();
        DepartmentBUS departmentBUS = new DepartmentBUS();
        EmployeeBUS employeeBUS = new EmployeeBUS();
        
        public Modal_ChangeManager(Department department)
        {
            InitializeComponent();
            _department = department;
            LoadEmployees();
            LoadManager();
            CB_ListEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            ChangeManager();
        }

        private void CB_ListEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection connection = SQLConnector.GetConnection(1))
            {
                try
                {
                    employees = employeeBUS.GetEmployeesByDepartment(_department.DepartmentID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                CB_ListEmployee.DataSource = employees;
                CB_ListEmployee.DisplayMember = "Name";
                CB_ListEmployee.ValueMember = "Id";
            }
        }

        private void LoadManager()
        {
            Employee manager = employeeBUS.GetManagerByDepartment(_department.DepartmentID);
            txt_currentManager.Text = manager.Name;
            this.manager = manager;
        }

        private void ChangeManager()
        {
            var selectedEmployee = (Employee)CB_ListEmployee.SelectedItem;
            string oldManagerID = manager.Id;
            string newManagerID = selectedEmployee.Id;
            try
            {
                if (oldManagerID != newManagerID)
                {
                    departmentBUS.ChangeManager(oldManagerID, newManagerID);
                    MessageBox.Show("Đổi trưởng phòng thành công !!!");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đổi trưởng phòng thất bại !!!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using ComponentFactory.Krypton.Toolkit;
using DTO;

namespace QuanLyNhanVien.Modal
{
    public partial class Modal_EditEmployee : KryptonForm
    {
        private readonly EmployeeBUS employeeBUS;
        private readonly DepartmentBUS departmentBUS;
        private string employeeID;
        public Modal_EditEmployee(EmployeeBUS employeeBUS, DepartmentBUS departmentBUS, string employeeID)
        {
            InitializeComponent();
            this.employeeBUS = employeeBUS;
            this.departmentBUS = departmentBUS;
            this.employeeID = employeeID;
            LoadEmployeeInformation();
        }

        public void LoadEmployeeInformation()
        {
            Employee employee = employeeBUS.GetEmployeeByID(employeeID);
            tb_manv.Text = employee.Id;
            tb_tennv.Text = employee.Name;
            tb_taikhoan.Text = employee.Username;
            tb_email.Text = employee.Email;
            tb_masothue.Text = employee.TaxNumber;
            dtp_ngaysinh.Value = employee.DateOfBirth;
            tb_department.Text = employee.DepartmentName;
            tb_role.Text = employee.RoleName;
            tb_luong.Text = employee.BasicSalary.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee
                {
                    Id = tb_manv.Text,
                    Name = tb_tennv.Text,
                    Email = tb_email.Text,
                    TaxNumber = tb_masothue.Text,
                    DateOfBirth = dtp_ngaysinh.Value,
                    BasicSalary = float.Parse(tb_luong.Text),
                    Password = tb_matkhau.Text
                };

                bool isUpdated = employeeBUS.UpdateEmployee(employee, tb_department.Text);
                if(isUpdated)
                {
                    MessageBox.Show("Sửa thành công !");
                } else
                {
                    MessageBox.Show("Sửa thất bại !!!");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại !!!");
            }

        }
    }
}

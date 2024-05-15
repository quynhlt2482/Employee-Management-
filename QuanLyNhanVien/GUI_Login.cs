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
using ComponentFactory.Krypton.Toolkit;
using BUS;
using DTO;
using DAL;

namespace QuanLyNhanVien
{
    public partial class GUI_Login : KryptonForm
    {
        Employee employee = new Employee();
        EmployeeBUS employeeBUS = new EmployeeBUS();

        public GUI_Login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //tien comment
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            employee.Username = txt_user.Text.Trim();
            employee.Password = txt_pass.Text.Trim();
            int checkLogin = employeeBUS.CheckLogin(employee);

            if (checkLogin == 1)
            {
                GUI_MainScreen p = new GUI_MainScreen();
                p.Show();
                this.Hide();
            } else if (checkLogin == 0)
            {
                MessageBox.Show("Tai khoan khong ton tai hoac sai mat khau");
            } else if (checkLogin == -1)
            {
                MessageBox.Show("Tai khoan hoac mat khau khong duoc de trong");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using ComponentFactory.Krypton.Toolkit;
using DTO;

namespace QuanLyNhanVien.Modal
{
    public partial class Modal_EditPayroll : KryptonForm
    {
        private string id;
        private string manv;

        private readonly PayrollBUS payrollBUS = new PayrollBUS();
        public Modal_EditPayroll(string id, string manv)
        {
            this.id = id;
            this.manv = manv;
            InitializeComponent();
            LoadingData();

        }

        private void LoadingData()
        {
            Payroll p = payrollBUS.SelectPayrollByEmployee(id, manv);
           
            tb_maluong.Text = p.PayrollID;
            tb_tongngaylam.Text = p.WorkdayAmount.ToString();
            tb_songaynghi.Text = p.DayoffAmount.ToString();
            tb_tongtiennhan.Text = p.SalaryAmount.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Payroll payroll = new Payroll(tb_maluong.Text, float.Parse(tb_tongtiennhan.Text), float.Parse(tb_tongngaylam.Text), float.Parse(tb_songaynghi.Text), manv, id);
            if (payrollBUS.UpdatePayroll(payroll) == true )
            {
                MessageBox.Show("Cập nhật thất bại");
            } else
            {
                MessageBox.Show("Cập nhật thành công");
            }
            
            this.Close();
        }
    }
}

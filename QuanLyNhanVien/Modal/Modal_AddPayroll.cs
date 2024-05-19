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
    public partial class Modal_AddPayroll : KryptonForm
    {
        private readonly PayrollBUS payrollBUS = new PayrollBUS();

        private string manv;
        private string id;
        public Modal_AddPayroll(string id, string manv)
        {
            this.manv = manv;
            this.id = id;
            InitializeComponent();
            tb_maluong.Text = GenerateRandomId();
            tb_maluong.Enabled = false;
        }

        public string GenerateRandomId()
        {
            Guid guid = Guid.NewGuid();

            byte[] bytes = guid.ToByteArray();

            string base64 = Convert.ToBase64String(bytes);

            string shortId = base64.Replace("=", "").Replace("/", "").Replace("+", "");


            return "PRL_" + shortId;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            Payroll payroll = new Payroll(tb_maluong.Text,float.Parse(tb_tongtiennhan.Text),float.Parse(tb_tongngaylam.Text),float.Parse(tb_songaynghi.Text),manv,id) ;
            payrollBUS.InsertPayroll(payroll);
            MessageBox.Show("Thêm thành công!!!");
            this.Close();
        }
    }
}

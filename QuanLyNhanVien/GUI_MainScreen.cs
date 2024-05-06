 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace QuanLyNhanVien
{
    public partial class GUI_MainScreen : KryptonForm
    {

        private Form currentChildForm;
        public GUI_MainScreen()
        {
            InitializeComponent();

        }
        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DisableOtherButtons(Control clickedButton)
        {
            foreach (Control control in pn_select.Controls)
            {
                if (control != clickedButton && control is ComponentFactory.Krypton.Toolkit.KryptonCheckButton)
                {
                    ((ComponentFactory.Krypton.Toolkit.KryptonCheckButton)control).Checked = false;
                }
            }
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_child.Controls.Add(childForm);
            pn_child.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            DisableOtherButtons((Control)sender);
            OpenChildForm(new Panel_ListOfEmployee());
            lb_title.Text = "Danh sách nhân viên";
            ptb_title.Image = Image.FromFile("E:\\Employee-Management-\\QuanLyNhanVien\\Icon\\employee.png");
        
        }

        private void btn_phongban_Click(object sender, EventArgs e)
        {
            DisableOtherButtons((Control)sender);
            OpenChildForm(new Panel_ListOfDepartment());
            lb_title.Text = "Danh sách phòng ban";
            ptb_title.Image = Image.FromFile("E:\\Employee-Management-\\QuanLyNhanVien\\Icon\\department.png");

        }

        private void btn_chamcong_Click(object sender, EventArgs e)
        {
            DisableOtherButtons((Control)sender);
            OpenChildForm(new Panel_AllTimeKeeping());
            lb_title.Text = "Bảng chấm công";
            ptb_title.Image = Image.FromFile("E:\\Employee-Management-\\QuanLyNhanVien\\Icon\\check in_out.png");

        }

        private void btn_theodoi_Click(object sender, EventArgs e)
        {
            DisableOtherButtons((Control)sender);
            OpenChildForm(new Panel_ConfirmEdit());
            lb_title.Text = "Giám sát chỉnh sửa";
            ptb_title.Image = Image.FromFile("E:\\Employee-Management-\\QuanLyNhanVien\\Icon\\history.png");

        }

        private void btn_luong_Click(object sender, EventArgs e)
        {
            DisableOtherButtons((Control)sender);
            lb_title.Text = "Danh sách lương nhận";
            ptb_title.Image = Image.FromFile("E:\\Employee-Management-\\QuanLyNhanVien\\Icon\\salary.png");

        }

        private void btn_ca_Click(object sender, EventArgs e)
        {
            DisableOtherButtons((Control)sender);
            OpenChildForm(new Panel_ListOfTimeWork());
            lb_title.Text = "Quản lý ca làm";
            ptb_title.Image = Image.FromFile("E:\\Employee-Management-\\QuanLyNhanVien\\Icon\\calendar.png");
        }

    }
}

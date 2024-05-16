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
using QuanLyNhanVien.Panel_MainScreen;

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
            string projectDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath));
            string imagePath = Path.Combine(projectDirectory, "Icon", "employee.png");
            ptb_title.Image = Image.FromFile(imagePath);
        }

        private void btn_phongban_Click(object sender, EventArgs e)
        {
            DisableOtherButtons((Control)sender);
            OpenChildForm(new Panel_ListOfDepartment());
            lb_title.Text = "Danh sách phòng ban";
            string projectDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath));
            string imagePath = Path.Combine(projectDirectory, "Icon", "department.png");
            ptb_title.Image = Image.FromFile(imagePath);

        }

        private void btn_chamcong_Click(object sender, EventArgs e)
        {
            DisableOtherButtons((Control)sender);
            OpenChildForm(new Panel_AllTimeKeeping());
            lb_title.Text = "Bảng chấm công";
            string projectDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath));
            string imagePath = Path.Combine(projectDirectory, "Icon", "check in_out.png");
            ptb_title.Image = Image.FromFile(imagePath);
        }

        private void btn_theodoi_Click(object sender, EventArgs e)
        {
            DisableOtherButtons((Control)sender);
            OpenChildForm(new Panel_ConfirmEdit());
            lb_title.Text = "Giám sát chỉnh sửa";
            string projectDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath));
            string imagePath = Path.Combine(projectDirectory, "Icon", "history.png");
            ptb_title.Image = Image.FromFile(imagePath);

        }

        private void btn_luong_Click(object sender, EventArgs e)
        {
            DisableOtherButtons((Control)sender);
            OpenChildForm(new Panel_ListOfSalary());
            lb_title.Text = "Danh sách lương nhận";
            string projectDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath));
            string imagePath = Path.Combine(projectDirectory, "Icon", "salary.png");
            ptb_title.Image = Image.FromFile(imagePath);
        }

        private void btn_ca_Click(object sender, EventArgs e)
        {
            DisableOtherButtons((Control)sender);
            OpenChildForm(new Panel_ListOfTimeWork());
            lb_title.Text = "Quản lý ca làm";
            string projectDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath));
            string imagePath = Path.Combine(projectDirectory, "Icon", "calendar.png");
            ptb_title.Image = Image.FromFile(imagePath);
        }

        private void btn_hopdong_Click(object sender, EventArgs e)
        {
            DisableOtherButtons((Control)sender);
            OpenChildForm(new Panel_ListOfContact());
            lb_title.Text = "Hợp đồng";

            string projectDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath));
            string imagePath = Path.Combine(projectDirectory, "Icon", "contract.png");
            ptb_title.Image = Image.FromFile(imagePath);
        }
    }
}

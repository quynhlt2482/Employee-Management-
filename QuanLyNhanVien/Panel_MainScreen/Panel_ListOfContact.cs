using BUS;
using ComponentFactory.Krypton.Toolkit;
using DTO;
using QuanLyNhanVien.Modal;
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

namespace QuanLyNhanVien.Panel_MainScreen
{
    public partial class Panel_ListOfContact : Form
    {

        private string manv;
        private readonly EmployeeContractBUS employeeContractBUS = new EmployeeContractBUS();

        public Panel_ListOfContact(string manv)
        {
            InitializeComponent();
            AddMouseEventsToPictureBoxes();
            this.manv = manv;
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

        private void ptb_edit_Click(object sender, EventArgs e)
        {
            dtp_ngaybatdau.Enabled = true;
            dtp_ngayketthuc.Enabled = true;
            tb_trangthai.Enabled = true;
            tb_loaihopdong.Enabled = true;
            ptb_cancel.Visible = true;
            ptb_checked.Visible = true;
            ptb_edit.Visible = false;
        }
        private void ptb_back_Click(object sender, EventArgs e)
        {
            GUI_MainScreen mainScreen = this.ParentForm as GUI_MainScreen;

            if (mainScreen != null)
            {
                mainScreen.OpenChildForm(new Panel_ListOfEmployee());
            }
        }

        public void LoadInformation()
        {
            try
            {
                EmployeeContract p = employeeContractBUS.GetEmployeeContract(manv);

                tb_mahopdong.Text = p.contractID;
                tb_manv.Text = p.EmployeeId;
                dtp_ngaybatdau.Value = p.StartDate;
                dtp_ngayketthuc.Value = p.EndDate;
                tb_trangthai.Text = p.Status.ToString();
                tb_loaihopdong.Text = p.ContractType;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Panel_ListOfContact_Load(object sender, EventArgs e)
        {
            LoadInformation();
            dtp_ngaybatdau.Enabled = false;
            dtp_ngayketthuc.Enabled = false;
            tb_trangthai.Enabled = false;
            tb_loaihopdong.Enabled = false;
            ptb_cancel.Visible = false;
            ptb_checked.Visible = false;
        }

        public void actionEdit()
        {
            dtp_ngaybatdau.Enabled = false;
            dtp_ngayketthuc.Enabled = false;
            tb_trangthai.Enabled = false;
            tb_loaihopdong.Enabled = false;
            ptb_edit.Visible = true;
            ptb_cancel.Visible = false;
            ptb_checked.Visible = false;
        }
        private void ptb_cancel_Click(object sender, EventArgs e)
        {
            actionEdit();
        }

        private void ptb_checked_Click(object sender, EventArgs e)
        {
            try
            {
                actionEdit();
                bool trangthai;
                if (tb_trangthai.Text == "false")
                    trangthai = false;
                else
                    trangthai = true;
                employeeContractBUS.UpdateEmployeeContract(tb_mahopdong.Text, dtp_ngaybatdau.Value, dtp_ngayketthuc.Value, trangthai, tb_loaihopdong.Text);
            } catch (Exception ex)
            {
                MessageBox.Show("error at checked click: " + ex.Message);
            }
        }

    }
}

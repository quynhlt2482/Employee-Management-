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
        public Panel_ListOfTimeKeepingDetail()
        {
            InitializeComponent();
            AddMouseEventsToPictureBoxes();
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

        private void ptb_back_Click(object sender, EventArgs e)
        {
            GUI_MainScreen mainScreen = this.ParentForm as GUI_MainScreen;

            if (mainScreen != null)
            {
                mainScreen.OpenChildForm(new Panel_AllTimeKeeping());
            }
        }

        private void ptb_add_Click(object sender, EventArgs e)
        {
            Modal_AddTimeKeepingDetail p = new Modal_AddTimeKeepingDetail();
            p.Show();
        }

        private void ptb_edit_Click(object sender, EventArgs e)
        {
            Modal_EditTimeKeepingDetail p = new Modal_EditTimeKeepingDetail();
            p.Show();
        }
    }
}

using QuanLyNhanVien.Modal;
using QuanLyNhanVien.Panel_MainScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhanVien
{
    public partial class Panel_AllTimeKeeping : Form
    {
        public Panel_AllTimeKeeping()
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

        private void cb_thang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Panel_AllTimeKeeping_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                cb_thang.Items.Add(i);
            }
        }

        private void ptb_add_Click(object sender, EventArgs e)
        {
            Modal_AddTimeKeeping p = new Modal_AddTimeKeeping();
            p.Show();
        }

        private void ptb_detail_Click(object sender, EventArgs e)
        {
            GUI_MainScreen mainScreen = this.ParentForm as GUI_MainScreen;

            if (mainScreen != null)
            {
                mainScreen.OpenChildForm(new Panel_ListOfTimeKeepingDetail());
            }
        }
    
    }
}

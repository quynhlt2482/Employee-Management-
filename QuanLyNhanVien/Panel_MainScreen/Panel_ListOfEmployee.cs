﻿using QuanLyNhanVien.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class Panel_ListOfEmployee : Form
    {
        public Panel_ListOfEmployee()
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

        private void ptb_add_Click(object sender, EventArgs e)
        {
            Modal_AddEmployee p = new Modal_AddEmployee();
            p.Show();
        }

        private void ptb_edit_Click(object sender, EventArgs e)
        {
            Modal_EditEmployee p = new Modal_EditEmployee();
            p.Show();
        }
    }
}

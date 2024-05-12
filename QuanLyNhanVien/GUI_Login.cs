﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace QuanLyNhanVien
{
    public partial class GUI_Login : KryptonForm
    {
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
            GUI_MainScreen p = new GUI_MainScreen();
            p.Show();
            this.Hide();
        }
    }
}

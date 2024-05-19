﻿using BUS;
using DTO;
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

        private string selectedTimeKeepingID;

        private readonly TimeKeepingBUS timeKeepingBUS = new TimeKeepingBUS();

        public Panel_AllTimeKeeping()
        {
            InitializeComponent();
            AddMouseEventsToPictureBoxes();
            LoadTimeKeeping();
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

        private DataTable ConvertToDataTable(List<Timekeeping> timekeepings)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Mã Chấm Công");
            dataTable.Columns.Add("Tháng");
            dataTable.Columns.Add("Năm");

            foreach (var Timekeeping in timekeepings)
            {

                dataTable.Rows.Add(
                    Timekeeping.TimeKeepingID,
                    Timekeeping.Month.ToString(),
                    Timekeeping.Year.ToString()  
                ) ;
            }

            return dataTable;
        }
        private void LoadTimeKeeping()
        {
            try
            {
                List<Timekeeping> timekeepings = timeKeepingBUS.GetAllTimeKeeping();
                dtg_bangchamcong.DataSource = ConvertToDataTable(timekeepings);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error at LoadShift : {ex.Message}");
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
            if (timeKeepingBUS.ExitstTimeKeeping())
            {
                MessageBox.Show("Đã có bảng công tháng này rồi");
            } else
            {
                timeKeepingBUS.InsertTimeKeeping();
                MessageBox.Show("Thêm chấm công mới thành công");
                LoadTimeKeeping();
            }       
            
        }

        private void ptb_detail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedTimeKeepingID))
            {
                MessageBox.Show("Bạn chưa chọn bảng công nào !!!");
                return;
            } else
            {
                GUI_MainScreen mainScreen = this.ParentForm as GUI_MainScreen;

                if (mainScreen != null)
                {
                    mainScreen.OpenChildForm(new Panel_ListOfTimeKeepingDetail(selectedTimeKeepingID));
                }
            }
            
        }

        private void dtg_bangchamcong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_bangchamcong.Rows[e.RowIndex];
                selectedTimeKeepingID = row.Cells["Mã Chấm Công"].Value.ToString();
            }
        }
    }
}

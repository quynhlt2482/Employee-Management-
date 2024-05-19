using BUS;
using DTO;
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
    public partial class Panel_ListOfSalary : Form
    {

        private string selectedTimeKeepingID;
        private int selectedMonth;

        private readonly TimeKeepingBUS timeKeepingBUS = new TimeKeepingBUS();
        public Panel_ListOfSalary()
        {
            InitializeComponent();
            AddMouseEventsToPictureBoxes();
            LoadTimeKeeping();
        }

        private DataTable ConvertToDataTable(List<Timekeeping> timekeepings)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Mã");
            dataTable.Columns.Add("Tháng");
            dataTable.Columns.Add("Năm");

            foreach (var Timekeeping in timekeepings)
            {
                dataTable.Rows.Add(
                    Timekeeping.TimeKeepingID,
                    Timekeeping.Month.ToString(),
                    Timekeeping.Year.ToString()
                );
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

        private void LoadTimeKeepingYear(int year)
        {
            try
            {
                List<Timekeeping> timekeepings = timeKeepingBUS.GetAllTimeKeepingYear(year);
                dtg_bangchamcong.DataSource = ConvertToDataTable(timekeepings);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error at LoadShift : {ex.Message}");
            }
        }

        private void LoadTimeKeepingYearMonth(int year, int month)
        {
            try
            {
                List<Timekeeping> timekeepings = timeKeepingBUS.GetAllTimeKeepingYearMonth(year, month);
                dtg_bangchamcong.DataSource = ConvertToDataTable(timekeepings);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error at LoadShift : {ex.Message}");
            }
        }

        private void LoadTimeKeepingMonth(int month)
        {
            try
            {
                List<Timekeeping> timekeepings = timeKeepingBUS.GetAllTimeKeepingMonth(month);
                dtg_bangchamcong.DataSource = ConvertToDataTable(timekeepings);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error at LoadShift : {ex.Message}");
            }
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
            selectedMonth = cb_thang.SelectedIndex + 1;
            if (tb_nam.Text == "")
            {
                LoadTimeKeepingMonth(selectedMonth);
            }
            else
                LoadTimeKeepingYearMonth(int.Parse(tb_nam.Text), selectedMonth);
        }

        private void Panel_ListOfSalary_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                cb_thang.Items.Add(i);
            }
        }

        private void dtg_bangchamcong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_bangchamcong.Rows[e.RowIndex];
                selectedTimeKeepingID = row.Cells["Mã"].Value.ToString();
            }
        }

        private void tb_nam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadTimeKeepingYear(int.Parse(tb_nam.Text));
                e.Handled = true;
            }
        }

        private void ptb_detail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedTimeKeepingID))
            {
                MessageBox.Show("Bạn chưa chọn bảng lương nào !!!");
                return;
            }
            else
            {
                GUI_MainScreen mainScreen = this.ParentForm as GUI_MainScreen;

                if (mainScreen != null)
                {
                    mainScreen.OpenChildForm(new Panel_ListOfPayroll(selectedTimeKeepingID));
                }
            }
        }
    }
}

using BUS;
using DAL;
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

namespace QuanLyNhanVien
{
    public partial class Panel_ListOfTimeWork : Form
    {

        private string selectedShiftID;

        private readonly ShiftBUS shiftBUS = new ShiftBUS();
        public Panel_ListOfTimeWork()
        {
            InitializeComponent();
            AddMouseEventsToPictureBoxes();
            LoadShift(); 
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
            Modal_AddShift addShiftForm = new Modal_AddShift();
            addShiftForm.FormClosed += new FormClosedEventHandler(ChildForm_FormClosed);
            addShiftForm.Show();
        }

        private void dtg_ca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_ca.Rows[e.RowIndex];
                selectedShiftID = row.Cells["Mã Ca"].Value.ToString();
            }
        }

        private void ptb_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedShiftID))
            {
                MessageBox.Show("Bạn chưa chọn ca cần sửa !!!");
                return;
            }
            else
            {
                Modal_EditShift editShiftForm = new Modal_EditShift(selectedShiftID);
                editShiftForm.FormClosed += new FormClosedEventHandler(ChildForm_FormClosed);
                editShiftForm.Show();

            }
            
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadShift();
        }

        private void LoadShift()
        {
            try
            {
                List <Shift> shifts = shiftBUS.GetInformationListShift();
                dtg_ca.DataSource = ConvertToDataTable(shifts);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error at LoadShift : {ex.Message}");
            }
        }
        private DataTable ConvertToDataTable(List<Shift> shifts)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Mã Ca");
            dataTable.Columns.Add("Tên Ca");
            dataTable.Columns.Add("Thời gian bắt đầu");
            dataTable.Columns.Add("Thời gian kết thúc");
            dataTable.Columns.Add("Tổng thời gian");
            dataTable.Columns.Add("Hệ số lương");


            foreach (var Shift in shifts)
            {

                dataTable.Rows.Add(
                    Shift.ShiftID,
                    Shift.ShiftName,
                    Shift.StartTime.ToString("hh\\:mm"),
                    Shift.EndTime.ToString("hh\\:mm"),
                    Shift.TotalTime.ToString("hh\\:mm"),
                    Shift.CoefficientSalary.ToString()
                );
            }

            return dataTable;
        }

        private void ptb_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedShiftID))
            {
                MessageBox.Show("Bạn chưa chọn nhân viên cần xóa !!!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa ca làm này ?",
                                                    "Xác nhận xóa",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    bool isDeleted = shiftBUS.DeleteShip(selectedShiftID);
                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa ca làm thành công !");
                        LoadShift();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại !!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error at delete btn: " + ex.Message);
                }
            }
        }
    }
}

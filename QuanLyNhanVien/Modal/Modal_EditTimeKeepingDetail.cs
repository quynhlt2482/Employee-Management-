using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using ComponentFactory.Krypton.Toolkit;
using DTO;


namespace QuanLyNhanVien.Modal
{
    public partial class Modal_EditTimeKeepingDetail : KryptonForm
    {

        private readonly TimeKeepingDetailBUS timeKeepingDetailBUS = new TimeKeepingDetailBUS();
        private readonly ShiftBUS shiftBUS = new ShiftBUS();
        private string macalam;

        private string timekeepingID;
        private string tkDetailID;
        private string manv;
        public Modal_EditTimeKeepingDetail(string timekeepingID, string tkDetailID, string manv)
        {
            this.timekeepingID = timekeepingID;
            this.tkDetailID = tkDetailID;
            this.manv = manv;
            InitializeComponent();
            dtp_checkin.Format = DateTimePickerFormat.Time;
            dtp_checkin.ShowUpDown = true;
            dtp_checkout.Format = DateTimePickerFormat.Time;
            dtp_checkout.ShowUpDown = true;
            dtp_late.Format = DateTimePickerFormat.Time;
            dtp_late.ShowUpDown = true;
            LoadShifts();
            LoadingData();
        }

        private void LoadingData()
        {
            TimekeepingDetail timekeepingDetail = timeKeepingDetailBUS.GetTimekeepingDetail(timekeepingID,tkDetailID,manv);

            tb_mangaycong.Text = timekeepingDetail.TkDetailID.ToString();
            tb_thu.Text = timekeepingDetail.DayOfweek;

            if (timekeepingDetail.ShiftId == null)
            {
                cb_calam.Text = "";
            } 
            else
                cb_calam.Text = shiftBUS.GetInformationShift(timekeepingDetail.ShiftId).ShiftName;

            DateTime today = DateTime.Today;
            dtp_checkin.Value = today.Add(timekeepingDetail.CheckIn);
            dtp_checkout.Value = today.Add(timekeepingDetail.CheckOut);
            dtp_late.Value = today.Add(timekeepingDetail.Late);

        }

        private void LoadShifts()
        {
            List<Shift> shifts;

            try
            {
                shifts = shiftBUS.GetInformationListShift();

                cb_calam.DataSource = shifts;
                cb_calam.DisplayMember = "shiftName";
                cb_calam.ValueMember = "shiftID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at LoadDepartments: " + ex.Message);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            TimeSpan checkin = dtp_checkin.Value.TimeOfDay;
            TimeSpan checkout = dtp_checkout.Value.TimeOfDay;
            TimeSpan late;
            Shift shift = shiftBUS.GetInformationShift(macalam);
            if (checkin > shift.StartTime)
            {
                late = checkin - shift.StartTime;
                
            }
            else
                late = TimeSpan.Zero;

            TimekeepingDetail timekeepingDetail = new TimekeepingDetail(int.Parse(tb_mangaycong.Text),tb_thu.Text,checkin,checkout,late,macalam,timekeepingID,manv);


            timeKeepingDetailBUS.UpdateTimeKeepingDetail(timekeepingDetail);

            MessageBox.Show("Sửa thông tin thành công!!!!");
            this.Close();
        }

        private void cb_calam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_calam.SelectedItem is Shift selectedShift)
            {
                macalam = selectedShift.ShiftID;
            }
        }
    }
}

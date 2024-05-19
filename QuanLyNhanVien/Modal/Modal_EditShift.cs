using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using ComponentFactory.Krypton.Toolkit;

namespace QuanLyNhanVien.Modal
{
    public partial class Modal_EditShift : KryptonForm
    {
        private string shiftID;

        private readonly ShiftBUS shiftBUS = new ShiftBUS();
        public Modal_EditShift(string shiftID)
        {
            InitializeComponent();
            dtp_timestart.Format = DateTimePickerFormat.Time;
            dtp_timestart.ShowUpDown = true;
            dtp_timeend.Format = DateTimePickerFormat.Time;
            dtp_timeend.ShowUpDown = true;
            this.shiftID = shiftID;
            LoadingData();          
        }


        private void LoadingData()
        {
            Shift shift = shiftBUS.GetInformationShift(this.shiftID);
            tb_maca.Text = shift.ShiftID;
            tb_tenca.Text = shift.ShiftName;

            DateTime today = DateTime.Today;
            dtp_timestart.Value = today.Add(shift.StartTime);
            dtp_timeend.Value = today.Add(shift.EndTime);
            tb_tongtime.Text = shift.TotalTime.ToString();
            tb_hesoluong.Text = shift.CoefficientSalary.ToString();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            TimeSpan startTime = dtp_timestart.Value.TimeOfDay;
            TimeSpan endTime = dtp_timeend.Value.TimeOfDay;
            TimeSpan totalTime;


            if (startTime > endTime)

                totalTime = TimeSpan.FromHours(24) - startTime + endTime;
            else
            {
                totalTime = endTime - startTime;
            }


            float coefficientSalary = float.Parse(tb_hesoluong.Text);
            Shift shift = new Shift(tb_maca.Text, tb_tenca.Text, startTime, endTime, totalTime, coefficientSalary);

            shiftBUS.UpdateInformationShift(shift);

            MessageBox.Show("Sửa thông tin thành công!!!!");
            LoadingData();
            this.Close();
        }
    }
}

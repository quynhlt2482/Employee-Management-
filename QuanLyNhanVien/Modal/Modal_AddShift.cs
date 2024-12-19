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
    public partial class Modal_AddShift : KryptonForm
    {
        ShiftBUS shiftBUS = new ShiftBUS();
        public Modal_AddShift()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            tb_maca.Text = GenerateRandomId();
            dtp_timestart.Format = DateTimePickerFormat.Time;
            dtp_timestart.ShowUpDown = true;
            dtp_timeend.Format = DateTimePickerFormat.Time;
            dtp_timeend.ShowUpDown = true;
        }

        public string GenerateRandomId()
        {
            Guid guid = Guid.NewGuid();

            byte[] bytes = guid.ToByteArray();

            string base64 = Convert.ToBase64String(bytes);
            
            string shortId = base64.Replace("=", "").Replace("/", "").Replace("+", "");


            return "CALAM_" + shortId;
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
            Shift shift = new Shift(tb_maca.Text,tb_tenca.Text,startTime,endTime, totalTime, coefficientSalary);

            shiftBUS.insertShiftBUS(shift);

            MessageBox.Show("Thêm ca làm thành công !");
            this.Close();

        }
    }
}

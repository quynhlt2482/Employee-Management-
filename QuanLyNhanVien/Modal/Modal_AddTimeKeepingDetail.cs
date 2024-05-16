using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;


namespace QuanLyNhanVien.Modal
{
    public partial class Modal_AddTimeKeepingDetail : KryptonForm
    {
        public Modal_AddTimeKeepingDetail()
        {
            InitializeComponent();
            dtp_checkin.Format = DateTimePickerFormat.Time;
            dtp_checkin.ShowUpDown = true;
            dtp_checkout.Format = DateTimePickerFormat.Time;
            dtp_checkout.ShowUpDown = true;

        }
    }
}

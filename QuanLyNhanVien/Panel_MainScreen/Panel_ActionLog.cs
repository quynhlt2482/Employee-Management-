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

namespace QuanLyNhanVien
{
    public partial class Panel_ConfirmEdit : Form
    {
        private readonly ActionLogBUS actionLoggedBUS = new ActionLogBUS();
        public Panel_ConfirmEdit()
        {
            InitializeComponent();
            LoadLog();
        }

        private void LoadLog()
        {
            try
            {
                List<ActionLog> actionLogs = actionLoggedBUS.GetAllActionLogged();

                // Bind the retrieved data to the DataGridView
                dtg_log.DataSource = actionLogs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

<<<<<<< HEAD
﻿using DAL;
=======
﻿using QuanLyNhanVien.Modal;
>>>>>>> origin/quynh
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class Panel_ListOfDepartment : Form
    {
        public Panel_ListOfDepartment()
        {
            InitializeComponent();
            AddMouseEventsToPictureBoxes();
            LoadDepartments();
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

<<<<<<< HEAD
        private void LoadDepartments()
        {
            // Tạo kết nối đến SQL Server
            using (SqlConnection connection = SQLConnector.GetConnection(1))
            {
                string query = "select * from department";
                // Tạo đối tượng SqlCommand để gọi thủ tục lưu trữ
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Tạo SqlDataAdapter để đổ dữ liệu vào DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        // Đổ dữ liệu vào DataTable
                        adapter.Fill(dataTable);

                        // Gán DataTable cho DataGridView để hiển thị
                        dtg_phongban.DataSource = dataTable;

                        if (dtg_phongban.Columns["departmentID"] != null)
                            dtg_phongban.Columns["departmentID"].HeaderText = "Mã phòng ban";

                        if (dtg_phongban.Columns["departmentName"] != null)
                            dtg_phongban.Columns["departmentName"].HeaderText = "Tên phòng ban";

                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Xử lý ngoại lệ nếu có
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
=======
        private void ptb_add_Click(object sender, EventArgs e)
        {
            Modal_AddDepartment p = new Modal_AddDepartment();
            p.Show();
        }

        private void ptb_edit_Click(object sender, EventArgs e)
        {
            Modal_EditDepartment p = new Modal_EditDepartment();
            p.Show();
>>>>>>> origin/quynh
        }
    }
}

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
using DAL;
using DTO;

namespace QuanLyNhanVien.Modal
{
    public partial class Modal_AddEmployee : KryptonForm
    {
        private readonly EmployeeBUS employeeBUS;
        private readonly DepartmentBUS departmentBUS;
        private readonly RoleBUS roleBUS = new RoleBUS();
        public Modal_AddEmployee(EmployeeBUS employeeBUS, DepartmentBUS departmentBUS)
        {
            InitializeComponent();
            this.employeeBUS = employeeBUS;
            this.departmentBUS = departmentBUS; 
            Load();
        }
        private void Load()
        {
            LoadDepartments();
            LoadRoles();
            tb_manv.Text = GenerateRandomId();
            cb_chucvu.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_phongban.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public string GenerateRandomId()
        {
            Guid guid = Guid.NewGuid();

            // Lấy byte array từ GUID
            byte[] bytes = guid.ToByteArray();

            // Mã hóa byte array thành Base64
            string base64 = Convert.ToBase64String(bytes);

            // Loại bỏ các ký tự không cần thiết (dấu '=' và '/')
            string shortId = base64.Replace("=", "").Replace("/", "").Replace("+", "");

            // Trả về chuỗi ID ngắn hơn
            return "NV_" + shortId;
        }

        private void LoadRoles()
        {
            List<Role> roles;
            try
            {
                roles = roleBUS.GetAllRoles();

                cb_chucvu.DataSource = roles;
                cb_chucvu.DisplayMember = "RoleName";
                cb_chucvu.ValueMember = "RoleID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at LoadRoles: " + ex.Message);
            }
        }

        private void LoadDepartments()
        {
            List<Department> departments;

            try
            {
                departments = departmentBUS.GetAllDepartments();

                cb_phongban.DataSource = departments;
                cb_phongban.DisplayMember = "DepartmentName";
                cb_phongban.ValueMember = "DepartmentID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at LoadDepartments: " + ex.Message);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee
                (
                    tb_manv.Text,
                    tb_tennv.Text,
                    tb_taikhoan.Text,
                    tb_matkhau.Text,
                    tb_email.Text,
                    dtp_ngaysinh.Value,
                    tb_masothue.Text,
                    float.Parse(tb_luong.Text),
                    cb_phongban.SelectedValue.ToString(),
                    cb_chucvu.SelectedValue.ToString()
                );

                bool isInserted = employeeBUS.InsertEmployee(employee);

                if (isInserted)
                {
                    MessageBox.Show("Thêm nhân viên mới thành công !");
                    this.Close();
                } else
                {
                    MessageBox.Show("Thêm nhân viên thất bại !!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}

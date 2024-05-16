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
using DAL;
using DTO;
using ComponentFactory.Krypton.Toolkit;

namespace QuanLyNhanVien.Modal
{
    public partial class Modal_ChangeManager : KryptonForm
    {
        Department _department;
        Employee manager;
        
        public Modal_ChangeManager(Department department)
        {
            InitializeComponent();
            _department = department;
            LoadEmployees();
            CB_ListEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void LoadEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection connection = SQLConnector.GetConnection(1))
            {
                try
                {
                    SqlCommand command = new SqlCommand("SP_SELECT_EMPLOYEE", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@departmentID", _department.DepartmentID);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee employee = new Employee
                        {
                            Id = reader["employeeID"].ToString(),
                            Name = reader["employeeName"].ToString()
                        };
                        if (reader["roleId"].ToString() == "r1")
                        {
                            manager = employee;
                            txt_currentManager.Text = manager.Name;
                        }
                        employees.Add(employee);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                CB_ListEmployee.DataSource = employees;
                CB_ListEmployee.DisplayMember = "Name";
                CB_ListEmployee.ValueMember = "Id";
            }
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            ChangeManager();
        }

        private void ChangeManager()
        {
            var selectedEmployee = (Employee)CB_ListEmployee.SelectedItem;
            string oldManagerID = manager.Id;
            string newManagerID = selectedEmployee.Id;
            if(oldManagerID != newManagerID)
            {
                using (SqlConnection connection = SQLConnector.GetConnection(1))
                {
                    try
                    {
                        SqlCommand command = new SqlCommand("SP_CHANGE_MANAGER", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cần thiết cho stored procedure
                        command.Parameters.AddWithValue("@OldManagerID", oldManagerID);
                        command.Parameters.AddWithValue("@NewManagerID", newManagerID);

                        // Thực hiện stored procedure
                        command.ExecuteNonQuery();

                        MessageBox.Show("Đổi trưởng phòng thành công !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                        this.Close();
                    }
                }
            } else
            {
                this.Close();
            }
        }

        private void CB_ListEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}

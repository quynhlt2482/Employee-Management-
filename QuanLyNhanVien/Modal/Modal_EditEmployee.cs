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
    public partial class Modal_EditEmployee : KryptonForm
    {
        private readonly EmployeeBUS employeeBUS;
        private readonly DepartmentBUS departmentBUS;
        private readonly Employee employee;
        public Modal_EditEmployee(EmployeeBUS employeeBUS, DepartmentBUS departmentBUS)
        {
            InitializeComponent();
            this.employeeBUS = employeeBUS;
            this.departmentBUS = departmentBUS;
        }
    }
}

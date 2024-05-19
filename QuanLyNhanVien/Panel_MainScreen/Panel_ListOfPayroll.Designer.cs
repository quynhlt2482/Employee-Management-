namespace QuanLyNhanVien.Panel_MainScreen
{
    partial class Panel_ListOfPayroll
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.departmentCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_thang = new System.Windows.Forms.Label();
            this.cb_nhanvien = new System.Windows.Forms.ComboBox();
            this.dtg_payroll = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ptb_add = new System.Windows.Forms.PictureBox();
            this.ptb_edit = new System.Windows.Forms.PictureBox();
            this.ptb_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_payroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_back)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentCB
            // 
            this.departmentCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentCB.FormattingEnabled = true;
            this.departmentCB.Location = new System.Drawing.Point(676, 43);
            this.departmentCB.Name = "departmentCB";
            this.departmentCB.Size = new System.Drawing.Size(171, 24);
            this.departmentCB.TabIndex = 45;
            this.departmentCB.SelectedIndexChanged += new System.EventHandler(this.departmentCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(543, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Phòng ban";
            // 
            // lb_thang
            // 
            this.lb_thang.AutoSize = true;
            this.lb_thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thang.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_thang.Location = new System.Drawing.Point(133, 47);
            this.lb_thang.Name = "lb_thang";
            this.lb_thang.Size = new System.Drawing.Size(130, 25);
            this.lb_thang.TabIndex = 41;
            this.lb_thang.Text = "Mã nhân viên";
            // 
            // cb_nhanvien
            // 
            this.cb_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nhanvien.FormattingEnabled = true;
            this.cb_nhanvien.Location = new System.Drawing.Point(282, 44);
            this.cb_nhanvien.Name = "cb_nhanvien";
            this.cb_nhanvien.Size = new System.Drawing.Size(135, 28);
            this.cb_nhanvien.TabIndex = 40;
            this.cb_nhanvien.SelectedIndexChanged += new System.EventHandler(this.cb_nhanvien_SelectedIndexChanged);
            // 
            // dtg_payroll
            // 
            this.dtg_payroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_payroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_payroll.Location = new System.Drawing.Point(42, 120);
            this.dtg_payroll.Name = "dtg_payroll";
            this.dtg_payroll.RowHeadersWidth = 51;
            this.dtg_payroll.RowTemplate.Height = 24;
            this.dtg_payroll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_payroll.Size = new System.Drawing.Size(1103, 598);
            this.dtg_payroll.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dtg_payroll.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dtg_payroll.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dtg_payroll.TabIndex = 39;
            this.dtg_payroll.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_payroll_CellClick);
            // 
            // ptb_add
            // 
            this.ptb_add.Image = global::QuanLyNhanVien.Properties.Resources.add;
            this.ptb_add.Location = new System.Drawing.Point(942, 32);
            this.ptb_add.Name = "ptb_add";
            this.ptb_add.Size = new System.Drawing.Size(50, 50);
            this.ptb_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_add.TabIndex = 46;
            this.ptb_add.TabStop = false;
            this.ptb_add.Click += new System.EventHandler(this.ptb_add_Click);
            // 
            // ptb_edit
            // 
            this.ptb_edit.Image = global::QuanLyNhanVien.Properties.Resources.edit_2;
            this.ptb_edit.Location = new System.Drawing.Point(1045, 32);
            this.ptb_edit.Name = "ptb_edit";
            this.ptb_edit.Size = new System.Drawing.Size(50, 50);
            this.ptb_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_edit.TabIndex = 44;
            this.ptb_edit.TabStop = false;
            this.ptb_edit.Click += new System.EventHandler(this.ptb_edit_Click);
            // 
            // ptb_back
            // 
            this.ptb_back.Image = global::QuanLyNhanVien.Properties.Resources.undo1;
            this.ptb_back.Location = new System.Drawing.Point(42, 32);
            this.ptb_back.Name = "ptb_back";
            this.ptb_back.Size = new System.Drawing.Size(50, 50);
            this.ptb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_back.TabIndex = 43;
            this.ptb_back.TabStop = false;
            this.ptb_back.Click += new System.EventHandler(this.ptb_back_Click);
            // 
            // Panel_ListOfPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1185, 819);
            this.Controls.Add(this.ptb_add);
            this.Controls.Add(this.departmentCB);
            this.Controls.Add(this.ptb_edit);
            this.Controls.Add(this.ptb_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_thang);
            this.Controls.Add(this.cb_nhanvien);
            this.Controls.Add(this.dtg_payroll);
            this.Name = "Panel_ListOfPayroll";
            this.Text = "Panel_ListOfPayroll";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_payroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox departmentCB;
        private System.Windows.Forms.PictureBox ptb_edit;
        private System.Windows.Forms.PictureBox ptb_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_thang;
        private System.Windows.Forms.ComboBox cb_nhanvien;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dtg_payroll;
        private System.Windows.Forms.PictureBox ptb_add;
    }
}
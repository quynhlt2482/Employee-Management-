﻿namespace QuanLyNhanVien
{
    partial class Panel_ListOfEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_ListOfEmployee));
            this.dtg_nhanvien = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.departmentCB = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.ptb_changeManager = new System.Windows.Forms.PictureBox();
            this.ptb_add = new System.Windows.Forms.PictureBox();
            this.ptb_delete = new System.Windows.Forms.PictureBox();
            this.ptb_edit = new System.Windows.Forms.PictureBox();
            this.ptb_detail = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_changeManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_nhanvien
            // 
            this.dtg_nhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_nhanvien.Location = new System.Drawing.Point(43, 119);
            this.dtg_nhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_nhanvien.MultiSelect = false;
            this.dtg_nhanvien.Name = "dtg_nhanvien";
            this.dtg_nhanvien.ReadOnly = true;
            this.dtg_nhanvien.RowHeadersWidth = 51;
            this.dtg_nhanvien.RowTemplate.Height = 24;
            this.dtg_nhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_nhanvien.Size = new System.Drawing.Size(1103, 598);
            this.dtg_nhanvien.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dtg_nhanvien.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dtg_nhanvien.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dtg_nhanvien.TabIndex = 0;
            this.dtg_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_nhanvien_CellClick);
            // 
            // departmentCB
            // 
            this.departmentCB.DropDownWidth = 121;
            this.departmentCB.Location = new System.Drawing.Point(43, 49);
            this.departmentCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.departmentCB.Name = "departmentCB";
            this.departmentCB.Size = new System.Drawing.Size(161, 25);
            this.departmentCB.TabIndex = 5;
            this.departmentCB.Text = "departments";
            this.departmentCB.SelectedIndexChanged += new System.EventHandler(this.kryptonComboBox1_SelectedIndexChanged);
            // 
            // ptb_changeManager
            // 
            this.ptb_changeManager.Image = ((System.Drawing.Image)(resources.GetObject("ptb_changeManager.Image")));
            this.ptb_changeManager.Location = new System.Drawing.Point(544, 20);
            this.ptb_changeManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptb_changeManager.Name = "ptb_changeManager";
            this.ptb_changeManager.Size = new System.Drawing.Size(51, 50);
            this.ptb_changeManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_changeManager.TabIndex = 7;
            this.ptb_changeManager.TabStop = false;
            this.ptb_changeManager.Click += new System.EventHandler(this.ptb_changeManager_Click);
            // 
            // ptb_add
            // 
            this.ptb_add.Image = global::QuanLyNhanVien.Properties.Resources.add_user__1_;
            this.ptb_add.Location = new System.Drawing.Point(675, 18);
            this.ptb_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptb_add.Name = "ptb_add";
            this.ptb_add.Size = new System.Drawing.Size(51, 50);
            this.ptb_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_add.TabIndex = 4;
            this.ptb_add.TabStop = false;
            this.ptb_add.Click += new System.EventHandler(this.ptb_add_Click);
            // 
            // ptb_delete
            // 
            this.ptb_delete.Image = global::QuanLyNhanVien.Properties.Resources.delete__1_;
            this.ptb_delete.Location = new System.Drawing.Point(1047, 20);
            this.ptb_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptb_delete.Name = "ptb_delete";
            this.ptb_delete.Size = new System.Drawing.Size(51, 50);
            this.ptb_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_delete.TabIndex = 3;
            this.ptb_delete.TabStop = false;
            this.ptb_delete.Click += new System.EventHandler(this.ptb_delete_Click);
            // 
            // ptb_edit
            // 
            this.ptb_edit.Image = global::QuanLyNhanVien.Properties.Resources.edit_2;
            this.ptb_edit.Location = new System.Drawing.Point(931, 18);
            this.ptb_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptb_edit.Name = "ptb_edit";
            this.ptb_edit.Size = new System.Drawing.Size(51, 50);
            this.ptb_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_edit.TabIndex = 2;
            this.ptb_edit.TabStop = false;
            this.ptb_edit.Click += new System.EventHandler(this.ptb_edit_Click);
            // 
            // ptb_detail
            // 
            this.ptb_detail.Image = global::QuanLyNhanVien.Properties.Resources.detail;
            this.ptb_detail.Location = new System.Drawing.Point(804, 20);
            this.ptb_detail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptb_detail.Name = "ptb_detail";
            this.ptb_detail.Size = new System.Drawing.Size(51, 50);
            this.ptb_detail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_detail.TabIndex = 1;
            this.ptb_detail.TabStop = false;
            this.ptb_detail.Click += new System.EventHandler(this.ptb_detail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Phòng ban";
            // 
            // Panel_ListOfEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1185, 818);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptb_changeManager);
            this.Controls.Add(this.departmentCB);
            this.Controls.Add(this.ptb_add);
            this.Controls.Add(this.ptb_delete);
            this.Controls.Add(this.ptb_edit);
            this.Controls.Add(this.ptb_detail);
            this.Controls.Add(this.dtg_nhanvien);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Panel_ListOfEmployee";
            this.Text = "Panel_ListOfEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_changeManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dtg_nhanvien;
        private System.Windows.Forms.PictureBox ptb_detail;
        private System.Windows.Forms.PictureBox ptb_edit;
        private System.Windows.Forms.PictureBox ptb_delete;
        private System.Windows.Forms.PictureBox ptb_add;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox departmentCB;
        private System.Windows.Forms.PictureBox ptb_changeManager;
        private System.Windows.Forms.Label label1;
    }
}
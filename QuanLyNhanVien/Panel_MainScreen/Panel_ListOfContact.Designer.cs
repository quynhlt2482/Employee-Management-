namespace QuanLyNhanVien.Panel_MainScreen
{
    partial class Panel_ListOfContact
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
            this.ptb_edit = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_ngayketthuc = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtp_ngaybatdau = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.tb_trangthai = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_mahopdong = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lb_thang = new System.Windows.Forms.Label();
            this.ptb_back = new System.Windows.Forms.PictureBox();
            this.tb_manv = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tb_loaihopdong = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptb_cancel = new System.Windows.Forms.PictureBox();
            this.ptb_checked = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_checked)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_edit
            // 
            this.ptb_edit.Image = global::QuanLyNhanVien.Properties.Resources.edit_2;
            this.ptb_edit.Location = new System.Drawing.Point(750, 28);
            this.ptb_edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptb_edit.Name = "ptb_edit";
            this.ptb_edit.Size = new System.Drawing.Size(38, 41);
            this.ptb_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_edit.TabIndex = 17;
            this.ptb_edit.TabStop = false;
            this.ptb_edit.Click += new System.EventHandler(this.ptb_edit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(269, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 36);
            this.label2.TabIndex = 34;
            this.label2.Text = "HỢP ĐỒNG LAO ĐỘNG";
            // 
            // dtp_ngayketthuc
            // 
            this.dtp_ngayketthuc.CalendarTodayDate = new System.DateTime(2024, 5, 16, 0, 0, 0, 0);
            this.dtp_ngayketthuc.Location = new System.Drawing.Point(472, 258);
            this.dtp_ngayketthuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_ngayketthuc.Name = "dtp_ngayketthuc";
            this.dtp_ngayketthuc.Size = new System.Drawing.Size(244, 31);
            this.dtp_ngayketthuc.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtp_ngayketthuc.StateCommon.Border.Rounding = 15;
            this.dtp_ngayketthuc.StateCommon.Border.Width = 1;
            this.dtp_ngayketthuc.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1);
            this.dtp_ngayketthuc.TabIndex = 82;
            this.dtp_ngayketthuc.ValueNullable = new System.DateTime(2024, 5, 15, 16, 28, 0, 0);
            // 
            // dtp_ngaybatdau
            // 
            this.dtp_ngaybatdau.CalendarTodayDate = new System.DateTime(2024, 5, 16, 0, 0, 0, 0);
            this.dtp_ngaybatdau.Location = new System.Drawing.Point(169, 258);
            this.dtp_ngaybatdau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_ngaybatdau.Name = "dtp_ngaybatdau";
            this.dtp_ngaybatdau.Size = new System.Drawing.Size(244, 31);
            this.dtp_ngaybatdau.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtp_ngaybatdau.StateCommon.Border.Rounding = 15;
            this.dtp_ngaybatdau.StateCommon.Border.Width = 1;
            this.dtp_ngaybatdau.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1);
            this.dtp_ngaybatdau.TabIndex = 81;
            this.dtp_ngaybatdau.ValueNullable = new System.DateTime(2024, 5, 15, 16, 28, 0, 0);
            // 
            // tb_trangthai
            // 
            this.tb_trangthai.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.tb_trangthai.Location = new System.Drawing.Point(170, 374);
            this.tb_trangthai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_trangthai.Name = "tb_trangthai";
            this.tb_trangthai.Size = new System.Drawing.Size(243, 33);
            this.tb_trangthai.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tb_trangthai.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tb_trangthai.StateCommon.Border.Rounding = 15;
            this.tb_trangthai.StateCommon.Border.Width = 1;
            this.tb_trangthai.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_trangthai.TabIndex = 80;
            this.tb_trangthai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(166, 351);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 79;
            this.label5.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(468, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 78;
            this.label6.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(469, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 77;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(165, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 76;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // tb_mahopdong
            // 
            this.tb_mahopdong.Enabled = false;
            this.tb_mahopdong.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.tb_mahopdong.Location = new System.Drawing.Point(168, 136);
            this.tb_mahopdong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_mahopdong.Name = "tb_mahopdong";
            this.tb_mahopdong.ReadOnly = true;
            this.tb_mahopdong.Size = new System.Drawing.Size(243, 33);
            this.tb_mahopdong.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tb_mahopdong.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tb_mahopdong.StateCommon.Border.Rounding = 15;
            this.tb_mahopdong.StateCommon.Border.Width = 1;
            this.tb_mahopdong.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mahopdong.TabIndex = 75;
            this.tb_mahopdong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_thang
            // 
            this.lb_thang.AutoSize = true;
            this.lb_thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thang.ForeColor = System.Drawing.Color.Gray;
            this.lb_thang.Location = new System.Drawing.Point(164, 114);
            this.lb_thang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_thang.Name = "lb_thang";
            this.lb_thang.Size = new System.Drawing.Size(91, 17);
            this.lb_thang.TabIndex = 74;
            this.lb_thang.Text = "Mã hợp đồng";
            // 
            // ptb_back
            // 
            this.ptb_back.Image = global::QuanLyNhanVien.Properties.Resources.undo1;
            this.ptb_back.Location = new System.Drawing.Point(45, 28);
            this.ptb_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptb_back.Name = "ptb_back";
            this.ptb_back.Size = new System.Drawing.Size(38, 41);
            this.ptb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_back.TabIndex = 84;
            this.ptb_back.TabStop = false;
            this.ptb_back.Click += new System.EventHandler(this.ptb_back_Click);
            // 
            // tb_manv
            // 
            this.tb_manv.Enabled = false;
            this.tb_manv.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.tb_manv.Location = new System.Drawing.Point(472, 136);
            this.tb_manv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(243, 33);
            this.tb_manv.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tb_manv.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tb_manv.StateCommon.Border.Rounding = 15;
            this.tb_manv.StateCommon.Border.Width = 1;
            this.tb_manv.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_manv.TabIndex = 85;
            this.tb_manv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_loaihopdong
            // 
            this.tb_loaihopdong.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.tb_loaihopdong.Location = new System.Drawing.Point(472, 374);
            this.tb_loaihopdong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_loaihopdong.Name = "tb_loaihopdong";
            this.tb_loaihopdong.Size = new System.Drawing.Size(243, 33);
            this.tb_loaihopdong.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tb_loaihopdong.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tb_loaihopdong.StateCommon.Border.Rounding = 15;
            this.tb_loaihopdong.StateCommon.Border.Width = 1;
            this.tb_loaihopdong.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_loaihopdong.TabIndex = 87;
            this.tb_loaihopdong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(469, 351);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 86;
            this.label1.Text = "Loại hợp đồng";
            // 
            // ptb_cancel
            // 
            this.ptb_cancel.Image = global::QuanLyNhanVien.Properties.Resources.x_button;
            this.ptb_cancel.Location = new System.Drawing.Point(809, 28);
            this.ptb_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptb_cancel.Name = "ptb_cancel";
            this.ptb_cancel.Size = new System.Drawing.Size(38, 41);
            this.ptb_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_cancel.TabIndex = 88;
            this.ptb_cancel.TabStop = false;
            this.ptb_cancel.Click += new System.EventHandler(this.ptb_cancel_Click);
            // 
            // ptb_checked
            // 
            this.ptb_checked.Image = global::QuanLyNhanVien.Properties.Resources._checked;
            this.ptb_checked.Location = new System.Drawing.Point(691, 28);
            this.ptb_checked.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptb_checked.Name = "ptb_checked";
            this.ptb_checked.Size = new System.Drawing.Size(38, 41);
            this.ptb_checked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_checked.TabIndex = 89;
            this.ptb_checked.TabStop = false;
            this.ptb_checked.Click += new System.EventHandler(this.ptb_checked_Click);
            // 
            // Panel_ListOfContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(889, 665);
            this.Controls.Add(this.ptb_checked);
            this.Controls.Add(this.ptb_cancel);
            this.Controls.Add(this.tb_loaihopdong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_manv);
            this.Controls.Add(this.ptb_back);
            this.Controls.Add(this.dtp_ngayketthuc);
            this.Controls.Add(this.dtp_ngaybatdau);
            this.Controls.Add(this.tb_trangthai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_mahopdong);
            this.Controls.Add(this.lb_thang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ptb_edit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Panel_ListOfContact";
            this.Text = "Panel_ListOfContact";
            this.Load += new System.EventHandler(this.Panel_ListOfContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_checked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptb_edit;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtp_ngayketthuc;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtp_ngaybatdau;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_trangthai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_mahopdong;
        private System.Windows.Forms.Label lb_thang;
        private System.Windows.Forms.PictureBox ptb_back;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_manv;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_loaihopdong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptb_cancel;
        private System.Windows.Forms.PictureBox ptb_checked;
    }
}
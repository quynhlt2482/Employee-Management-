namespace QuanLyNhanVien.Panel_MainScreen
{
    partial class Panel_ListOfTimeKeepingDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_thang = new System.Windows.Forms.Label();
            this.cb_thang = new System.Windows.Forms.ComboBox();
            this.tb_nam = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ptb_delete = new System.Windows.Forms.PictureBox();
            this.ptb_add = new System.Windows.Forms.PictureBox();
            this.dtg_nhanvien = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ptb_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_back)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(533, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên nhân viên";
            // 
            // lb_thang
            // 
            this.lb_thang.AutoSize = true;
            this.lb_thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thang.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_thang.Location = new System.Drawing.Point(191, 52);
            this.lb_thang.Name = "lb_thang";
            this.lb_thang.Size = new System.Drawing.Size(130, 25);
            this.lb_thang.TabIndex = 34;
            this.lb_thang.Text = "Mã nhân viên";
            // 
            // cb_thang
            // 
            this.cb_thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_thang.FormattingEnabled = true;
            this.cb_thang.Location = new System.Drawing.Point(340, 49);
            this.cb_thang.Name = "cb_thang";
            this.cb_thang.Size = new System.Drawing.Size(135, 28);
            this.cb_thang.TabIndex = 33;
            // 
            // tb_nam
            // 
            this.tb_nam.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.tb_nam.Location = new System.Drawing.Point(687, 49);
            this.tb_nam.Name = "tb_nam";
            this.tb_nam.Size = new System.Drawing.Size(186, 27);
            this.tb_nam.TabIndex = 32;
            // 
            // ptb_delete
            // 
            this.ptb_delete.Image = global::QuanLyNhanVien.Properties.Resources.delete__1_2;
            this.ptb_delete.Location = new System.Drawing.Point(1064, 37);
            this.ptb_delete.Name = "ptb_delete";
            this.ptb_delete.Size = new System.Drawing.Size(50, 50);
            this.ptb_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_delete.TabIndex = 30;
            this.ptb_delete.TabStop = false;
            // 
            // ptb_add
            // 
            this.ptb_add.Image = global::QuanLyNhanVien.Properties.Resources.add1;
            this.ptb_add.Location = new System.Drawing.Point(943, 37);
            this.ptb_add.Name = "ptb_add";
            this.ptb_add.Size = new System.Drawing.Size(50, 50);
            this.ptb_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_add.TabIndex = 29;
            this.ptb_add.TabStop = false;
            // 
            // dtg_nhanvien
            // 
            this.dtg_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_nhanvien.Location = new System.Drawing.Point(41, 125);
            this.dtg_nhanvien.Name = "dtg_nhanvien";
            this.dtg_nhanvien.RowHeadersWidth = 51;
            this.dtg_nhanvien.RowTemplate.Height = 24;
            this.dtg_nhanvien.Size = new System.Drawing.Size(1103, 598);
            this.dtg_nhanvien.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dtg_nhanvien.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dtg_nhanvien.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dtg_nhanvien.TabIndex = 28;
            // 
            // ptb_back
            // 
            this.ptb_back.Image = global::QuanLyNhanVien.Properties.Resources.undo1;
            this.ptb_back.Location = new System.Drawing.Point(41, 37);
            this.ptb_back.Name = "ptb_back";
            this.ptb_back.Size = new System.Drawing.Size(50, 50);
            this.ptb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_back.TabIndex = 36;
            this.ptb_back.TabStop = false;
            this.ptb_back.Click += new System.EventHandler(this.ptb_back_Click);
            // 
            // Panel_ListOfTimeKeepingDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1185, 819);
            this.Controls.Add(this.ptb_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_thang);
            this.Controls.Add(this.cb_thang);
            this.Controls.Add(this.tb_nam);
            this.Controls.Add(this.ptb_delete);
            this.Controls.Add(this.ptb_add);
            this.Controls.Add(this.dtg_nhanvien);
            this.Name = "Panel_ListOfTimeKeepingDetail";
            this.Text = "Panel_ListOfTimeKeepingDetail";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_thang;
        private System.Windows.Forms.ComboBox cb_thang;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_nam;
        private System.Windows.Forms.PictureBox ptb_delete;
        private System.Windows.Forms.PictureBox ptb_add;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dtg_nhanvien;
        private System.Windows.Forms.PictureBox ptb_back;
    }
}
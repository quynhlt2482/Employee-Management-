namespace QuanLyNhanVien.Panel_MainScreen
{
    partial class Panel_ListOfSalary
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
            this.dtg_bangchamcong = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ptb_detail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_bangchamcong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(393, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Năm";
            // 
            // lb_thang
            // 
            this.lb_thang.AutoSize = true;
            this.lb_thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thang.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_thang.Location = new System.Drawing.Point(85, 52);
            this.lb_thang.Name = "lb_thang";
            this.lb_thang.Size = new System.Drawing.Size(69, 25);
            this.lb_thang.TabIndex = 33;
            this.lb_thang.Text = "Tháng";
            // 
            // cb_thang
            // 
            this.cb_thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_thang.FormattingEnabled = true;
            this.cb_thang.Location = new System.Drawing.Point(196, 49);
            this.cb_thang.Name = "cb_thang";
            this.cb_thang.Size = new System.Drawing.Size(135, 28);
            this.cb_thang.TabIndex = 32;
            this.cb_thang.SelectedIndexChanged += new System.EventHandler(this.cb_thang_SelectedIndexChanged);
            // 
            // tb_nam
            // 
            this.tb_nam.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.tb_nam.Location = new System.Drawing.Point(484, 49);
            this.tb_nam.Name = "tb_nam";
            this.tb_nam.Size = new System.Drawing.Size(144, 27);
            this.tb_nam.TabIndex = 31;
            this.tb_nam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_nam_KeyDown);
            // 
            // dtg_bangchamcong
            // 
            this.dtg_bangchamcong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_bangchamcong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_bangchamcong.Location = new System.Drawing.Point(41, 125);
            this.dtg_bangchamcong.Name = "dtg_bangchamcong";
            this.dtg_bangchamcong.RowHeadersWidth = 51;
            this.dtg_bangchamcong.RowTemplate.Height = 24;
            this.dtg_bangchamcong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_bangchamcong.Size = new System.Drawing.Size(1103, 598);
            this.dtg_bangchamcong.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dtg_bangchamcong.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dtg_bangchamcong.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dtg_bangchamcong.TabIndex = 28;
            this.dtg_bangchamcong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_bangchamcong_CellClick);
            // 
            // ptb_detail
            // 
            this.ptb_detail.Image = global::QuanLyNhanVien.Properties.Resources.seo;
            this.ptb_detail.Location = new System.Drawing.Point(1017, 40);
            this.ptb_detail.Name = "ptb_detail";
            this.ptb_detail.Size = new System.Drawing.Size(50, 50);
            this.ptb_detail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_detail.TabIndex = 30;
            this.ptb_detail.TabStop = false;
            this.ptb_detail.Click += new System.EventHandler(this.ptb_detail_Click);
            // 
            // Panel_ListOfSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1185, 819);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_thang);
            this.Controls.Add(this.cb_thang);
            this.Controls.Add(this.tb_nam);
            this.Controls.Add(this.ptb_detail);
            this.Controls.Add(this.dtg_bangchamcong);
            this.Name = "Panel_ListOfSalary";
            this.Text = "Panel_ListOfSalary";
            this.Load += new System.EventHandler(this.Panel_ListOfSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_bangchamcong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_thang;
        private System.Windows.Forms.ComboBox cb_thang;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_nam;
        private System.Windows.Forms.PictureBox ptb_detail;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dtg_bangchamcong;
    }
}
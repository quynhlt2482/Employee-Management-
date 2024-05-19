namespace QuanLyNhanVien
{
    partial class Panel_AllTimeKeeping
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
            this.dtg_bangchamcong = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.tb_nam = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cb_thang = new System.Windows.Forms.ComboBox();
            this.lb_thang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptb_detail = new System.Windows.Forms.PictureBox();
            this.ptb_add = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_bangchamcong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_add)).BeginInit();
            this.SuspendLayout();
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
            this.dtg_bangchamcong.TabIndex = 20;
            this.dtg_bangchamcong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_bangchamcong_CellClick);
            // 
            // tb_nam
            // 
            this.tb_nam.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.tb_nam.Location = new System.Drawing.Point(484, 49);
            this.tb_nam.Name = "tb_nam";
            this.tb_nam.Size = new System.Drawing.Size(144, 27);
            this.tb_nam.TabIndex = 24;
            this.tb_nam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_nam_KeyDown);
            // 
            // cb_thang
            // 
            this.cb_thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_thang.FormattingEnabled = true;
            this.cb_thang.Location = new System.Drawing.Point(196, 49);
            this.cb_thang.Name = "cb_thang";
            this.cb_thang.Size = new System.Drawing.Size(135, 28);
            this.cb_thang.TabIndex = 25;
            this.cb_thang.SelectedIndexChanged += new System.EventHandler(this.cb_thang_SelectedIndexChanged);
            // 
            // lb_thang
            // 
            this.lb_thang.AutoSize = true;
            this.lb_thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thang.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_thang.Location = new System.Drawing.Point(85, 52);
            this.lb_thang.Name = "lb_thang";
            this.lb_thang.Size = new System.Drawing.Size(69, 25);
            this.lb_thang.TabIndex = 26;
            this.lb_thang.Text = "Tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(393, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Năm";
            // 
            // ptb_detail
            // 
            this.ptb_detail.Image = global::QuanLyNhanVien.Properties.Resources.seo;
            this.ptb_detail.Location = new System.Drawing.Point(899, 26);
            this.ptb_detail.Name = "ptb_detail";
            this.ptb_detail.Size = new System.Drawing.Size(50, 50);
            this.ptb_detail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_detail.TabIndex = 23;
            this.ptb_detail.TabStop = false;
            this.ptb_detail.Click += new System.EventHandler(this.ptb_detail_Click);
            // 
            // ptb_add
            // 
            this.ptb_add.Image = global::QuanLyNhanVien.Properties.Resources.add1;
            this.ptb_add.Location = new System.Drawing.Point(1052, 27);
            this.ptb_add.Name = "ptb_add";
            this.ptb_add.Size = new System.Drawing.Size(50, 50);
            this.ptb_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_add.TabIndex = 21;
            this.ptb_add.TabStop = false;
            this.ptb_add.Click += new System.EventHandler(this.ptb_add_Click);
            // 
            // Panel_AllTimeKeeping
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
            this.Controls.Add(this.ptb_add);
            this.Controls.Add(this.dtg_bangchamcong);
            this.Name = "Panel_AllTimeKeeping";
            this.Text = "Panel_AllTimeKeeping";
            this.Load += new System.EventHandler(this.Panel_AllTimeKeeping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_bangchamcong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_detail;
        private System.Windows.Forms.PictureBox ptb_add;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dtg_bangchamcong;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_nam;
        private System.Windows.Forms.ComboBox cb_thang;
        private System.Windows.Forms.Label lb_thang;
        private System.Windows.Forms.Label label1;
    }
}
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
            this.ptb_detail = new System.Windows.Forms.PictureBox();
            this.ptb_cancel = new System.Windows.Forms.PictureBox();
            this.ptb_check = new System.Windows.Forms.PictureBox();
            this.dtg_nhanvien = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_detail
            // 
            this.ptb_detail.Image = global::QuanLyNhanVien.Properties.Resources.seo;
            this.ptb_detail.Location = new System.Drawing.Point(78, 25);
            this.ptb_detail.Name = "ptb_detail";
            this.ptb_detail.Size = new System.Drawing.Size(50, 50);
            this.ptb_detail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_detail.TabIndex = 23;
            this.ptb_detail.TabStop = false;
            // 
            // ptb_cancel
            // 
            this.ptb_cancel.Image = global::QuanLyNhanVien.Properties.Resources.x_button;
            this.ptb_cancel.Location = new System.Drawing.Point(1045, 26);
            this.ptb_cancel.Name = "ptb_cancel";
            this.ptb_cancel.Size = new System.Drawing.Size(50, 50);
            this.ptb_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_cancel.TabIndex = 22;
            this.ptb_cancel.TabStop = false;
            // 
            // ptb_check
            // 
            this.ptb_check.Image = global::QuanLyNhanVien.Properties.Resources._checked;
            this.ptb_check.Location = new System.Drawing.Point(928, 25);
            this.ptb_check.Name = "ptb_check";
            this.ptb_check.Size = new System.Drawing.Size(50, 50);
            this.ptb_check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_check.TabIndex = 21;
            this.ptb_check.TabStop = false;
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
            this.dtg_nhanvien.TabIndex = 20;
            // 
            // Panel_AllTimeKeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1185, 819);
            this.Controls.Add(this.ptb_detail);
            this.Controls.Add(this.ptb_cancel);
            this.Controls.Add(this.ptb_check);
            this.Controls.Add(this.dtg_nhanvien);
            this.Name = "Panel_AllTimeKeeping";
            this.Text = "Panel_AllTimeKeeping";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_detail;
        private System.Windows.Forms.PictureBox ptb_cancel;
        private System.Windows.Forms.PictureBox ptb_check;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dtg_nhanvien;
    }
}
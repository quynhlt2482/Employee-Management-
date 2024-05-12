namespace QuanLyNhanVien
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
            this.dtg_nhanvien = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ptb_add = new System.Windows.Forms.PictureBox();
            this.ptb_delete = new System.Windows.Forms.PictureBox();
            this.ptb_edit = new System.Windows.Forms.PictureBox();
            this.ptb_detail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_nhanvien
            // 
            this.dtg_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_nhanvien.Location = new System.Drawing.Point(43, 119);
            this.dtg_nhanvien.Name = "dtg_nhanvien";
            this.dtg_nhanvien.RowHeadersWidth = 51;
            this.dtg_nhanvien.RowTemplate.Height = 24;
            this.dtg_nhanvien.Size = new System.Drawing.Size(1103, 598);
            this.dtg_nhanvien.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dtg_nhanvien.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dtg_nhanvien.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dtg_nhanvien.TabIndex = 0;
            // 
            // ptb_add
            // 
            this.ptb_add.Image = global::QuanLyNhanVien.Properties.Resources.add_user__1_;
            this.ptb_add.Location = new System.Drawing.Point(675, 19);
            this.ptb_add.Name = "ptb_add";
            this.ptb_add.Size = new System.Drawing.Size(50, 50);
            this.ptb_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_add.TabIndex = 4;
            this.ptb_add.TabStop = false;
            // 
            // ptb_delete
            // 
            this.ptb_delete.Image = global::QuanLyNhanVien.Properties.Resources.delete__1_;
            this.ptb_delete.Location = new System.Drawing.Point(1047, 20);
            this.ptb_delete.Name = "ptb_delete";
            this.ptb_delete.Size = new System.Drawing.Size(50, 50);
            this.ptb_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_delete.TabIndex = 3;
            this.ptb_delete.TabStop = false;
            // 
            // ptb_edit
            // 
            this.ptb_edit.Image = global::QuanLyNhanVien.Properties.Resources.edit_2;
            this.ptb_edit.Location = new System.Drawing.Point(930, 19);
            this.ptb_edit.Name = "ptb_edit";
            this.ptb_edit.Size = new System.Drawing.Size(50, 50);
            this.ptb_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_edit.TabIndex = 2;
            this.ptb_edit.TabStop = false;
            // 
            // ptb_detail
            // 
            this.ptb_detail.Image = global::QuanLyNhanVien.Properties.Resources.detail;
            this.ptb_detail.Location = new System.Drawing.Point(804, 20);
            this.ptb_detail.Name = "ptb_detail";
            this.ptb_detail.Size = new System.Drawing.Size(50, 50);
            this.ptb_detail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_detail.TabIndex = 1;
            this.ptb_detail.TabStop = false;
            // 
            // Panel_ListOfEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1185, 819);
            this.Controls.Add(this.ptb_add);
            this.Controls.Add(this.ptb_delete);
            this.Controls.Add(this.ptb_edit);
            this.Controls.Add(this.ptb_detail);
            this.Controls.Add(this.dtg_nhanvien);
            this.Name = "Panel_ListOfEmployee";
            this.Text = "Panel_ListOfEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_detail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dtg_nhanvien;
        private System.Windows.Forms.PictureBox ptb_detail;
        private System.Windows.Forms.PictureBox ptb_edit;
        private System.Windows.Forms.PictureBox ptb_delete;
        private System.Windows.Forms.PictureBox ptb_add;
    }
}
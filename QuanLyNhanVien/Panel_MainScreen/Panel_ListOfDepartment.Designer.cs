namespace QuanLyNhanVien
{
    partial class Panel_ListOfDepartment
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
            this.dtg_phongban = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ptb_delete = new System.Windows.Forms.PictureBox();
            this.ptb_edit = new System.Windows.Forms.PictureBox();
            this.ptb_add = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_phongban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_add)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_phongban
            // 
            this.dtg_phongban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_phongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_phongban.Location = new System.Drawing.Point(32, 97);
            this.dtg_phongban.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtg_phongban.Name = "dtg_phongban";
            this.dtg_phongban.ReadOnly = true;
            this.dtg_phongban.RowHeadersWidth = 51;
            this.dtg_phongban.RowTemplate.Height = 24;
            this.dtg_phongban.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_phongban.Size = new System.Drawing.Size(827, 486);
            this.dtg_phongban.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dtg_phongban.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dtg_phongban.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dtg_phongban.TabIndex = 5;
            // 
            // ptb_delete
            // 
            this.ptb_delete.Image = global::QuanLyNhanVien.Properties.Resources.delete__1_;
            this.ptb_delete.Location = new System.Drawing.Point(785, 16);
            this.ptb_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptb_delete.Name = "ptb_delete";
            this.ptb_delete.Size = new System.Drawing.Size(38, 41);
            this.ptb_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_delete.TabIndex = 8;
            this.ptb_delete.TabStop = false;
            // 
            // ptb_edit
            // 
            this.ptb_edit.Image = global::QuanLyNhanVien.Properties.Resources.edit_2;
            this.ptb_edit.Location = new System.Drawing.Point(698, 15);
            this.ptb_edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptb_edit.Name = "ptb_edit";
            this.ptb_edit.Size = new System.Drawing.Size(38, 41);
            this.ptb_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_edit.TabIndex = 7;
            this.ptb_edit.TabStop = false;
            this.ptb_edit.Click += new System.EventHandler(this.ptb_edit_Click);
            // 
            // ptb_add
            // 
            this.ptb_add.Image = global::QuanLyNhanVien.Properties.Resources.add;
            this.ptb_add.Location = new System.Drawing.Point(599, 16);
            this.ptb_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptb_add.Name = "ptb_add";
            this.ptb_add.Size = new System.Drawing.Size(38, 41);
            this.ptb_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_add.TabIndex = 15;
            this.ptb_add.TabStop = false;
            this.ptb_add.Click += new System.EventHandler(this.ptb_add_Click);
            // 
            // Panel_ListOfDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(889, 665);
            this.Controls.Add(this.ptb_add);
            this.Controls.Add(this.ptb_delete);
            this.Controls.Add(this.ptb_edit);
            this.Controls.Add(this.dtg_phongban);
            this.ForeColor = System.Drawing.Color.Chartreuse;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Panel_ListOfDepartment";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_phongban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_add)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ptb_delete;
        private System.Windows.Forms.PictureBox ptb_edit;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dtg_phongban;
        private System.Windows.Forms.PictureBox ptb_add;
    }
}
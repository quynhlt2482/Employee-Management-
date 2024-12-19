namespace QuanLyNhanVien
{
    partial class Panel_ListOfTimeWork
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
            this.dtg_ca = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ptb_add = new System.Windows.Forms.PictureBox();
            this.ptb_delete = new System.Windows.Forms.PictureBox();
            this.ptb_edit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_ca
            // 
            this.dtg_ca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_ca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ca.Location = new System.Drawing.Point(43, 119);
            this.dtg_ca.Name = "dtg_ca";
            this.dtg_ca.RowHeadersWidth = 51;
            this.dtg_ca.RowTemplate.Height = 24;
            this.dtg_ca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_ca.Size = new System.Drawing.Size(1103, 598);
            this.dtg_ca.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dtg_ca.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dtg_ca.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dtg_ca.TabIndex = 10;
            this.dtg_ca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ca_CellClick);
            // 
            // ptb_add
            // 
            this.ptb_add.Image = global::QuanLyNhanVien.Properties.Resources.add;
            this.ptb_add.Location = new System.Drawing.Point(799, 20);
            this.ptb_add.Name = "ptb_add";
            this.ptb_add.Size = new System.Drawing.Size(50, 50);
            this.ptb_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_add.TabIndex = 14;
            this.ptb_add.TabStop = false;
            this.ptb_add.Click += new System.EventHandler(this.ptb_add_Click);
            // 
            // ptb_delete
            // 
            this.ptb_delete.Image = global::QuanLyNhanVien.Properties.Resources.delete__1_;
            this.ptb_delete.Location = new System.Drawing.Point(1047, 20);
            this.ptb_delete.Name = "ptb_delete";
            this.ptb_delete.Size = new System.Drawing.Size(50, 50);
            this.ptb_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_delete.TabIndex = 13;
            this.ptb_delete.TabStop = false;
            this.ptb_delete.Click += new System.EventHandler(this.ptb_delete_Click);
            // 
            // ptb_edit
            // 
            this.ptb_edit.Image = global::QuanLyNhanVien.Properties.Resources.edit_2;
            this.ptb_edit.Location = new System.Drawing.Point(930, 19);
            this.ptb_edit.Name = "ptb_edit";
            this.ptb_edit.Size = new System.Drawing.Size(50, 50);
            this.ptb_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_edit.TabIndex = 12;
            this.ptb_edit.TabStop = false;
            this.ptb_edit.Click += new System.EventHandler(this.ptb_edit_Click);
            // 
            // Panel_ListOfTimeWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1185, 819);
            this.Controls.Add(this.ptb_add);
            this.Controls.Add(this.ptb_delete);
            this.Controls.Add(this.ptb_edit);
            this.Controls.Add(this.dtg_ca);
            this.Name = "Panel_ListOfTimeWork";
            this.Text = "Panel_ListOfTimeWork";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_edit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_add;
        private System.Windows.Forms.PictureBox ptb_delete;
        private System.Windows.Forms.PictureBox ptb_edit;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dtg_ca;
    }
}
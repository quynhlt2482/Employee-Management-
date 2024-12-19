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
            ((System.ComponentModel.ISupportInitialize)(this.dtg_phongban)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_phongban
            // 
            this.dtg_phongban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_phongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_phongban.Location = new System.Drawing.Point(32, 97);
            this.dtg_phongban.Margin = new System.Windows.Forms.Padding(2);
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
            // Panel_ListOfDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(889, 665);
            this.Controls.Add(this.dtg_phongban);
            this.ForeColor = System.Drawing.Color.Chartreuse;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Panel_ListOfDepartment";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_phongban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dtg_phongban;
    }
}
namespace QuanLyNhanVien
{
    partial class Panel_ConfirmEdit
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
            this.dtg_log = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_log)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_log
            // 
            this.dtg_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_log.Location = new System.Drawing.Point(32, 97);
            this.dtg_log.Margin = new System.Windows.Forms.Padding(2);
            this.dtg_log.Name = "dtg_log";
            this.dtg_log.ReadOnly = true;
            this.dtg_log.RowHeadersWidth = 51;
            this.dtg_log.RowTemplate.Height = 24;
            this.dtg_log.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_log.Size = new System.Drawing.Size(827, 486);
            this.dtg_log.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dtg_log.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dtg_log.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dtg_log.TabIndex = 16;
            // 
            // Panel_ConfirmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(889, 665);
            this.Controls.Add(this.dtg_log);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Panel_ConfirmEdit";
            this.Text = "Panel_EditHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_log)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dtg_log;
    }
}
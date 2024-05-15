namespace QuanLyNhanVien.Modal
{
    partial class Modal_ChangeManager
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
            this.CB_ListEmployee = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_accept = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_currentManager = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.CB_ListEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_ListEmployee
            // 
            this.CB_ListEmployee.DropDownWidth = 142;
            this.CB_ListEmployee.Location = new System.Drawing.Point(214, 106);
            this.CB_ListEmployee.Name = "CB_ListEmployee";
            this.CB_ListEmployee.Size = new System.Drawing.Size(142, 21);
            this.CB_ListEmployee.TabIndex = 0;
            this.CB_ListEmployee.Text = "kryptonComboBox1";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(109, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Đổi trưởng phòng";
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(168, 155);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(90, 25);
            this.btn_accept.TabIndex = 2;
            this.btn_accept.Values.Text = "Xác nhận";
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(75, 56);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(133, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Trưởng phòng hiện tại";
            // 
            // txt_currentManager
            // 
            this.txt_currentManager.Location = new System.Drawing.Point(214, 53);
            this.txt_currentManager.Name = "txt_currentManager";
            this.txt_currentManager.ReadOnly = true;
            this.txt_currentManager.Size = new System.Drawing.Size(142, 23);
            this.txt_currentManager.TabIndex = 3;
            this.txt_currentManager.Text = "kryptonTextBox1";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(75, 107);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(114, 20);
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "Trưởng phòng mới";
            // 
            // Modal_ChangeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(451, 204);
            this.Controls.Add(this.txt_currentManager);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.CB_ListEmployee);
            this.Name = "Modal_ChangeManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modal_ChangeManager";
            ((System.ComponentModel.ISupportInitialize)(this.CB_ListEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonComboBox CB_ListEmployee;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_accept;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_currentManager;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
    }
}
namespace ProcurementTrackingBalilihan
{
    partial class ChangeConnectionForm
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
            this.Savebtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.servertxt = new DevExpress.XtraEditors.TextEdit();
            this.databasetxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.usertxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.passwordtxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Testbtn = new DevExpress.XtraEditors.SimpleButton();
            this.Exitbtn = new DevExpress.XtraEditors.SimpleButton();
            this.porttxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.servertxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasetxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordtxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porttxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(207, 275);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 0;
            this.Savebtn.Text = "Save";
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Server: ";
            // 
            // servertxt
            // 
            this.servertxt.Location = new System.Drawing.Point(72, 33);
            this.servertxt.Name = "servertxt";
            this.servertxt.Size = new System.Drawing.Size(198, 20);
            this.servertxt.TabIndex = 2;
            // 
            // databasetxt
            // 
            this.databasetxt.Location = new System.Drawing.Point(72, 75);
            this.databasetxt.Name = "databasetxt";
            this.databasetxt.Size = new System.Drawing.Size(198, 20);
            this.databasetxt.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Database:";
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(72, 118);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(198, 20);
            this.usertxt.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 121);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "User:";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(72, 162);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(198, 20);
            this.passwordtxt.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 165);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Password:";
            // 
            // Testbtn
            // 
            this.Testbtn.Location = new System.Drawing.Point(72, 237);
            this.Testbtn.Name = "Testbtn";
            this.Testbtn.Size = new System.Drawing.Size(146, 23);
            this.Testbtn.TabIndex = 9;
            this.Testbtn.Text = "Test Connection";
            this.Testbtn.Click += new System.EventHandler(this.Testbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(126, 275);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 10;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // porttxt
            // 
            this.porttxt.Location = new System.Drawing.Point(72, 200);
            this.porttxt.Name = "porttxt";
            this.porttxt.Size = new System.Drawing.Size(198, 20);
            this.porttxt.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 203);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Port:";
            // 
            // ChangeConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 309);
            this.Controls.Add(this.porttxt);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Testbtn);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.databasetxt);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.servertxt);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Savebtn);
            this.MinimizeBox = false;
            this.Name = "ChangeConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeConnectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.servertxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasetxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordtxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porttxt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Savebtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit servertxt;
        private DevExpress.XtraEditors.TextEdit databasetxt;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit usertxt;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit passwordtxt;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton Testbtn;
        private DevExpress.XtraEditors.SimpleButton Exitbtn;
        private DevExpress.XtraEditors.TextEdit porttxt;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}
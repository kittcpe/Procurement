namespace ProcurementTrackingBalilihan
{
    partial class LoginFormRedesigned
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFormRedesigned));
            this.bglogin = new System.ComponentModel.BackgroundWorker();
            this.lblconnectionstatus = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::SAMPLE_MEMO_NOTIF.WaitForm1), true, true);
            this.ChangeConnectionbtn = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bglogin
            // 
            this.bglogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bglogin_DoWork);
            this.bglogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bglogin_RunWorkerCompleted);
            // 
            // lblconnectionstatus
            // 
            this.lblconnectionstatus.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblconnectionstatus.Location = new System.Drawing.Point(426, 631);
            this.lblconnectionstatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblconnectionstatus.Name = "lblconnectionstatus";
            this.lblconnectionstatus.Size = new System.Drawing.Size(136, 19);
            this.lblconnectionstatus.TabIndex = 13;
            this.lblconnectionstatus.Text = "Connection is good";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(158, 444);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(296, 38);
            this.txtPassword.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(81, 408);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(157, 28);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Password: *";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(81, 294);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(166, 28);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Username: *";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(158, 330);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Size = new System.Drawing.Size(296, 38);
            this.txtUserName.TabIndex = 7;
            // 
            // ChangeConnectionbtn
            // 
            this.ChangeConnectionbtn.Image = ((System.Drawing.Image)(resources.GetObject("ChangeConnectionbtn.Image")));
            this.ChangeConnectionbtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ChangeConnectionbtn.Location = new System.Drawing.Point(18, 608);
            this.ChangeConnectionbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChangeConnectionbtn.Name = "ChangeConnectionbtn";
            this.ChangeConnectionbtn.Size = new System.Drawing.Size(225, 48);
            this.ChangeConnectionbtn.TabIndex = 14;
            this.ChangeConnectionbtn.Text = "Change Connection";
            this.ChangeConnectionbtn.Click += new System.EventHandler(this.ChangeConnectionbtn_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(68, 34);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(450, 175);
            this.pictureEdit1.TabIndex = 12;
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnLogin.Location = new System.Drawing.Point(196, 509);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(220, 79);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginFormRedesigned
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 674);
            this.Controls.Add(this.ChangeConnectionbtn);
            this.Controls.Add(this.lblconnectionstatus);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(406, 517);
            this.MinimumSize = new System.Drawing.Size(406, 517);
            this.Name = "LoginFormRedesigned";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginFormRedesigned";
            this.Load += new System.EventHandler(this.LoginFormRedesigned_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bglogin;
        private DevExpress.XtraEditors.LabelControl lblconnectionstatus;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.SimpleButton ChangeConnectionbtn;

    }
}
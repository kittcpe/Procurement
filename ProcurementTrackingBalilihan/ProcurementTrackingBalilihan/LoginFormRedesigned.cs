using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using ProcurementTrackingBalilihan.Dal;

namespace ProcurementTrackingBalilihan
{
    public partial class LoginFormRedesigned : DevExpress.XtraEditors.XtraForm
    {
        DataTable UserData = new DataTable();
        public static bool UserLogout = false;
        public LoginFormRedesigned()
        {
           
            
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == string.Empty)
            {
                MessageBox.Show("Please Input Username!", "Login");
                txtUserName.Focus();
            }
            else
            {
                if (txtPassword.Text == string.Empty)
                {
                    MessageBox.Show("Please Input Password!", "Login");
                    txtPassword.Focus();
                }
                else
                {

                    //here
                    if (!bglogin.IsBusy) {
                        bglogin.RunWorkerAsync();
                    }


                }
            }
        }

        private void bglogin_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                UserData = Login.GetLogin(txtUserName.Text, txtPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bglogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            btnLogin.Enabled = true;
            if (Login.GetUserDataSuccessful)
            {
                if (UserData != null)
                {
                    loginsuccess();
                }
                else
                    MessageBox.Show(Login.errormessage + "\nWrong Username or Password!!");
            }
        }
        private void loginsuccess()
        {
            this.Hide();
            HomepageForm hpf = new HomepageForm();
            this.Hide();
            hpf.ShowDialog();

            try
            {
                if (UserLogout)
                {
                    this.Show();
                    txtPassword.Text = string.Empty;
                    txtUserName.Text = string.Empty;
                }
                else
                {
                    Application.Exit();
                }
            }
            catch { }
        }
        bool loadingIsAlreadyShowing = false;
        private void ShowLoading(string message)
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    c.Enabled = false;
                }

                if (!loadingIsAlreadyShowing)
                {
                    loadingIsAlreadyShowing = true;
                    splashScreenManager1.ShowWaitForm();
                }
                splashScreenManager1.SetWaitFormDescription(message);
            }
            catch { }
        }

        private void HideLoading()
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    c.Enabled = true;
                }

                loadingIsAlreadyShowing = false;
                splashScreenManager1.CloseWaitForm();
            }
            catch { }
        }
    }
}
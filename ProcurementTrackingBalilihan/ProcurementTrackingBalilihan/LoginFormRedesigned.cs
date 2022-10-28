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

namespace ProcurementTrackingBalilihan
{
    public partial class LoginFormRedesigned : DevExpress.XtraEditors.XtraForm
    {
        DatabaseConnection dbcon = new DatabaseConnection();
       
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
                    //login code
                    //try
                    //{
                    //    MySqlDataReader UserData = new MySqlDataReader();
                    //    UserData = dbcon.getThatLogin(txtUserName.Text, txtPassword.Text);
                    //    if (UserData != null)
                    //    {
                    HomepageForm hpf = new HomepageForm();
                    this.Hide();
                    hpf.ShowDialog();
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("Invalid username/password!");
                    //    }
                    //}
                    //catch { }


                }
            }
        }
    }
}
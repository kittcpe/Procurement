using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProcurementTracking
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
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
                    HomepageForm hpf = new HomepageForm();
                    this.Hide();
                    hpf.ShowDialog();
                    
                }
            }
            
        }




    }
}

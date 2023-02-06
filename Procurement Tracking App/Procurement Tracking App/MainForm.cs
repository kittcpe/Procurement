using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Procurement_Tracking_App.Dal;
using Procurement_Tracking_App.Core;

namespace Procurement_Tracking_App
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = PublicVariables.ProjectName;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnmainlogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoginForm.UserLogout = true;
            this.Hide();
        }

        private void btnlogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoginForm.UserLogout = true;
            this.Hide();
        }

        public static bool SupplierForm = false;
        private void btnsupplier_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!SupplierForm)
            {
                SupplierForm = true;
                SupplierForm sf = new SupplierForm();
                sf.MdiParent = this;
                sf.WindowState = FormWindowState.Maximized;
                sf.Show();
            }
            else
            {
                Form fc = Application.OpenForms["SupplierForm"];
                if (fc == null)
                {
                    SupplierForm a1 = new SupplierForm();
                    a1.MdiParent = this;
                    a1.Show();
                }
                else
                    fc.Activate();
            }
        }
    }
}
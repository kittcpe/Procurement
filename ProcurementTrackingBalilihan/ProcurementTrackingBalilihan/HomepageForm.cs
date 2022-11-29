using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace ProcurementTrackingBalilihan
{
    
    public partial class HomepageForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public static bool islogout = false;
        public HomepageForm()
        {
            InitializeComponent();
        }

        private void HomepageForm_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        
        }

        public static bool SupplierFormIsOpen = false;
        private void btnSupplier_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!SupplierFormIsOpen)
            {
                SupplierFormIsOpen = true;
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
        public static bool PurchaseFormIsOpen = false;
        private void btnPurchase_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!PurchaseFormIsOpen)
            {
                PurchaseFormIsOpen = true;
                PurchaseForm sf = new PurchaseForm();
                sf.MdiParent = this;
                sf.WindowState = FormWindowState.Maximized;
                sf.Show();
            }
            else
            {
                Form fc = Application.OpenForms["PurchaseForm"];
                if (fc == null)
                {
                    PurchaseForm a1 = new PurchaseForm();
                    a1.MdiParent = this;
                    a1.Show();
                }
                else
                    fc.Activate();
            }

        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoginFormRedesigned.UserLogout = true;
            this.Hide();
        }
        
        public static bool TrackItemFormIsOpen = false;
        private void btnTrackItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!TrackItemFormIsOpen)
            {
                TrackItemFormIsOpen = true;
                TrackItemForm tif = new TrackItemForm();
                tif.MdiParent = this;
                tif.WindowState = FormWindowState.Maximized;
                tif.Show();
            }
            else
            {
                Form fc = Application.OpenForms["TrackItemForm"];
                if (fc == null)
                {
                    PurchaseForm a1 = new PurchaseForm();
                    a1.MdiParent = this;
                    a1.Show();
                }
                else
                    fc.Activate();
            }
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            PrintForm pf = new PrintForm();
            pf.ShowDialog();
            //PrintReport p = new PrintReport();
            //p.ShowPreviewDialog();
        }

        private void HomepageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dia = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes)
            {
                Application.Exit();
            }
            else {
                e.Cancel = true;
            }
        }
    }
}
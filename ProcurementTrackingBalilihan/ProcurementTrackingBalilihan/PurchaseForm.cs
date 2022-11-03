using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ProcurementTrackingBalilihan.Dal;

namespace ProcurementTrackingBalilihan
{
    public partial class PurchaseForm : DevExpress.XtraEditors.XtraForm
    {
    
        public PurchaseForm()
        {
            InitializeComponent();
        }
        #region WaitForm
        bool loadingIsAlreadyShowing = false;
        private void ShowLoading(string message)
        {
            try
            {
                this.Enabled = false;
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
                this.Enabled = true;
                loadingIsAlreadyShowing = false;
                splashScreenManager1.CloseWaitForm();
            }
            catch { }
        }
        #endregion

        private void PurchaseForm_Shown(object sender, EventArgs e)
        {
            // load procurement list
            if (!bwViewSupplierList.IsBusy) {
                ShowLoading("Loading Supplier");
                bwViewSupplierList.RunWorkerAsync();
            
            }

        }
        DataTable procurementdata = new DataTable();
        private void bwViewProcurementList_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void bwViewProcurementList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }



        DataTable SupplierList = new DataTable();
        private void bwViewSupplierList_DoWork(object sender, DoWorkEventArgs e)
        {
            SupplierList = Supplier.GetSupplierList();
            bwViewSupplierList.CancelAsync();

        }

        private void bwViewSupplierList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
                HideLoading();
                DisplayData();
        }
        private void DisplayData()
        {
            if (SupplierList != null && SupplierList.Rows.Count > 0)
            {
                cmbSupplier.Properties.DataSource = SupplierList;
                cmbSupplier.Properties.DisplayMember = "name";
                cmbSupplier.Properties.ValueMember = "id";
            }
            else
                ClearData();
        }
        private void ClearData()
        {
            cmbSupplier.Properties.DataSource = null;
        }


    }
}
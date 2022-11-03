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
            if (!bwViewProcurementList.IsBusy)
            {
                ShowLoading("Loading Procurement List");
                bwViewProcurementList.RunWorkerAsync();
            
            }

        }
        DataTable procurementdata = new DataTable();
        private void bwViewProcurementList_DoWork(object sender, DoWorkEventArgs e)
        {
            procurementdata = Purchase.GetTrackItem();
            bwViewProcurementList.CancelAsync();
        }
        private void bwViewProcurementList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            dtPurchase.DataSource = procurementdata;
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

        private void PurchaseForm_Shown_1(object sender, EventArgs e)
        {
            if (!bwViewProcurementList.IsBusy)
            {
                ShowLoading("Loading data . . .");
                bwViewProcurementList.RunWorkerAsync();
            }
            if (!bwViewSupplierList.IsBusy)
            {
                ShowLoading("Loading data . . .");
                bwViewSupplierList.RunWorkerAsync();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!bwPurchase.IsBusy)
            {
                bwPurchase.RunWorkerAsync();
            }
        }
        int supplierID;
        private void Purchase_Item() {
            supplierID = string.IsNullOrEmpty(cmbSupplier.Text) ? 0 : Convert.ToInt32(cmbSupplier.EditValue);
            if (txtDescription.Text == string.Empty)
            { MessageBox.Show("Please Input Description!"); }
            else
            {
                if (txtAmount.Text == string.Empty)
                { MessageBox.Show("Please Input Amount"); }
                else
                {
                    Purchase.AddSavePurchase(txtDescription.Text, Convert.ToInt32(txtAmount.Text), supplierID, cmbstatus.Text);
                }
            }
        
        }

        private void bwPurchase_DoWork(object sender, DoWorkEventArgs e)
        {
            Purchase_Item();
            bwPurchase.CancelAsync();
        }

        private void bwPurchase_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Purchase.isSaveSuccessfully == true)
            {
                MessageBox.Show("Saved Successfuly");
            }
            else
            {
                MessageBox.Show("Save unsuccessful!" + Purchase.SaveErrorMessage);
            }
            clearfields();
            

        }
        private void clearfields() {
            txtDescription.Text = string.Empty;
            txtAmount.Text = string.Empty;

            if (!bwViewProcurementList.IsBusy)
            {
                ShowLoading("Loading Procurement List");
                bwViewProcurementList.RunWorkerAsync();
            }
        }

        public static string sup_id;
        private void dtPurchase_DoubleClick(object sender, EventArgs e)
        {
           // string id =  .GetRowCellValue(gridView1.FocusedRowHandle, "title") + "";
            sup_id = gvSupplier.GetRowCellValue(gvSupplier.FocusedRowHandle, "id") + "";
            ChangeStatusForm csf = new ChangeStatusForm();
            csf.ShowDialog();
        }

        private void dtPurchase_MouseEnter(object sender, EventArgs e)
        {
            if (ChangeStatusForm.isrefresh)
            {
                clearfields();
                ChangeStatusForm.isrefresh = false;
            }
        }
       
    }
}
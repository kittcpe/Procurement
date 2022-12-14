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
            if (!bwViewSupplierList.IsBusy)
            {
                ShowLoading("Loading Suppliers List");
                bwViewSupplierList.RunWorkerAsync();
            }

            if (!bwViewProcurementList.IsBusy)
            {
                ShowLoading("Loading Procurement List");
                bwViewProcurementList.RunWorkerAsync();
            }

        }

        DataTable supplierdata = new DataTable();
        private void bwViewSupplierList_DoWork(object sender, DoWorkEventArgs e)
        {
            supplierdata = Supplier.GetSupplierList();
            bwViewSupplierList.CancelAsync();
        }
        private void bwViewSupplierList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Supplier.getsupplierlistsuccessful)
            {
                cbesupplier.DataSource = supplierdata;
                cbesupplier.DisplayMember = "name";
                cbesupplier.ValueMember = "id";
            }
            else
            {
                MessageBox.Show(Purchase.gettrackitemerror);
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
            if (Purchase.gettrackitemsuccessfull)
            {
                dtPurchase.DataSource = procurementdata;
            }
            else
            {
                MessageBox.Show(Purchase.gettrackitemerror);
            }
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Procure_Item();
        }
        

        private void Procure_Item() {
            if (string.IsNullOrEmpty(txtProcNo.Text) && string.IsNullOrEmpty(txtEnduser.Text) && string.IsNullOrEmpty(txtDescription.Text) && string.IsNullOrEmpty(txtPRmode.Text)
                && string.IsNullOrEmpty(txtPurpose.Text) && string.IsNullOrEmpty(txtABC.Text))
            { MessageBox.Show("Please complete the procurement Details!"); }
            else
            {
                if (!bwPurchase.IsBusy)
                {bwPurchase.RunWorkerAsync();}
            }

            }

        private void bwPurchase_DoWork(object sender, DoWorkEventArgs e)
        {
            Purchase.AddSavePurchase(txtProcNo.Text, txtDescription.Text, txtEnduser.Text, txtPRmode.Text, float.Parse(txtABC.Text),
                   cmbMode.Text, dtpBids.Text, dtpEval.Text, dtpAward.Text, dtpPO.Text, dtpNTP.Text, dtpDelivery.Text,txtPurpose.Text, btnMode.Text);
            bwPurchase.CancelAsync();
        }

        private void bwPurchase_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Purchase.isSaveSuccessfully)
            {
                MessageBox.Show("Procurement Saved Successfuly \nPress 'OK' to proceed");
                lblProcurementNo.Text = txtProcNo.Text;
                gcProcDetails.Visible = true;
                gcBox(true);
                ControlTextBoxPanel(false);
                
            }
            else
            {
                MessageBox.Show("Save unsuccessful!" + Purchase.SaveErrorMessage);
            }
            clearfields();
        }
        private void clearfields() {
            txtProcNo.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtEnduser.Text = string.Empty;
            txtPRmode.Text = string.Empty;
            txtABC.Text = string.Empty;
            dtpAward.Text = string.Empty;
            dtpBids.Text = string.Empty;
            dtpDelivery.Text = string.Empty;
            dtpEval.Text = string.Empty;
            dtpNTP.Text = string.Empty;
            dtpPO.Text = string.Empty;
            txtPurpose.Text = string.Empty;

            
            if (!bwViewProcurementList.IsBusy)
            {
                ShowLoading("Loading Procurement List");
                bwViewProcurementList.RunWorkerAsync();
            }
        }

        private void dtPurchase_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    var rowH = gvPurchase.FocusedRowHandle;
                    var focusRowView = (DataRowView)gvPurchase.GetFocusedRow();
                    popupMenuGridParent.ShowPopup(barManagerGridProc, new Point(MousePosition.X, MousePosition.Y));
                }
            }
            catch { }
        }

        private void btnAddProc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnMode.Text = "Add";
            clearfields();
        }

        private void btnEditProc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnMode.Text = "Save";
            txtProcNo.Enabled = false;

            //txtPendingReason.Text = pendingdata.Rows[0]["remarks"].ToString();
            txtProcNo.Text = gvPurchase.GetRowCellValue(gvPurchase.FocusedRowHandle, "pr_no").ToString();
            //txtDescription.Text = ItemList.Rows[gvPurchase.FocusedRowHandle]["description"].ToString();
            txtDescription.Text = gvPurchase.GetRowCellValue(gvPurchase.FocusedRowHandle, "description").ToString();

            txtEnduser.Text = gvPurchase.GetRowCellValue(gvPurchase.FocusedRowHandle, "end_user").ToString();
            txtPRmode.Text = gvPurchase.GetRowCellValue(gvPurchase.FocusedRowHandle, "mode_of_pr").ToString();
            txtABC.Text = gvPurchase.GetRowCellValue(gvPurchase.FocusedRowHandle, "abc").ToString();
            txtPurpose.Text = gvPurchase.GetRowCellValue(gvPurchase.FocusedRowHandle, "purpose").ToString();

           //dates
            DateTime dtAward = DateTime.Parse(gvPurchase.GetRowCellValue(gvPurchase.FocusedRowHandle, "award").ToString());
            DateTime dtBids = DateTime.Parse(gvPurchase.GetRowCellValue(gvPurchase.FocusedRowHandle, "opening_of_bids").ToString());
            DateTime dtDelivery = DateTime.Parse(gvPurchase.GetRowCellValue(gvPurchase.FocusedRowHandle, "delivery").ToString());
            DateTime dtEval = DateTime.Parse(gvPurchase.GetRowCellValue(gvPurchase.FocusedRowHandle, "detailed_bid_eval").ToString());
            DateTime dtntp = DateTime.Parse(gvPurchase.GetRowCellValue(gvPurchase.FocusedRowHandle, "ntp").ToString());
            DateTime dtpo = DateTime.Parse(gvPurchase.GetRowCellValue(gvPurchase.FocusedRowHandle, "po").ToString());

            dtpAward.Text = dtAward.ToShortDateString();
            dtpBids.Text = dtBids.ToShortDateString();
            dtpDelivery.Text = dtDelivery.ToShortDateString();
            dtpEval.Text = dtEval.ToShortDateString();
            dtpNTP.Text = dtntp.ToShortDateString();
            dtpPO.Text = dtpo.ToShortDateString();
       


        }
        private void ControlTextBoxPanel(bool operation) {
            txtProcNo.Enabled = operation;
            txtDescription.Enabled = operation;
            txtEnduser.Enabled = operation;
            txtPRmode.Enabled = operation;
            txtABC.Enabled = operation;
            dtpAward.Enabled = operation;
            dtpBids.Enabled = operation;
            dtpDelivery.Enabled = operation;
            dtpEval.Enabled = operation;
            dtpNTP.Enabled = operation;
            dtpPO.Enabled = operation;
            btnAddProc.Enabled = operation;
            cmbMode.Enabled = operation;
            txtPurpose.Enabled = operation;
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            gcProcDetails.Visible = false;
            ControlTextBoxPanel(true);
            txtPropertyNo.Text = string.Empty;
            txtUnit.Text = string.Empty;
            txtItemDescription.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtUnitCost.Text = string.Empty;
            lblProcurementNo.Text = string.Empty;
            dtPurchase.Enabled = true;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (txtPropertyNo.Text == "" || txtUnit.Text == "" || txtQuantity.Text == "" || txtUnitCost.Text == "" || txtItemDescription.Text == "")
                MessageBox.Show("Please Complete Inputs...");
            else
            {
                Purchase.AddSaveItem(txtPropertyNo.Text, txtUnit.Text, txtItemDescription.Text, float.Parse(txtQuantity.Text), float.Parse(txtUnitCost.Text), lblProcurementNo.Text,cbesupplier.GetItemText(cbesupplier.SelectedItem) , "Add");

                if (Purchase.ItemSaveSuccessfuly)
                {
                    MessageBox.Show("Item Added!");
                    txtPropertyNo.Text = null;
                    txtQuantity.Text = null;
                    txtUnit.Text = null;
                    txtUnitCost.Text = null;
                    txtItemDescription.Text = null;
                    getItemDetails();
                }
                else
                {
                    MessageBox.Show(Purchase.ItemSaveErrorMessage);
                }
            }

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            string id = gvItemDetails.GetRowCellValue(gvItemDetails.FocusedRowHandle, "property_no").ToString();
            Purchase.DeleteItem(id);
            if (Purchase.isDeletedSuccessfully)
            {
                MessageBox.Show("Item Deleted");
                getItemDetails();
            }
            else
                MessageBox.Show(Purchase.DeleteErrorMessage);
        }
        DataTable ItemList = new DataTable();
        private void getItemDetails() {
            
            ItemList = Purchase.GetItemDetails(lblProcurementNo.Text);
            if (Purchase.getdetailssuccessfull)
            {
                dtItemDetails.DataSource = ItemList;
            }
            else
            {
                MessageBox.Show(Purchase.getitemerror);
            }
        }

        private void btnDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtPropertyNo.Text = string.Empty;
            txtUnit.Text = string.Empty;
            txtItemDescription.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtUnitCost.Text = string.Empty;
            lblProcurementNo.Text = string.Empty;
            gcBox(false);

            if (gvPurchase.SelectedRowsCount > 0)
            {
                lblProcurementNo.Text = gvPurchase.GetRowCellValue(gvPurchase.FocusedRowHandle, "pr_no").ToString();
                getItemDetails();
                gcProcDetails.Visible = true;
                ControlTextBoxPanel(false);
            }
        }
        private void gcBox(bool ctrl)
        {
            txtPropertyNo.Enabled = ctrl;
            txtUnit.Enabled = ctrl;
            txtItemDescription.Enabled = ctrl;
            txtQuantity.Enabled = ctrl;
            txtUnitCost.Enabled = ctrl;
            lblProcurementNo.Enabled = ctrl;
            btnAddItem.Enabled = ctrl;
            btnDeleteItem.Enabled = ctrl;
            dtPurchase.Enabled = ctrl;
            cbesupplier.Enabled = ctrl;
        }

        private void btnposting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Purchase.UpdateStatus(proc_no, "Posting");
            clearfields();

        }
        string proc_no;
        private void gvSupplier_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvPurchase.SelectedRowsCount > 0)
            {
                proc_no = gvPurchase.GetRowCellValue(gvPurchase.FocusedRowHandle, "pr_no").ToString();
            }
        }

        private void btnprebid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Purchase.UpdateStatus(proc_no, "Pre-Bidding");
            clearfields();
        }

        private void btndelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Purchase.DeleteRecord(gvPurchase.GetRowCellValue(gvPurchase.FocusedRowHandle, "pr_no").ToString());
            if (Purchase.DeleteRecordSuccessful)
            {
                MessageBox.Show("Record Deleted!");
                bwViewProcurementList.RunWorkerAsync();
            }
            else
                MessageBox.Show(Purchase.DeleteRecordErrorMessage);
        }
    }
}
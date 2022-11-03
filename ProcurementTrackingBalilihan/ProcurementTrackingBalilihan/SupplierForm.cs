using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProcurementTrackingBalilihan.Dal;

namespace ProcurementTrackingBalilihan
{
    public partial class SupplierForm : DevExpress.XtraEditors.XtraForm
    {
        DataTable SupplierData = new DataTable();
        public SupplierForm()
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


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtname.Text == string.Empty)
            {
                MessageBox.Show("Please Input Supplier Name");
            }
            else
            {
                if (txtaddress.Text == string.Empty)
                {
                    MessageBox.Show("Please Input Supplier Address");
                }
                else
                {
                    //bw
                    if (!bwSaveSupplier.IsBusy)
                    {
                        bwSaveSupplier.RunWorkerAsync();
                    }
                }
            }

        }

        private void gcSupplier_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    var rowH = gvSupplier.FocusedRowHandle;
                    var focusRowView = (DataRowView)gvSupplier.GetFocusedRow();
                    popupMenuGridParent.ShowPopup(barManagerGridParent, new Point(MousePosition.X, MousePosition.Y));
                }
            }
            catch { }
        }

        private void btnAddSupplier_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcSupplierInfo.Visible = true;
            btnSave.Text = "Add";

        }

        private void btnEditSupplier_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcSupplierInfo.Visible = true;
            txtname.Text = gvSupplier.GetRowCellValue(gvSupplier.FocusedRowHandle, "name").ToString();
            txtaddress.Text = gvSupplier.GetRowCellValue(gvSupplier.FocusedRowHandle, "address").ToString();
            btnSave.Text = "Save";
        }

        private void SupplierForm_Shown(object sender, EventArgs e)
        {
            //load datatable

            if (!bwViewSupplierList.IsBusy)
            {
                ShowLoading("Loading data . . . ");
                bwViewSupplierList.RunWorkerAsync();
            }

        }

        private void bwViewSupplierList_DoWork(object sender, DoWorkEventArgs e)
        {
            SupplierData = Supplier.GetSupplierList();
            bwViewSupplierList.CancelAsync();
        }

        private void bwViewSupplierList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            dtSupplier.DataSource = SupplierData;
            lblNoData.Visible = SupplierData.Rows.Count > 0 ? false : true;
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {

        }
        int supplierId=0;
        private void gvSupplier_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvSupplier.SelectedRowsCount > 0)
            {
                supplierId = Convert.ToInt32(gvSupplier.GetRowCellValue(gvSupplier.FocusedRowHandle, "id"));
                lblid.Text = supplierId.ToString();
            }
        }

        private void bwSaveSupplier_DoWork(object sender, DoWorkEventArgs e)
        {
            ShowLoading("Saving Supplier . . .");
            SaveSupplier();
        }

        private void bwSaveSupplier_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Supplier.isSaveSuccessfully == true)
            {
                MessageBox.Show("Saved Successfully!");
                ViewList();
            }
            else
            {
                MessageBox.Show(Supplier.SaveErrorMessage);
            }
            btnSave.Enabled = true;
            clearfields();

        }
        private void ViewList() {
            if (!bwViewSupplierList.IsBusy) {
                ShowLoading("Refreshing Table . . .");
                bwViewSupplierList.RunWorkerAsync();
            }

            }
        private void clearfields() {
            txtname.Text = string.Empty;
            txtaddress.Text = string.Empty;
        }

        private void SaveSupplier() {

            btnSave.Enabled = false;
            if (btnSave.Text == "Save")
            {
                //save
                Supplier.AddSaveSupplier(txtname.Text, txtaddress.Text, supplierId);
                
            }
            else
            {
                //add
                Supplier.AddSaveSupplier(txtname.Text, txtaddress.Text, 0);

            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewList();
        }


    }
}

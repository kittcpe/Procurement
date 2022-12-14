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
    public partial class TrackItemForm : DevExpress.XtraEditors.XtraForm
    {
        public TrackItemForm()
        {
            InitializeComponent();
        }

        private void dtTrack_Load(object sender, EventArgs e)
        {
            DataTable TrackItemList = new DataTable();
            dtTrack.DataSource = Purchase.GetTrackItem();
        }

        private void dtTrack_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    var rowH = gvTrack.FocusedRowHandle;
                    var focusRowView = (DataRowView)gvTrack.GetFocusedRow();
                    popupMenuGridParent.ShowPopup(barManagerGridProc, new Point(MousePosition.X, MousePosition.Y));
                }
            }
            catch { }
        }

        private void btnprocdet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (gvTrack.SelectedRowsCount > 0)
            {
                lblProcurementNo.Text = gvTrack.GetRowCellValue(gvTrack.FocusedRowHandle, "pr_no").ToString();
                getItemDetails();
                gcProcDetails.Visible = true;
            }
        }

        private void getItemDetails()
        {
            DataTable ItemList = new DataTable();
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

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            gcProcDetails.Visible = false;
        }
    }
}
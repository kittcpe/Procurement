using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProcurementTrackingBalilihan
{
    public partial class SupplierForm : DevExpress.XtraEditors.XtraForm
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

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
                    if (btnSave.Text == "Save")
                    {

                        //save
                    }
                    else
                    {

                        //add

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
            btnSave.Text = "Save";
        }

        private void SupplierForm_Shown(object sender, EventArgs e)
        {
            //load datatable


        }
    }
}

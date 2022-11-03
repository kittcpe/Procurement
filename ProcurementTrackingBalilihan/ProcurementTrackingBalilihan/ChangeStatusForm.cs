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
    public partial class ChangeStatusForm : DevExpress.XtraEditors.XtraForm
    {
        public ChangeStatusForm()
        {
            InitializeComponent();
        }

        public static bool isrefresh = false;
        private void btnupdate_Click(object sender, EventArgs e)
        {
            Purchase.UpdateStatus(PurchaseForm.sup_id, cmbstatus.Text);
            if (Purchase.isUpdateSuccessfully)
            {
                isrefresh = true;
                MessageBox.Show("Updated Successfully");
                this.Close();
            }
            else
                MessageBox.Show(Purchase.UpdateErrorMessage);

        }
    }
}
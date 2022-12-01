using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace ProcurementTrackingBalilihan
{
    public partial class PrintForm : DevExpress.XtraEditors.XtraForm
    {
        public PrintForm()
        {
            InitializeComponent();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            PrintReport pr = new PrintReport();
            pr.ShowPreviewDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }
    }
}
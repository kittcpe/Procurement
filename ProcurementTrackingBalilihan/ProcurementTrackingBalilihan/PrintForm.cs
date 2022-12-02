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
using ProcurementTrackingBalilihan.Dal;

namespace ProcurementTrackingBalilihan
{
    public partial class PrintForm : DevExpress.XtraEditors.XtraForm
    {
        public PrintForm()
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

        private void btnprint_Click(object sender, EventArgs e)
        {
            PrintReport pr = new PrintReport();
            pr.DataSource = reportdata;
            pr.DataMember = "CustomSQLQuery1";
            pr.ShowPreviewDialog();
        }

        DataTable reportdata;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!bwReportList.IsBusy)
            {
                ShowLoading("Getting Data...");
                bwReportList.RunWorkerAsync();
            }
        }

        private void bwReportList_DoWork(object sender, DoWorkEventArgs e)
        {
            reportdata = Reports.loadreport(txtprno.Text);
            bwReportList.CancelAsync();
        }

        private void bwReportList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            dtReport.DataSource = reportdata;
        }
    }
}
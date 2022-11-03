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
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Windows;

namespace ProcurementTracking
{
    public partial class HomepageForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public HomepageForm()
        {
            InitializeComponent();
        }

        private void HomepageForm_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }


    }
}
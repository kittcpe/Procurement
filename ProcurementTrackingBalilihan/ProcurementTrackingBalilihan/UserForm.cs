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
    public partial class UserForm : DevExpress.XtraEditors.XtraForm
    {
        DataTable UserData = new DataTable();
        public UserForm()
        {
            InitializeComponent();
            UserData = User.GetUserList();
            dtUser.DataSource = UserData;
        }
    }
}
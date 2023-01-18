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

        private void dtUser_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    var rowH = gvUser.FocusedRowHandle;
                    var focusRowView = (DataRowView)gvUser.GetFocusedRow();
                    UserPopupMenu.ShowPopup(UserBarManager, new Point(MousePosition.X, MousePosition.Y));
                }
            }
            catch { }
        }

        private void UserForm_Shown(object sender, EventArgs e)
        {
            if (!bwgetuser.IsBusy)
            {
                ShowLoading("Loading Users.....");
                bwgetuser.RunWorkerAsync();
            }
        }

        private void bwgetuser_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                UserData = User.GetUserList();
                bwgetuser.CancelAsync();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());         
            }
        }

        private void bwgetuser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            dtUser.DataSource = UserData;
        }

        private void adduserpopupbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nametxt.Text = string.Empty;
            usernametxt.Text = string.Empty;
            passtxt.Text = string.Empty;
            retypetxt.Text = string.Empty;
            gcuserinfo.Enabled = true;
            enterbtn.Text = "Add";
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            gcuserinfo.Enabled = false;
        }
        private void gvUser_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gcuserinfo.Enabled == false)
            {
                nametxt.Text = gvUser.GetRowCellValue(gvUser.FocusedRowHandle, "name").ToString();
                usernametxt.Text = gvUser.GetRowCellValue(gvUser.FocusedRowHandle, "username").ToString();
                passtxt.Text = gvUser.GetRowCellValue(gvUser.FocusedRowHandle, "password").ToString();
                retypetxt.Text = gvUser.GetRowCellValue(gvUser.FocusedRowHandle, "password").ToString();
            }
        }

        public string editid;
        private void edituserpopupbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            editid = gvUser.GetRowCellValue(gvUser.FocusedRowHandle, "id").ToString();
            nametxt.Text = gvUser.GetRowCellValue(gvUser.FocusedRowHandle, "name").ToString();
            usernametxt.Text = gvUser.GetRowCellValue(gvUser.FocusedRowHandle, "username").ToString();
            passtxt.Text = string.Empty;
            retypetxt.Text = string.Empty;
            gcuserinfo.Enabled = true;
            enterbtn.Text = "Save";
        }

        private void deluserpopupbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string id = gvUser.GetRowCellValue(gvUser.FocusedRowHandle, "id").ToString();
            User.DeleteUser(id);
            if (User.isUserDeleted == true)
            {
                if (!bwgetuser.IsBusy)
                {
                    ShowLoading("Loading Users.....");
                    bwgetuser.RunWorkerAsync();
                }
                MessageBox.Show("User Deleted Successfully.");
            }
            else {
                MessageBox.Show(User.DeleteErrorMessage);
            }

        }

        private void enterbtn_Click(object sender, EventArgs e)
        {
            if (enterbtn.Text == "Add")
            {
                if (passtxt.Text == retypetxt.Text)
                {
                    User.adduser(nametxt.Text, usernametxt.Text, passtxt.Text);
                    if (User.isaddedsuccesfully)
                    {
                        gcuserinfo.Enabled = false;
                        if (!bwgetuser.IsBusy)
                        {
                            ShowLoading("Loading Users.....");
                            bwgetuser.RunWorkerAsync();
                        }
                        MessageBox.Show("User Added Successfully!");
                    }
                    else
                    {
                        MessageBox.Show(User.isaddederrormerssage);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match!");
                }
            }
            else
            {
                if (passtxt.Text == retypetxt.Text)
                {
                    User.edituser(editid, nametxt.Text, usernametxt.Text, passtxt.Text);
                    if (User.iseditedsuccesfully)
                    {
                        gcuserinfo.Enabled = false;
                        if (!bwgetuser.IsBusy)
                        {
                            ShowLoading("Loading Users.....");
                            bwgetuser.RunWorkerAsync();
                        }
                        MessageBox.Show("User Edited Successfully!");
                    }
                    else
                    {
                        MessageBox.Show(User.editerrormerssage);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match!");
                }
            }
        }
    }
}
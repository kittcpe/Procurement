namespace ProcurementTrackingBalilihan
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.gcuserinfo = new DevExpress.XtraEditors.GroupControl();
            this.cancelbtn = new DevExpress.XtraEditors.SimpleButton();
            this.enterbtn = new DevExpress.XtraEditors.SimpleButton();
            this.retypetxt = new DevExpress.XtraEditors.TextEdit();
            this.UserBarManager = new DevExpress.XtraBars.BarManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.adduserpopupbtn = new DevExpress.XtraBars.BarButtonItem();
            this.edituserpopupbtn = new DevExpress.XtraBars.BarButtonItem();
            this.deluserpopupbtn = new DevExpress.XtraBars.BarButtonItem();
            this.passtxt = new DevExpress.XtraEditors.TextEdit();
            this.usernametxt = new DevExpress.XtraEditors.TextEdit();
            this.nametxt = new DevExpress.XtraEditors.TextEdit();
            this.retypelbl = new DevExpress.XtraEditors.LabelControl();
            this.passlbl = new DevExpress.XtraEditors.LabelControl();
            this.usernamelbl = new DevExpress.XtraEditors.LabelControl();
            this.namelbl = new DevExpress.XtraEditors.LabelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.dtUser = new DevExpress.XtraGrid.GridControl();
            this.gvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.role = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserPopupMenu = new DevExpress.XtraBars.PopupMenu();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::SAMPLE_MEMO_NOTIF.WaitForm1), true, true);
            this.bwgetuser = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gcuserinfo)).BeginInit();
            this.gcuserinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retypetxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passtxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernametxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nametxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPopupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // gcuserinfo
            // 
            this.gcuserinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gcuserinfo.Controls.Add(this.cancelbtn);
            this.gcuserinfo.Controls.Add(this.enterbtn);
            this.gcuserinfo.Controls.Add(this.retypetxt);
            this.gcuserinfo.Controls.Add(this.passtxt);
            this.gcuserinfo.Controls.Add(this.usernametxt);
            this.gcuserinfo.Controls.Add(this.nametxt);
            this.gcuserinfo.Controls.Add(this.retypelbl);
            this.gcuserinfo.Controls.Add(this.passlbl);
            this.gcuserinfo.Controls.Add(this.usernamelbl);
            this.gcuserinfo.Controls.Add(this.namelbl);
            this.gcuserinfo.Controls.Add(this.btnDelete);
            this.gcuserinfo.Controls.Add(this.btnSave);
            this.gcuserinfo.Enabled = false;
            this.gcuserinfo.Location = new System.Drawing.Point(710, 12);
            this.gcuserinfo.Name = "gcuserinfo";
            this.gcuserinfo.Size = new System.Drawing.Size(512, 483);
            this.gcuserinfo.TabIndex = 272;
            this.gcuserinfo.Text = "User Information";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelbtn.Image")));
            this.cancelbtn.Location = new System.Drawing.Point(256, 415);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(112, 51);
            this.cancelbtn.TabIndex = 282;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // enterbtn
            // 
            this.enterbtn.Image = ((System.Drawing.Image)(resources.GetObject("enterbtn.Image")));
            this.enterbtn.Location = new System.Drawing.Point(374, 415);
            this.enterbtn.Name = "enterbtn";
            this.enterbtn.Size = new System.Drawing.Size(112, 51);
            this.enterbtn.TabIndex = 281;
            this.enterbtn.Text = "Add";
            this.enterbtn.Click += new System.EventHandler(this.enterbtn_Click);
            // 
            // retypetxt
            // 
            this.retypetxt.Location = new System.Drawing.Point(15, 232);
            this.retypetxt.MenuManager = this.UserBarManager;
            this.retypetxt.Name = "retypetxt";
            this.retypetxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retypetxt.Properties.Appearance.Options.UseFont = true;
            this.retypetxt.Properties.PasswordChar = '*';
            this.retypetxt.Size = new System.Drawing.Size(471, 22);
            this.retypetxt.TabIndex = 280;
            // 
            // UserBarManager
            // 
            this.UserBarManager.DockControls.Add(this.barDockControlTop);
            this.UserBarManager.DockControls.Add(this.barDockControlBottom);
            this.UserBarManager.DockControls.Add(this.barDockControlLeft);
            this.UserBarManager.DockControls.Add(this.barDockControlRight);
            this.UserBarManager.Form = this;
            this.UserBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.adduserpopupbtn,
            this.edituserpopupbtn,
            this.deluserpopupbtn});
            this.UserBarManager.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1233, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 614);
            this.barDockControlBottom.Size = new System.Drawing.Size(1233, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 614);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1233, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 614);
            // 
            // adduserpopupbtn
            // 
            this.adduserpopupbtn.Caption = "Add User";
            this.adduserpopupbtn.Glyph = ((System.Drawing.Image)(resources.GetObject("adduserpopupbtn.Glyph")));
            this.adduserpopupbtn.Id = 0;
            this.adduserpopupbtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("adduserpopupbtn.LargeGlyph")));
            this.adduserpopupbtn.Name = "adduserpopupbtn";
            this.adduserpopupbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.adduserpopupbtn_ItemClick);
            // 
            // edituserpopupbtn
            // 
            this.edituserpopupbtn.Caption = "Edit User";
            this.edituserpopupbtn.Glyph = ((System.Drawing.Image)(resources.GetObject("edituserpopupbtn.Glyph")));
            this.edituserpopupbtn.Id = 1;
            this.edituserpopupbtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("edituserpopupbtn.LargeGlyph")));
            this.edituserpopupbtn.Name = "edituserpopupbtn";
            this.edituserpopupbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.edituserpopupbtn_ItemClick);
            // 
            // deluserpopupbtn
            // 
            this.deluserpopupbtn.Caption = "Delete User";
            this.deluserpopupbtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deluserpopupbtn.Glyph")));
            this.deluserpopupbtn.Id = 2;
            this.deluserpopupbtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deluserpopupbtn.LargeGlyph")));
            this.deluserpopupbtn.Name = "deluserpopupbtn";
            this.deluserpopupbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deluserpopupbtn_ItemClick);
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(15, 180);
            this.passtxt.MenuManager = this.UserBarManager;
            this.passtxt.Name = "passtxt";
            this.passtxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Properties.Appearance.Options.UseFont = true;
            this.passtxt.Properties.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(471, 22);
            this.passtxt.TabIndex = 279;
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(15, 132);
            this.usernametxt.MenuManager = this.UserBarManager;
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.Properties.Appearance.Options.UseFont = true;
            this.usernametxt.Size = new System.Drawing.Size(471, 22);
            this.usernametxt.TabIndex = 278;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(15, 78);
            this.nametxt.MenuManager = this.UserBarManager;
            this.nametxt.Name = "nametxt";
            this.nametxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Properties.Appearance.Options.UseFont = true;
            this.nametxt.Size = new System.Drawing.Size(471, 22);
            this.nametxt.TabIndex = 277;
            // 
            // retypelbl
            // 
            this.retypelbl.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retypelbl.Location = new System.Drawing.Point(15, 208);
            this.retypelbl.Name = "retypelbl";
            this.retypelbl.Size = new System.Drawing.Size(135, 18);
            this.retypelbl.TabIndex = 9;
            this.retypelbl.Text = "Retype Password:";
            // 
            // passlbl
            // 
            this.passlbl.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.Location = new System.Drawing.Point(15, 156);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(78, 18);
            this.passlbl.TabIndex = 8;
            this.passlbl.Text = "Password:";
            // 
            // usernamelbl
            // 
            this.usernamelbl.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(15, 108);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(80, 18);
            this.usernamelbl.TabIndex = 7;
            this.usernamelbl.Text = "Username:";
            // 
            // namelbl
            // 
            this.namelbl.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(15, 54);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(48, 18);
            this.namelbl.TabIndex = 6;
            this.namelbl.Text = "Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(233, 565);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 41);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(337, 565);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 41);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Add";
            // 
            // dtUser
            // 
            this.dtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtUser.Location = new System.Drawing.Point(10, 12);
            this.dtUser.MainView = this.gvUser;
            this.dtUser.Name = "dtUser";
            this.dtUser.Size = new System.Drawing.Size(694, 590);
            this.dtUser.TabIndex = 271;
            this.dtUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUser});
            this.dtUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtUser_MouseDown);
            // 
            // gvUser
            // 
            this.gvUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.name,
            this.username,
            this.role});
            this.gvUser.GridControl = this.dtUser;
            this.gvUser.Name = "gvUser";
            this.gvUser.OptionsBehavior.Editable = false;
            this.gvUser.OptionsFind.AlwaysVisible = true;
            this.gvUser.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvUser.OptionsView.RowAutoHeight = true;
            this.gvUser.OptionsView.ShowGroupPanel = false;
            this.gvUser.OptionsView.ShowIndicator = false;
            this.gvUser.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvUser_FocusedRowChanged);
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.Caption = "Name";
            this.name.FieldName = "name";
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 0;
            // 
            // username
            // 
            this.username.Caption = "Username";
            this.username.FieldName = "username";
            this.username.Name = "username";
            this.username.Visible = true;
            this.username.VisibleIndex = 1;
            // 
            // role
            // 
            this.role.Caption = "Privilege";
            this.role.FieldName = "role";
            this.role.Name = "role";
            this.role.Visible = true;
            this.role.VisibleIndex = 2;
            // 
            // UserPopupMenu
            // 
            this.UserPopupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.adduserpopupbtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.edituserpopupbtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.deluserpopupbtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.UserPopupMenu.Manager = this.UserBarManager;
            this.UserPopupMenu.Name = "UserPopupMenu";
            // 
            // bwgetuser
            // 
            this.bwgetuser.WorkerSupportsCancellation = true;
            this.bwgetuser.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwgetuser_DoWork);
            this.bwgetuser.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwgetuser_RunWorkerCompleted);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 614);
            this.Controls.Add(this.gcuserinfo);
            this.Controls.Add(this.dtUser);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Shown += new System.EventHandler(this.UserForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gcuserinfo)).EndInit();
            this.gcuserinfo.ResumeLayout(false);
            this.gcuserinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retypetxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passtxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernametxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nametxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPopupMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcuserinfo;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl dtUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUser;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraGrid.Columns.GridColumn username;
        private DevExpress.XtraGrid.Columns.GridColumn role;
        private DevExpress.XtraBars.PopupMenu UserPopupMenu;
        private DevExpress.XtraBars.BarButtonItem adduserpopupbtn;
        private DevExpress.XtraBars.BarButtonItem edituserpopupbtn;
        private DevExpress.XtraBars.BarButtonItem deluserpopupbtn;
        private DevExpress.XtraBars.BarManager UserBarManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.ComponentModel.BackgroundWorker bwgetuser;
        private DevExpress.XtraEditors.LabelControl namelbl;
        private DevExpress.XtraEditors.TextEdit retypetxt;
        private DevExpress.XtraEditors.TextEdit passtxt;
        private DevExpress.XtraEditors.TextEdit usernametxt;
        private DevExpress.XtraEditors.TextEdit nametxt;
        private DevExpress.XtraEditors.LabelControl retypelbl;
        private DevExpress.XtraEditors.LabelControl passlbl;
        private DevExpress.XtraEditors.LabelControl usernamelbl;
        private DevExpress.XtraEditors.SimpleButton enterbtn;
        private DevExpress.XtraEditors.SimpleButton cancelbtn;
    }
}
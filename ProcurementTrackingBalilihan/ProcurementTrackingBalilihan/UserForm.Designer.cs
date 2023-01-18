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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.gcUserInfo = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.dtUser = new DevExpress.XtraGrid.GridControl();
            this.gvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.role = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.UserBarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcUserInfo)).BeginInit();
            this.gcUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBarManager)).BeginInit();
            this.SuspendLayout();
            // 
            // gcUserInfo
            // 
            this.gcUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gcUserInfo.Controls.Add(this.btnDelete);
            this.gcUserInfo.Controls.Add(this.btnSave);
            this.gcUserInfo.Enabled = false;
            this.gcUserInfo.Location = new System.Drawing.Point(710, 12);
            this.gcUserInfo.Name = "gcUserInfo";
            this.gcUserInfo.Size = new System.Drawing.Size(512, 483);
            this.gcUserInfo.TabIndex = 272;
            this.gcUserInfo.Text = "User Information";
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.UserPopupMenu.Manager = this.UserBarManager;
            this.UserPopupMenu.Name = "UserPopupMenu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Add User";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Edit User";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Delete User";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // UserBarManager
            // 
            this.UserBarManager.DockControls.Add(this.barDockControlTop);
            this.UserBarManager.DockControls.Add(this.barDockControlBottom);
            this.UserBarManager.DockControls.Add(this.barDockControlLeft);
            this.UserBarManager.DockControls.Add(this.barDockControlRight);
            this.UserBarManager.Form = this;
            this.UserBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
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
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 614);
            this.Controls.Add(this.gcUserInfo);
            this.Controls.Add(this.dtUser);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UserForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.gcUserInfo)).EndInit();
            this.gcUserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBarManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcUserInfo;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl dtUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUser;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraGrid.Columns.GridColumn username;
        private DevExpress.XtraGrid.Columns.GridColumn role;
        private DevExpress.XtraBars.PopupMenu UserPopupMenu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarManager UserBarManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}
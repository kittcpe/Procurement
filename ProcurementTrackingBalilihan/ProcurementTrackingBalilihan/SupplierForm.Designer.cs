namespace ProcurementTrackingBalilihan
{
    partial class SupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            this.dtSupplier = new DevExpress.XtraGrid.GridControl();
            this.gvSupplier = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.supplier_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.supplier_address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSupplierInfo = new DevExpress.XtraEditors.GroupControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtaddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.popupMenuGridParent = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnAddSupplier = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditSupplier = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barManagerGridParent = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tsDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.bwViewSupplierList = new System.ComponentModel.BackgroundWorker();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::SAMPLE_MEMO_NOTIF.WaitForm1), true, true);
            this.lblNoData = new DevExpress.XtraEditors.LabelControl();
            this.lblid = new DevExpress.XtraEditors.LabelControl();
            this.bwSaveSupplier = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dtSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSupplierInfo)).BeginInit();
            this.gcSupplierInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGridParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerGridParent)).BeginInit();
            this.SuspendLayout();
            // 
            // dtSupplier
            // 
            this.dtSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtSupplier.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSupplier.Location = new System.Drawing.Point(12, 51);
            this.dtSupplier.MainView = this.gvSupplier;
            this.dtSupplier.Name = "dtSupplier";
            this.dtSupplier.Size = new System.Drawing.Size(406, 320);
            this.dtSupplier.TabIndex = 261;
            this.dtSupplier.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSupplier});
            this.dtSupplier.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gcSupplier_MouseDown);
            // 
            // gvSupplier
            // 
            this.gvSupplier.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.supplier_name,
            this.supplier_address});
            this.gvSupplier.GridControl = this.dtSupplier;
            this.gvSupplier.Name = "gvSupplier";
            this.gvSupplier.OptionsBehavior.Editable = false;
            this.gvSupplier.OptionsFind.AlwaysVisible = true;
            this.gvSupplier.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSupplier.OptionsView.RowAutoHeight = true;
            this.gvSupplier.OptionsView.ShowGroupPanel = false;
            this.gvSupplier.OptionsView.ShowIndicator = false;
            this.gvSupplier.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvSupplier_FocusedRowChanged);
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // supplier_name
            // 
            this.supplier_name.Caption = "Supplier Name";
            this.supplier_name.FieldName = "name";
            this.supplier_name.Name = "supplier_name";
            this.supplier_name.Visible = true;
            this.supplier_name.VisibleIndex = 0;
            // 
            // supplier_address
            // 
            this.supplier_address.Caption = "Address";
            this.supplier_address.FieldName = "address";
            this.supplier_address.Name = "supplier_address";
            this.supplier_address.Visible = true;
            this.supplier_address.VisibleIndex = 1;
            // 
            // gcSupplierInfo
            // 
            this.gcSupplierInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSupplierInfo.Controls.Add(this.btnSave);
            this.gcSupplierInfo.Controls.Add(this.txtaddress);
            this.gcSupplierInfo.Controls.Add(this.labelControl2);
            this.gcSupplierInfo.Controls.Add(this.txtname);
            this.gcSupplierInfo.Controls.Add(this.labelControl1);
            this.gcSupplierInfo.Location = new System.Drawing.Point(450, 51);
            this.gcSupplierInfo.Name = "gcSupplierInfo";
            this.gcSupplierInfo.Size = new System.Drawing.Size(466, 244);
            this.gcSupplierInfo.TabIndex = 262;
            this.gcSupplierInfo.Text = "Supplier\'s Information";
            this.gcSupplierInfo.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(355, 194);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 41);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Add";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(96, 86);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(358, 20);
            this.txtaddress.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Supplier Address:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(96, 50);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(358, 20);
            this.txtname.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Supplier Name:";
            // 
            // popupMenuGridParent
            // 
            this.popupMenuGridParent.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddSupplier),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditSupplier),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh)});
            this.popupMenuGridParent.Manager = this.barManagerGridParent;
            this.popupMenuGridParent.Name = "popupMenuGridParent";
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Caption = "Add Supplier";
            this.btnAddSupplier.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddSupplier.Glyph")));
            this.btnAddSupplier.Id = 0;
            this.btnAddSupplier.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddSupplier.LargeGlyph")));
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddSupplier_ItemClick);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Caption = "Edit Supplier";
            this.btnEditSupplier.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditSupplier.Glyph")));
            this.btnEditSupplier.Id = 1;
            this.btnEditSupplier.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditSupplier.LargeGlyph")));
            this.btnEditSupplier.LargeGlyphDisabled = ((System.Drawing.Image)(resources.GetObject("btnEditSupplier.LargeGlyphDisabled")));
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditSupplier_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh Table";
            this.btnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Glyph")));
            this.btnRefresh.Id = 3;
            this.btnRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.LargeGlyph")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // barManagerGridParent
            // 
            this.barManagerGridParent.DockControls.Add(this.barDockControlTop);
            this.barManagerGridParent.DockControls.Add(this.barDockControlBottom);
            this.barManagerGridParent.DockControls.Add(this.barDockControlLeft);
            this.barManagerGridParent.DockControls.Add(this.barDockControlRight);
            this.barManagerGridParent.Form = this;
            this.barManagerGridParent.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAddSupplier,
            this.btnEditSupplier,
            this.tsDelete,
            this.btnRefresh,
            this.barButtonItem1});
            this.barManagerGridParent.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(928, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 561);
            this.barDockControlBottom.Size = new System.Drawing.Size(928, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 561);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(928, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 561);
            // 
            // tsDelete
            // 
            this.tsDelete.Caption = "Delete";
            this.tsDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("tsDelete.Glyph")));
            this.tsDelete.Id = 2;
            this.tsDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsDelete.LargeGlyph")));
            this.tsDelete.Name = "tsDelete";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Sync CA_type from FITTSys";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl3.Location = new System.Drawing.Point(12, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(194, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "*right click to transact";
            // 
            // bwViewSupplierList
            // 
            this.bwViewSupplierList.WorkerSupportsCancellation = true;
            this.bwViewSupplierList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwViewSupplierList_DoWork);
            this.bwViewSupplierList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwViewSupplierList_RunWorkerCompleted);
            // 
            // lblNoData
            // 
            this.lblNoData.Location = new System.Drawing.Point(168, 173);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(72, 13);
            this.lblNoData.TabIndex = 267;
            this.lblNoData.Text = "No Data Found";
            this.lblNoData.Visible = false;
            // 
            // lblid
            // 
            this.lblid.Location = new System.Drawing.Point(212, 30);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(63, 13);
            this.lblid.TabIndex = 272;
            this.lblid.Text = "labelControl4";
            // 
            // bwSaveSupplier
            // 
            this.bwSaveSupplier.WorkerSupportsCancellation = true;
            this.bwSaveSupplier.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSaveSupplier_DoWork);
            this.bwSaveSupplier.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwSaveSupplier_RunWorkerCompleted);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 561);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gcSupplierInfo);
            this.Controls.Add(this.dtSupplier);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierForm";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            this.Shown += new System.EventHandler(this.SupplierForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSupplierInfo)).EndInit();
            this.gcSupplierInfo.ResumeLayout(false);
            this.gcSupplierInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGridParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerGridParent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn supplier_name;
        private DevExpress.XtraGrid.Columns.GridColumn supplier_address;
        private DevExpress.XtraEditors.GroupControl gcSupplierInfo;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtaddress;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtname;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.PopupMenu popupMenuGridParent;
        private DevExpress.XtraBars.BarButtonItem btnAddSupplier;
        private DevExpress.XtraBars.BarButtonItem btnEditSupplier;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarManager barManagerGridParent;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem tsDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.ComponentModel.BackgroundWorker bwViewSupplierList;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.LabelControl lblNoData;
        private DevExpress.XtraEditors.LabelControl lblid;
        private System.ComponentModel.BackgroundWorker bwSaveSupplier;


    }
}


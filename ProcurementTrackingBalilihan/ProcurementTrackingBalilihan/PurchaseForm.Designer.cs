namespace ProcurementTrackingBalilihan
{
    partial class PurchaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseForm));
            this.dtPurchase = new DevExpress.XtraGrid.GridControl();
            this.gvSupplier = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pr_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.end_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mode_of_pr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.abc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pre_proc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.posting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pre_bid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.opening_of_bids = new DevExpress.XtraGrid.Columns.GridColumn();
            this.detailed_bid_eval = new DevExpress.XtraGrid.Columns.GridColumn();
            this.award = new DevExpress.XtraGrid.Columns.GridColumn();
            this.po = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ntp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.delivery = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnMode = new DevExpress.XtraEditors.SimpleButton();
            this.txtProcNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bwViewSupplierList = new System.ComponentModel.BackgroundWorker();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::SAMPLE_MEMO_NOTIF.WaitForm1), true, true);
            this.bwViewProcurementList = new System.ComponentModel.BackgroundWorker();
            this.bwPurchase = new System.ComponentModel.BackgroundWorker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPRmode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtABC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dtpBids = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dtpEval = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.dtpAward = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dtpPO = new DevExpress.XtraEditors.DateEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.dtpNTP = new DevExpress.XtraEditors.DateEdit();
            this.dtpDelivery = new DevExpress.XtraEditors.DateEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.barManagerGridProc = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnAddSupplier = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditSupplier = new DevExpress.XtraBars.BarButtonItem();
            this.tsDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddProc = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditProc = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangeStatus = new DevExpress.XtraBars.BarSubItem();
            this.btnpreproc = new DevExpress.XtraBars.BarButtonItem();
            this.btnposting = new DevExpress.XtraBars.BarButtonItem();
            this.btnprebid = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetails = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuGridParent = new DevExpress.XtraBars.PopupMenu(this.components);
            this.txtEnduser = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.gcProcDetails = new DevExpress.XtraEditors.GroupControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.lblProcurementNo = new DevExpress.XtraEditors.LabelControl();
            this.btnSaveExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteItem = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddItem = new DevExpress.XtraEditors.SimpleButton();
            this.txtUnitCost = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtItemDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtUnit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtPropertyNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.dtItemDetails = new DevExpress.XtraGrid.GridControl();
            this.gvItemDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.property_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.txtPurpose = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPRmode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtABC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBids.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBids.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEval.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEval.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpAward.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpAward.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPO.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNTP.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNTP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDelivery.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDelivery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerGridProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGridParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnduser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProcDetails)).BeginInit();
            this.gcProcDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPropertyNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtItemDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurpose.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPurchase
            // 
            this.dtPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPurchase.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPurchase.Location = new System.Drawing.Point(12, 12);
            this.dtPurchase.MainView = this.gvSupplier;
            this.dtPurchase.Name = "dtPurchase";
            this.dtPurchase.Size = new System.Drawing.Size(822, 660);
            this.dtPurchase.TabIndex = 262;
            this.dtPurchase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSupplier});
            this.dtPurchase.DoubleClick += new System.EventHandler(this.dtPurchase_DoubleClick);
            this.dtPurchase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtPurchase_MouseDown);
            this.dtPurchase.MouseEnter += new System.EventHandler(this.dtPurchase_MouseEnter);
            // 
            // gvSupplier
            // 
            this.gvSupplier.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.pr_no,
            this.description,
            this.end_user,
            this.mode_of_pr,
            this.abc,
            this.pre_proc,
            this.posting,
            this.pre_bid,
            this.opening_of_bids,
            this.detailed_bid_eval,
            this.award,
            this.po,
            this.ntp,
            this.delivery});
            this.gvSupplier.GridControl = this.dtPurchase;
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
            // pr_no
            // 
            this.pr_no.Caption = "PR No.";
            this.pr_no.FieldName = "pr_no";
            this.pr_no.Name = "pr_no";
            this.pr_no.Visible = true;
            this.pr_no.VisibleIndex = 0;
            this.pr_no.Width = 54;
            // 
            // description
            // 
            this.description.Caption = "Description";
            this.description.FieldName = "description";
            this.description.Name = "description";
            this.description.Visible = true;
            this.description.VisibleIndex = 1;
            this.description.Width = 54;
            // 
            // end_user
            // 
            this.end_user.Caption = "End User";
            this.end_user.FieldName = "end_user";
            this.end_user.Name = "end_user";
            this.end_user.Visible = true;
            this.end_user.VisibleIndex = 2;
            this.end_user.Width = 51;
            // 
            // mode_of_pr
            // 
            this.mode_of_pr.Caption = "Mode of PR";
            this.mode_of_pr.FieldName = "mode_of_pr";
            this.mode_of_pr.Name = "mode_of_pr";
            this.mode_of_pr.Visible = true;
            this.mode_of_pr.VisibleIndex = 3;
            // 
            // abc
            // 
            this.abc.Caption = "Amount";
            this.abc.DisplayFormat.FormatString = "n2";
            this.abc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.abc.FieldName = "abc";
            this.abc.Name = "abc";
            this.abc.Visible = true;
            this.abc.VisibleIndex = 4;
            this.abc.Width = 51;
            // 
            // pre_proc
            // 
            this.pre_proc.Caption = "Pre-Proc";
            this.pre_proc.DisplayFormat.FormatString = "d";
            this.pre_proc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pre_proc.FieldName = "pre_proc";
            this.pre_proc.Name = "pre_proc";
            this.pre_proc.Visible = true;
            this.pre_proc.VisibleIndex = 5;
            // 
            // posting
            // 
            this.posting.Caption = "Posting";
            this.posting.DisplayFormat.FormatString = "d";
            this.posting.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.posting.FieldName = "posting";
            this.posting.Name = "posting";
            this.posting.Visible = true;
            this.posting.VisibleIndex = 6;
            this.posting.Width = 51;
            // 
            // pre_bid
            // 
            this.pre_bid.Caption = "Pre-Bid";
            this.pre_bid.DisplayFormat.FormatString = "d";
            this.pre_bid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pre_bid.FieldName = "pre_bid";
            this.pre_bid.Name = "pre_bid";
            this.pre_bid.Visible = true;
            this.pre_bid.VisibleIndex = 7;
            this.pre_bid.Width = 51;
            // 
            // opening_of_bids
            // 
            this.opening_of_bids.Caption = "Opening of Bids";
            this.opening_of_bids.DisplayFormat.FormatString = "d";
            this.opening_of_bids.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.opening_of_bids.FieldName = "opening_of_bids";
            this.opening_of_bids.Name = "opening_of_bids";
            this.opening_of_bids.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.opening_of_bids.Visible = true;
            this.opening_of_bids.VisibleIndex = 8;
            this.opening_of_bids.Width = 85;
            // 
            // detailed_bid_eval
            // 
            this.detailed_bid_eval.Caption = "Detailed Bid Eval";
            this.detailed_bid_eval.DisplayFormat.FormatString = "d";
            this.detailed_bid_eval.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detailed_bid_eval.FieldName = "detailed_bid_eval";
            this.detailed_bid_eval.Name = "detailed_bid_eval";
            this.detailed_bid_eval.Visible = true;
            this.detailed_bid_eval.VisibleIndex = 9;
            this.detailed_bid_eval.Width = 44;
            // 
            // award
            // 
            this.award.Caption = "Award";
            this.award.DisplayFormat.FormatString = "d";
            this.award.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.award.FieldName = "award";
            this.award.Name = "award";
            this.award.Visible = true;
            this.award.VisibleIndex = 10;
            this.award.Width = 44;
            // 
            // po
            // 
            this.po.Caption = "PO";
            this.po.DisplayFormat.FormatString = "d";
            this.po.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.po.FieldName = "po";
            this.po.Name = "po";
            this.po.Visible = true;
            this.po.VisibleIndex = 11;
            this.po.Width = 44;
            // 
            // ntp
            // 
            this.ntp.Caption = "NTP";
            this.ntp.DisplayFormat.FormatString = "d";
            this.ntp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ntp.FieldName = "ntp";
            this.ntp.Name = "ntp";
            this.ntp.Visible = true;
            this.ntp.VisibleIndex = 12;
            this.ntp.Width = 44;
            // 
            // delivery
            // 
            this.delivery.Caption = "Delivery";
            this.delivery.DisplayFormat.FormatString = "d";
            this.delivery.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.delivery.FieldName = "delivery";
            this.delivery.Name = "delivery";
            this.delivery.Visible = true;
            this.delivery.VisibleIndex = 13;
            this.delivery.Width = 64;
            // 
            // btnMode
            // 
            this.btnMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMode.Appearance.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMode.Appearance.Options.UseFont = true;
            this.btnMode.Image = ((System.Drawing.Image)(resources.GetObject("btnMode.Image")));
            this.btnMode.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnMode.Location = new System.Drawing.Point(1180, 619);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(123, 53);
            this.btnMode.TabIndex = 263;
            this.btnMode.Text = "Add";
            this.btnMode.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtProcNo
            // 
            this.txtProcNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcNo.Location = new System.Drawing.Point(942, 27);
            this.txtProcNo.Name = "txtProcNo";
            this.txtProcNo.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcNo.Properties.Appearance.Options.UseFont = true;
            this.txtProcNo.Size = new System.Drawing.Size(361, 22);
            this.txtProcNo.TabIndex = 264;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(860, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 16);
            this.labelControl1.TabIndex = 265;
            this.labelControl1.Text = "PR No:";
            // 
            // bwViewSupplierList
            // 
            this.bwViewSupplierList.WorkerSupportsCancellation = true;
            this.bwViewSupplierList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwViewSupplierList_DoWork);
            this.bwViewSupplierList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwViewSupplierList_RunWorkerCompleted);
            // 
            // bwViewProcurementList
            // 
            this.bwViewProcurementList.WorkerSupportsCancellation = true;
            this.bwViewProcurementList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwViewProcurementList_DoWork);
            this.bwViewProcurementList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwViewProcurementList_RunWorkerCompleted);
            // 
            // bwPurchase
            // 
            this.bwPurchase.WorkerSupportsCancellation = true;
            this.bwPurchase.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwPurchase_DoWork);
            this.bwPurchase.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwPurchase_RunWorkerCompleted);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(840, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 16);
            this.labelControl2.TabIndex = 266;
            this.labelControl2.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(942, 66);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Size = new System.Drawing.Size(361, 91);
            this.txtDescription.TabIndex = 267;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(840, 214);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 16);
            this.labelControl3.TabIndex = 268;
            this.labelControl3.Text = "Mode of PR:";
            // 
            // txtPRmode
            // 
            this.txtPRmode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPRmode.Location = new System.Drawing.Point(942, 211);
            this.txtPRmode.Name = "txtPRmode";
            this.txtPRmode.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRmode.Properties.Appearance.Options.UseFont = true;
            this.txtPRmode.Size = new System.Drawing.Size(361, 22);
            this.txtPRmode.TabIndex = 269;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(898, 242);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 16);
            this.labelControl4.TabIndex = 270;
            this.labelControl4.Text = "ABC:";
            // 
            // txtABC
            // 
            this.txtABC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtABC.Location = new System.Drawing.Point(944, 239);
            this.txtABC.Name = "txtABC";
            this.txtABC.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtABC.Properties.Appearance.Options.UseFont = true;
            this.txtABC.Properties.EditFormat.FormatString = "n2";
            this.txtABC.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtABC.Properties.Mask.EditMask = "n2";
            this.txtABC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtABC.Size = new System.Drawing.Size(361, 22);
            this.txtABC.TabIndex = 271;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(872, 270);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 16);
            this.labelControl5.TabIndex = 272;
            this.labelControl5.Text = "Status:";
            // 
            // cmbMode
            // 
            this.cmbMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMode.EditValue = "Pre-Proc";
            this.cmbMode.Location = new System.Drawing.Point(944, 267);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F);
            this.cmbMode.Properties.Appearance.Options.UseFont = true;
            this.cmbMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMode.Properties.DropDownRows = 3;
            this.cmbMode.Properties.Items.AddRange(new object[] {
            "Pre-Proc",
            "Posting",
            "Pre-Bid"});
            this.cmbMode.Properties.NullText = "Pre-proc";
            this.cmbMode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbMode.Size = new System.Drawing.Size(361, 22);
            this.cmbMode.TabIndex = 273;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(872, 313);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(128, 16);
            this.labelControl6.TabIndex = 274;
            this.labelControl6.Text = "Opening of Bids:";
            // 
            // dtpBids
            // 
            this.dtpBids.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBids.EditValue = null;
            this.dtpBids.Location = new System.Drawing.Point(1008, 310);
            this.dtpBids.Name = "dtpBids";
            this.dtpBids.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F);
            this.dtpBids.Properties.Appearance.Options.UseFont = true;
            this.dtpBids.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBids.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBids.Properties.CalendarTimeProperties.EditFormat.FormatString = "yyyy:mm:dd";
            this.dtpBids.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpBids.Properties.DisplayFormat.FormatString = "D";
            this.dtpBids.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpBids.Properties.Mask.EditMask = "D";
            this.dtpBids.Size = new System.Drawing.Size(297, 22);
            this.dtpBids.TabIndex = 275;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(860, 348);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(144, 16);
            this.labelControl7.TabIndex = 276;
            this.labelControl7.Text = "Detailed Bid Eval:";
            // 
            // dtpEval
            // 
            this.dtpEval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEval.EditValue = null;
            this.dtpEval.Location = new System.Drawing.Point(1008, 345);
            this.dtpEval.Name = "dtpEval";
            this.dtpEval.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F);
            this.dtpEval.Properties.Appearance.Options.UseFont = true;
            this.dtpEval.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpEval.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpEval.Size = new System.Drawing.Size(297, 22);
            this.dtpEval.TabIndex = 277;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(956, 384);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 16);
            this.labelControl8.TabIndex = 278;
            this.labelControl8.Text = "Award:";
            // 
            // dtpAward
            // 
            this.dtpAward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpAward.EditValue = null;
            this.dtpAward.Location = new System.Drawing.Point(1008, 381);
            this.dtpAward.Name = "dtpAward";
            this.dtpAward.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F);
            this.dtpAward.Properties.Appearance.Options.UseFont = true;
            this.dtpAward.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpAward.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpAward.Size = new System.Drawing.Size(297, 22);
            this.dtpAward.TabIndex = 279;
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl9.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(976, 418);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(24, 16);
            this.labelControl9.TabIndex = 280;
            this.labelControl9.Text = "PO:";
            // 
            // dtpPO
            // 
            this.dtpPO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPO.EditValue = null;
            this.dtpPO.Location = new System.Drawing.Point(1008, 415);
            this.dtpPO.Name = "dtpPO";
            this.dtpPO.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F);
            this.dtpPO.Properties.Appearance.Options.UseFont = true;
            this.dtpPO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpPO.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpPO.Size = new System.Drawing.Size(297, 22);
            this.dtpPO.TabIndex = 281;
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl10.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(968, 455);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(32, 16);
            this.labelControl10.TabIndex = 282;
            this.labelControl10.Text = "NTP:";
            // 
            // dtpNTP
            // 
            this.dtpNTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNTP.EditValue = null;
            this.dtpNTP.Location = new System.Drawing.Point(1008, 452);
            this.dtpNTP.Name = "dtpNTP";
            this.dtpNTP.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F);
            this.dtpNTP.Properties.Appearance.Options.UseFont = true;
            this.dtpNTP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNTP.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNTP.Size = new System.Drawing.Size(297, 22);
            this.dtpNTP.TabIndex = 283;
            // 
            // dtpDelivery
            // 
            this.dtpDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDelivery.EditValue = null;
            this.dtpDelivery.Location = new System.Drawing.Point(1006, 484);
            this.dtpDelivery.Name = "dtpDelivery";
            this.dtpDelivery.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F);
            this.dtpDelivery.Properties.Appearance.Options.UseFont = true;
            this.dtpDelivery.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDelivery.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDelivery.Size = new System.Drawing.Size(297, 22);
            this.dtpDelivery.TabIndex = 285;
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl11.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(928, 487);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(72, 16);
            this.labelControl11.TabIndex = 284;
            this.labelControl11.Text = "Delivery:";
            // 
            // barManagerGridProc
            // 
            this.barManagerGridProc.DockControls.Add(this.barDockControlTop);
            this.barManagerGridProc.DockControls.Add(this.barDockControlBottom);
            this.barManagerGridProc.DockControls.Add(this.barDockControlLeft);
            this.barManagerGridProc.DockControls.Add(this.barDockControlRight);
            this.barManagerGridProc.Form = this;
            this.barManagerGridProc.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAddSupplier,
            this.btnEditSupplier,
            this.tsDelete,
            this.btnRefresh,
            this.barButtonItem1,
            this.btnAddProc,
            this.btnEditProc,
            this.btnChangeStatus,
            this.btnpreproc,
            this.btnposting,
            this.btnprebid,
            this.btnDetails});
            this.barManagerGridProc.MaxItemId = 12;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1315, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 684);
            this.barDockControlBottom.Size = new System.Drawing.Size(1315, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 684);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1315, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 684);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Caption = "Add Supplier";
            this.btnAddSupplier.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddSupplier.Glyph")));
            this.btnAddSupplier.Id = 0;
            this.btnAddSupplier.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddSupplier.LargeGlyph")));
            this.btnAddSupplier.Name = "btnAddSupplier";
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Caption = "Edit Supplier";
            this.btnEditSupplier.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditSupplier.Glyph")));
            this.btnEditSupplier.Id = 1;
            this.btnEditSupplier.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditSupplier.LargeGlyph")));
            this.btnEditSupplier.LargeGlyphDisabled = ((System.Drawing.Image)(resources.GetObject("btnEditSupplier.LargeGlyphDisabled")));
            this.btnEditSupplier.Name = "btnEditSupplier";
            // 
            // tsDelete
            // 
            this.tsDelete.Caption = "Delete";
            this.tsDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("tsDelete.Glyph")));
            this.tsDelete.Id = 2;
            this.tsDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsDelete.LargeGlyph")));
            this.tsDelete.Name = "tsDelete";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh Table";
            this.btnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Glyph")));
            this.btnRefresh.Id = 3;
            this.btnRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.LargeGlyph")));
            this.btnRefresh.Name = "btnRefresh";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Sync CA_type from FITTSys";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnAddProc
            // 
            this.btnAddProc.Caption = "Add Procurement";
            this.btnAddProc.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddProc.Glyph")));
            this.btnAddProc.Id = 5;
            this.btnAddProc.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddProc.LargeGlyph")));
            this.btnAddProc.Name = "btnAddProc";
            this.btnAddProc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddProc_ItemClick);
            // 
            // btnEditProc
            // 
            this.btnEditProc.Caption = "Edit Procurement";
            this.btnEditProc.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditProc.Glyph")));
            this.btnEditProc.Id = 6;
            this.btnEditProc.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditProc.LargeGlyph")));
            this.btnEditProc.Name = "btnEditProc";
            this.btnEditProc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditProc_ItemClick);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Caption = "Change Status";
            this.btnChangeStatus.Glyph = ((System.Drawing.Image)(resources.GetObject("btnChangeStatus.Glyph")));
            this.btnChangeStatus.Id = 7;
            this.btnChangeStatus.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnChangeStatus.LargeGlyph")));
            this.btnChangeStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnpreproc),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnposting),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnprebid)});
            this.btnChangeStatus.Name = "btnChangeStatus";
            // 
            // btnpreproc
            // 
            this.btnpreproc.Caption = "Pre-Procurement";
            this.btnpreproc.Glyph = ((System.Drawing.Image)(resources.GetObject("btnpreproc.Glyph")));
            this.btnpreproc.Id = 8;
            this.btnpreproc.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnpreproc.LargeGlyph")));
            this.btnpreproc.Name = "btnpreproc";
            // 
            // btnposting
            // 
            this.btnposting.Caption = "Posting";
            this.btnposting.Glyph = ((System.Drawing.Image)(resources.GetObject("btnposting.Glyph")));
            this.btnposting.Id = 9;
            this.btnposting.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnposting.LargeGlyph")));
            this.btnposting.Name = "btnposting";
            this.btnposting.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnposting_ItemClick);
            // 
            // btnprebid
            // 
            this.btnprebid.Caption = "Pre-Bidding";
            this.btnprebid.Glyph = ((System.Drawing.Image)(resources.GetObject("btnprebid.Glyph")));
            this.btnprebid.Id = 10;
            this.btnprebid.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnprebid.LargeGlyph")));
            this.btnprebid.Name = "btnprebid";
            this.btnprebid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnprebid_ItemClick);
            // 
            // btnDetails
            // 
            this.btnDetails.Caption = "Procurement Details";
            this.btnDetails.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDetails.Glyph")));
            this.btnDetails.Id = 11;
            this.btnDetails.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDetails.LargeGlyph")));
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetails_ItemClick);
            // 
            // popupMenuGridParent
            // 
            this.popupMenuGridParent.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.Caption | DevExpress.XtraBars.BarLinkUserDefines.PaintStyle))), this.btnAddProc, "Add Procurement", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditProc),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChangeStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDetails)});
            this.popupMenuGridParent.Manager = this.barManagerGridProc;
            this.popupMenuGridParent.Name = "popupMenuGridParent";
            // 
            // txtEnduser
            // 
            this.txtEnduser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnduser.Location = new System.Drawing.Point(942, 163);
            this.txtEnduser.Name = "txtEnduser";
            this.txtEnduser.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnduser.Properties.Appearance.Options.UseFont = true;
            this.txtEnduser.Size = new System.Drawing.Size(361, 22);
            this.txtEnduser.TabIndex = 268;
            // 
            // labelControl12
            // 
            this.labelControl12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl12.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Location = new System.Drawing.Point(864, 166);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(72, 16);
            this.labelControl12.TabIndex = 290;
            this.labelControl12.Text = "End User:";
            // 
            // gcProcDetails
            // 
            this.gcProcDetails.Controls.Add(this.labelControl19);
            this.gcProcDetails.Controls.Add(this.lblProcurementNo);
            this.gcProcDetails.Controls.Add(this.btnSaveExit);
            this.gcProcDetails.Controls.Add(this.btnDeleteItem);
            this.gcProcDetails.Controls.Add(this.btnAddItem);
            this.gcProcDetails.Controls.Add(this.txtUnitCost);
            this.gcProcDetails.Controls.Add(this.labelControl18);
            this.gcProcDetails.Controls.Add(this.txtQuantity);
            this.gcProcDetails.Controls.Add(this.labelControl17);
            this.gcProcDetails.Controls.Add(this.txtItemDescription);
            this.gcProcDetails.Controls.Add(this.labelControl16);
            this.gcProcDetails.Controls.Add(this.txtUnit);
            this.gcProcDetails.Controls.Add(this.labelControl15);
            this.gcProcDetails.Controls.Add(this.labelControl14);
            this.gcProcDetails.Controls.Add(this.txtPropertyNo);
            this.gcProcDetails.Controls.Add(this.labelControl13);
            this.gcProcDetails.Controls.Add(this.dtItemDetails);
            this.gcProcDetails.Location = new System.Drawing.Point(179, 69);
            this.gcProcDetails.Name = "gcProcDetails";
            this.gcProcDetails.Size = new System.Drawing.Size(939, 555);
            this.gcProcDetails.TabIndex = 295;
            this.gcProcDetails.Text = "Procurement Details";
            this.gcProcDetails.Visible = false;
            // 
            // labelControl19
            // 
            this.labelControl19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl19.Appearance.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Location = new System.Drawing.Point(9, 24);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(133, 13);
            this.labelControl19.TabIndex = 309;
            this.labelControl19.Text = "Procurement Number:";
            // 
            // lblProcurementNo
            // 
            this.lblProcurementNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProcurementNo.Appearance.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcurementNo.Location = new System.Drawing.Point(148, 24);
            this.lblProcurementNo.Name = "lblProcurementNo";
            this.lblProcurementNo.Size = new System.Drawing.Size(63, 13);
            this.lblProcurementNo.TabIndex = 308;
            this.lblProcurementNo.Text = "0000-0000";
            // 
            // btnSaveExit
            // 
            this.btnSaveExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveExit.Appearance.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveExit.Appearance.Options.UseFont = true;
            this.btnSaveExit.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveExit.Image")));
            this.btnSaveExit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnSaveExit.Location = new System.Drawing.Point(750, 28);
            this.btnSaveExit.Name = "btnSaveExit";
            this.btnSaveExit.Size = new System.Drawing.Size(184, 39);
            this.btnSaveExit.TabIndex = 307;
            this.btnSaveExit.Text = "Save and Exit";
            this.btnSaveExit.Click += new System.EventHandler(this.btnSaveExit_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteItem.Appearance.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Appearance.Options.UseFont = true;
            this.btnDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteItem.Image")));
            this.btnDeleteItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnDeleteItem.Location = new System.Drawing.Point(833, 511);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(101, 39);
            this.btnDeleteItem.TabIndex = 306;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.Appearance.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Appearance.Options.UseFont = true;
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnAddItem.Location = new System.Drawing.Point(833, 463);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(101, 39);
            this.btnAddItem.TabIndex = 305;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnitCost.Location = new System.Drawing.Point(401, 421);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitCost.Properties.Appearance.Options.UseFont = true;
            this.txtUnitCost.Properties.Mask.EditMask = "n2";
            this.txtUnitCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtUnitCost.Size = new System.Drawing.Size(233, 22);
            this.txtUnitCost.TabIndex = 304;
            // 
            // labelControl18
            // 
            this.labelControl18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl18.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Location = new System.Drawing.Point(315, 424);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(80, 16);
            this.labelControl18.TabIndex = 303;
            this.labelControl18.Text = "Unit Cost:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Location = new System.Drawing.Point(401, 383);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Properties.Appearance.Options.UseFont = true;
            this.txtQuantity.Properties.Mask.EditMask = "d";
            this.txtQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantity.Size = new System.Drawing.Size(233, 22);
            this.txtQuantity.TabIndex = 302;
            // 
            // labelControl17
            // 
            this.labelControl17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl17.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Location = new System.Drawing.Point(323, 386);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(72, 16);
            this.labelControl17.TabIndex = 301;
            this.labelControl17.Text = "Quantity:";
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemDescription.Location = new System.Drawing.Point(148, 459);
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemDescription.Properties.Appearance.Options.UseFont = true;
            this.txtItemDescription.Size = new System.Drawing.Size(486, 79);
            this.txtItemDescription.TabIndex = 300;
            // 
            // labelControl16
            // 
            this.labelControl16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl16.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Location = new System.Drawing.Point(6, 460);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(136, 16);
            this.labelControl16.TabIndex = 299;
            this.labelControl16.Text = "Item Description:";
            // 
            // txtUnit
            // 
            this.txtUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnit.Location = new System.Drawing.Point(148, 421);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Properties.Appearance.Options.UseFont = true;
            this.txtUnit.Size = new System.Drawing.Size(158, 22);
            this.txtUnit.TabIndex = 298;
            // 
            // labelControl15
            // 
            this.labelControl15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl15.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Location = new System.Drawing.Point(102, 424);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(40, 16);
            this.labelControl15.TabIndex = 297;
            this.labelControl15.Text = "Unit:";
            // 
            // labelControl14
            // 
            this.labelControl14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl14.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Location = new System.Drawing.Point(46, 386);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(96, 16);
            this.labelControl14.TabIndex = 296;
            this.labelControl14.Text = "Property No:";
            // 
            // txtPropertyNo
            // 
            this.txtPropertyNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPropertyNo.Location = new System.Drawing.Point(148, 383);
            this.txtPropertyNo.Name = "txtPropertyNo";
            this.txtPropertyNo.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyNo.Properties.Appearance.Options.UseFont = true;
            this.txtPropertyNo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPropertyNo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPropertyNo.Size = new System.Drawing.Size(158, 22);
            this.txtPropertyNo.TabIndex = 296;
            // 
            // labelControl13
            // 
            this.labelControl13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl13.Appearance.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(9, 50);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(91, 13);
            this.labelControl13.TabIndex = 296;
            this.labelControl13.Text = "Item Details:";
            // 
            // dtItemDetails
            // 
            this.dtItemDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtItemDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtItemDetails.Location = new System.Drawing.Point(15, 73);
            this.dtItemDetails.MainView = this.gvItemDetails;
            this.dtItemDetails.Name = "dtItemDetails";
            this.dtItemDetails.Size = new System.Drawing.Size(919, 304);
            this.dtItemDetails.TabIndex = 263;
            this.dtItemDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvItemDetails});
            // 
            // gvItemDetails
            // 
            this.gvItemDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.property_no,
            this.ItemDescription,
            this.Unit,
            this.Cost,
            this.pr,
            this.Quantity,
            this.Total});
            this.gvItemDetails.GridControl = this.dtItemDetails;
            this.gvItemDetails.Name = "gvItemDetails";
            this.gvItemDetails.OptionsBehavior.Editable = false;
            this.gvItemDetails.OptionsFind.AlwaysVisible = true;
            this.gvItemDetails.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvItemDetails.OptionsView.RowAutoHeight = true;
            this.gvItemDetails.OptionsView.ShowGroupPanel = false;
            this.gvItemDetails.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "id";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // property_no
            // 
            this.property_no.Caption = "Property No.";
            this.property_no.FieldName = "property_no";
            this.property_no.Name = "property_no";
            this.property_no.Visible = true;
            this.property_no.VisibleIndex = 0;
            this.property_no.Width = 150;
            // 
            // ItemDescription
            // 
            this.ItemDescription.Caption = "Description";
            this.ItemDescription.FieldName = "description";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.Visible = true;
            this.ItemDescription.VisibleIndex = 2;
            this.ItemDescription.Width = 125;
            // 
            // Unit
            // 
            this.Unit.Caption = "Unit";
            this.Unit.FieldName = "unit";
            this.Unit.Name = "Unit";
            this.Unit.Visible = true;
            this.Unit.VisibleIndex = 1;
            this.Unit.Width = 85;
            // 
            // Cost
            // 
            this.Cost.Caption = "Unit Cost";
            this.Cost.DisplayFormat.FormatString = "n2";
            this.Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Cost.FieldName = "unit_cost";
            this.Cost.Name = "Cost";
            this.Cost.Visible = true;
            this.Cost.VisibleIndex = 3;
            // 
            // pr
            // 
            this.pr.Caption = "PR No.";
            this.pr.FieldName = "pr_no";
            this.pr.Name = "pr";
            this.pr.Width = 54;
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Quantity";
            this.Quantity.FieldName = "quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 4;
            this.Quantity.Width = 173;
            // 
            // Total
            // 
            this.Total.Caption = "Total Cost";
            this.Total.DisplayFormat.FormatString = "n2";
            this.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Total.FieldName = "total_cost";
            this.Total.Name = "Total";
            this.Total.Visible = true;
            this.Total.VisibleIndex = 5;
            // 
            // labelControl20
            // 
            this.labelControl20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl20.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Location = new System.Drawing.Point(936, 514);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(64, 16);
            this.labelControl20.TabIndex = 300;
            this.labelControl20.Text = "Purpose:";
            // 
            // txtPurpose
            // 
            this.txtPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPurpose.Location = new System.Drawing.Point(1006, 512);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurpose.Properties.Appearance.Options.UseFont = true;
            this.txtPurpose.Size = new System.Drawing.Size(299, 91);
            this.txtPurpose.TabIndex = 301;
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 684);
            this.Controls.Add(this.gcProcDetails);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.txtEnduser);
            this.Controls.Add(this.dtpDelivery);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.dtpNTP);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.dtpPO);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.dtpAward);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.dtpEval);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.dtpBids);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.cmbMode);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtABC);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtPRmode);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtProcNo);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.dtPurchase);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPurpose);
            this.Controls.Add(this.labelControl20);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchaseForm";
            this.Text = "Purchase";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.PurchaseForm_Shown_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPRmode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtABC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBids.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBids.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEval.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEval.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpAward.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpAward.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPO.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNTP.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNTP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDelivery.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDelivery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerGridProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGridParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnduser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProcDetails)).EndInit();
            this.gcProcDetails.ResumeLayout(false);
            this.gcProcDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPropertyNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtItemDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurpose.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtPurchase;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn description;
        private DevExpress.XtraEditors.SimpleButton btnMode;
        private DevExpress.XtraEditors.TextEdit txtProcNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.ComponentModel.BackgroundWorker bwViewSupplierList;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.ComponentModel.BackgroundWorker bwViewProcurementList;
        private System.ComponentModel.BackgroundWorker bwPurchase;
        private DevExpress.XtraGrid.Columns.GridColumn pre_proc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPRmode;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtABC;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cmbMode;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dtpBids;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit dtpEval;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.DateEdit dtpAward;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.DateEdit dtpPO;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.DateEdit dtpNTP;
        private DevExpress.XtraEditors.DateEdit dtpDelivery;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraGrid.Columns.GridColumn pr_no;
        private DevExpress.XtraGrid.Columns.GridColumn end_user;
        private DevExpress.XtraGrid.Columns.GridColumn mode_of_pr;
        private DevExpress.XtraGrid.Columns.GridColumn abc;
        private DevExpress.XtraGrid.Columns.GridColumn posting;
        private DevExpress.XtraGrid.Columns.GridColumn pre_bid;
        private DevExpress.XtraGrid.Columns.GridColumn opening_of_bids;
        private DevExpress.XtraGrid.Columns.GridColumn detailed_bid_eval;
        private DevExpress.XtraGrid.Columns.GridColumn award;
        private DevExpress.XtraGrid.Columns.GridColumn po;
        private DevExpress.XtraGrid.Columns.GridColumn ntp;
        private DevExpress.XtraGrid.Columns.GridColumn delivery;
        private DevExpress.XtraBars.BarManager barManagerGridProc;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAddSupplier;
        private DevExpress.XtraBars.BarButtonItem btnEditSupplier;
        private DevExpress.XtraBars.BarButtonItem tsDelete;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnAddProc;
        private DevExpress.XtraBars.BarButtonItem btnEditProc;
        private DevExpress.XtraBars.PopupMenu popupMenuGridParent;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtEnduser;
        private DevExpress.XtraBars.BarSubItem btnChangeStatus;
        private DevExpress.XtraBars.BarButtonItem btnpreproc;
        private DevExpress.XtraBars.BarButtonItem btnposting;
        private DevExpress.XtraBars.BarButtonItem btnprebid;
        private DevExpress.XtraEditors.GroupControl gcProcDetails;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit txtUnit;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit txtPropertyNo;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraGrid.GridControl dtItemDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gvItemDetails;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn property_no;
        private DevExpress.XtraGrid.Columns.GridColumn ItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn Unit;
        private DevExpress.XtraGrid.Columns.GridColumn pr;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl lblProcurementNo;
        private DevExpress.XtraEditors.SimpleButton btnSaveExit;
        private DevExpress.XtraEditors.SimpleButton btnDeleteItem;
        private DevExpress.XtraEditors.SimpleButton btnAddItem;
        private DevExpress.XtraEditors.TextEdit txtUnitCost;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.MemoEdit txtItemDescription;
        private DevExpress.XtraEditors.MemoEdit txtPurpose;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraBars.BarButtonItem btnDetails;
        private DevExpress.XtraGrid.Columns.GridColumn Cost;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
    }
}
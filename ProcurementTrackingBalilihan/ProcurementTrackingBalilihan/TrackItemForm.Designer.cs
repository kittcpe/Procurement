namespace ProcurementTrackingBalilihan
{
    partial class TrackItemForm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackItemForm));
            this.dtTrack = new DevExpress.XtraGrid.GridControl();
            this.gvTrack = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.gcProcDetails = new DevExpress.XtraEditors.GroupControl();
            this.btnSaveExit = new DevExpress.XtraEditors.SimpleButton();
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
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.lblProcurementNo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.popupMenuGridParent = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnprocdet = new DevExpress.XtraBars.BarButtonItem();
            this.barManagerGridProc = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.supplier = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProcDetails)).BeginInit();
            this.gcProcDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtItemDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGridParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerGridProc)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTrack
            // 
            this.dtTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTrack.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtTrack.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode1.RelationName = "Level1";
            this.dtTrack.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dtTrack.Location = new System.Drawing.Point(14, 15);
            this.dtTrack.MainView = this.gvTrack;
            this.dtTrack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtTrack.Name = "dtTrack";
            this.dtTrack.Size = new System.Drawing.Size(1292, 682);
            this.dtTrack.TabIndex = 263;
            this.dtTrack.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTrack});
            this.dtTrack.Load += new System.EventHandler(this.dtTrack_Load);
            this.dtTrack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtTrack_MouseClick);
            // 
            // gvTrack
            // 
            this.gvTrack.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gvTrack.GridControl = this.dtTrack;
            this.gvTrack.Name = "gvTrack";
            this.gvTrack.OptionsBehavior.Editable = false;
            this.gvTrack.OptionsFind.AlwaysVisible = true;
            this.gvTrack.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvTrack.OptionsView.RowAutoHeight = true;
            this.gvTrack.OptionsView.ShowGroupPanel = false;
            this.gvTrack.OptionsView.ShowIndicator = false;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // pr_no
            // 
            this.pr_no.Caption = "PR no.";
            this.pr_no.FieldName = "pr_no";
            this.pr_no.Name = "pr_no";
            this.pr_no.Visible = true;
            this.pr_no.VisibleIndex = 0;
            this.pr_no.Width = 73;
            // 
            // description
            // 
            this.description.Caption = "Description";
            this.description.FieldName = "description";
            this.description.Name = "description";
            this.description.Visible = true;
            this.description.VisibleIndex = 1;
            this.description.Width = 151;
            // 
            // end_user
            // 
            this.end_user.Caption = "End User";
            this.end_user.FieldName = "end_user";
            this.end_user.Name = "end_user";
            this.end_user.Visible = true;
            this.end_user.VisibleIndex = 2;
            this.end_user.Width = 104;
            // 
            // mode_of_pr
            // 
            this.mode_of_pr.Caption = "Mode Of PR";
            this.mode_of_pr.FieldName = "mode_of_pr";
            this.mode_of_pr.Name = "mode_of_pr";
            this.mode_of_pr.Visible = true;
            this.mode_of_pr.VisibleIndex = 3;
            this.mode_of_pr.Width = 92;
            // 
            // abc
            // 
            this.abc.Caption = "Amount";
            this.abc.FieldName = "abc";
            this.abc.Name = "abc";
            this.abc.Visible = true;
            this.abc.VisibleIndex = 4;
            this.abc.Width = 85;
            // 
            // pre_proc
            // 
            this.pre_proc.Caption = "Pre-Proc";
            this.pre_proc.FieldName = "pre_proc";
            this.pre_proc.Name = "pre_proc";
            this.pre_proc.Visible = true;
            this.pre_proc.VisibleIndex = 5;
            this.pre_proc.Width = 85;
            // 
            // posting
            // 
            this.posting.Caption = "Posting";
            this.posting.FieldName = "posting";
            this.posting.Name = "posting";
            this.posting.Visible = true;
            this.posting.VisibleIndex = 6;
            this.posting.Width = 85;
            // 
            // pre_bid
            // 
            this.pre_bid.Caption = "Pre-Bid";
            this.pre_bid.FieldName = "pre_bid";
            this.pre_bid.Name = "pre_bid";
            this.pre_bid.Visible = true;
            this.pre_bid.VisibleIndex = 7;
            this.pre_bid.Width = 85;
            // 
            // opening_of_bids
            // 
            this.opening_of_bids.Caption = "Opening of Bids";
            this.opening_of_bids.FieldName = "opening_of_bids";
            this.opening_of_bids.Name = "opening_of_bids";
            this.opening_of_bids.Visible = true;
            this.opening_of_bids.VisibleIndex = 8;
            this.opening_of_bids.Width = 85;
            // 
            // detailed_bid_eval
            // 
            this.detailed_bid_eval.Caption = "Detailed Bid Eval";
            this.detailed_bid_eval.FieldName = "detailed_bid_eval";
            this.detailed_bid_eval.Name = "detailed_bid_eval";
            this.detailed_bid_eval.Visible = true;
            this.detailed_bid_eval.VisibleIndex = 9;
            this.detailed_bid_eval.Width = 85;
            // 
            // award
            // 
            this.award.Caption = "Award";
            this.award.FieldName = "award";
            this.award.Name = "award";
            this.award.Visible = true;
            this.award.VisibleIndex = 10;
            this.award.Width = 85;
            // 
            // po
            // 
            this.po.Caption = "PO";
            this.po.FieldName = "po";
            this.po.Name = "po";
            this.po.Visible = true;
            this.po.VisibleIndex = 11;
            this.po.Width = 85;
            // 
            // ntp
            // 
            this.ntp.Caption = "NTP";
            this.ntp.FieldName = "ntp";
            this.ntp.Name = "ntp";
            this.ntp.Visible = true;
            this.ntp.VisibleIndex = 12;
            this.ntp.Width = 85;
            // 
            // delivery
            // 
            this.delivery.Caption = "Delivery";
            this.delivery.FieldName = "delivery";
            this.delivery.Name = "delivery";
            this.delivery.Visible = true;
            this.delivery.VisibleIndex = 13;
            this.delivery.Width = 105;
            // 
            // gcProcDetails
            // 
            this.gcProcDetails.Controls.Add(this.btnSaveExit);
            this.gcProcDetails.Controls.Add(this.dtItemDetails);
            this.gcProcDetails.Controls.Add(this.labelControl19);
            this.gcProcDetails.Controls.Add(this.lblProcurementNo);
            this.gcProcDetails.Controls.Add(this.labelControl13);
            this.gcProcDetails.Location = new System.Drawing.Point(90, 26);
            this.gcProcDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcProcDetails.Name = "gcProcDetails";
            this.gcProcDetails.Size = new System.Drawing.Size(1095, 601);
            this.gcProcDetails.TabIndex = 296;
            this.gcProcDetails.Text = "Procurement Details";
            this.gcProcDetails.Visible = false;
            // 
            // btnSaveExit
            // 
            this.btnSaveExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveExit.Appearance.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveExit.Appearance.Options.UseFont = true;
            this.btnSaveExit.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveExit.Image")));
            this.btnSaveExit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnSaveExit.Location = new System.Drawing.Point(874, 30);
            this.btnSaveExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveExit.Name = "btnSaveExit";
            this.btnSaveExit.Size = new System.Drawing.Size(215, 48);
            this.btnSaveExit.TabIndex = 310;
            this.btnSaveExit.Text = "Exit";
            this.btnSaveExit.Click += new System.EventHandler(this.btnSaveExit_Click);
            // 
            // dtItemDetails
            // 
            this.dtItemDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtItemDetails.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtItemDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtItemDetails.Location = new System.Drawing.Point(17, 86);
            this.dtItemDetails.MainView = this.gvItemDetails;
            this.dtItemDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtItemDetails.Name = "dtItemDetails";
            this.dtItemDetails.Size = new System.Drawing.Size(1072, 513);
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
            this.Total,
            this.supplier});
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
            // labelControl19
            // 
            this.labelControl19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl19.Appearance.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Location = new System.Drawing.Point(10, 30);
            this.labelControl19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(152, 16);
            this.labelControl19.TabIndex = 309;
            this.labelControl19.Text = "Procurement Number:";
            // 
            // lblProcurementNo
            // 
            this.lblProcurementNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProcurementNo.Appearance.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcurementNo.Location = new System.Drawing.Point(173, 30);
            this.lblProcurementNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblProcurementNo.Name = "lblProcurementNo";
            this.lblProcurementNo.Size = new System.Drawing.Size(72, 16);
            this.lblProcurementNo.TabIndex = 308;
            this.lblProcurementNo.Text = "0000-0000";
            // 
            // labelControl13
            // 
            this.labelControl13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl13.Appearance.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(10, 62);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(104, 16);
            this.labelControl13.TabIndex = 296;
            this.labelControl13.Text = "Item Details:";
            // 
            // popupMenuGridParent
            // 
            this.popupMenuGridParent.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnprocdet)});
            this.popupMenuGridParent.Manager = this.barManagerGridProc;
            this.popupMenuGridParent.Name = "popupMenuGridParent";
            // 
            // btnprocdet
            // 
            this.btnprocdet.Caption = "Procurement Details";
            this.btnprocdet.Glyph = ((System.Drawing.Image)(resources.GetObject("btnprocdet.Glyph")));
            this.btnprocdet.Id = 0;
            this.btnprocdet.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnprocdet.LargeGlyph")));
            this.btnprocdet.Name = "btnprocdet";
            this.btnprocdet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnprocdet_ItemClick);
            // 
            // barManagerGridProc
            // 
            this.barManagerGridProc.DockControls.Add(this.barDockControlTop);
            this.barManagerGridProc.DockControls.Add(this.barDockControlBottom);
            this.barManagerGridProc.DockControls.Add(this.barDockControlLeft);
            this.barManagerGridProc.DockControls.Add(this.barDockControlRight);
            this.barManagerGridProc.Form = this;
            this.barManagerGridProc.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnprocdet});
            this.barManagerGridProc.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1320, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 712);
            this.barDockControlBottom.Size = new System.Drawing.Size(1320, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 712);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1320, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 712);
            // 
            // supplier
            // 
            this.supplier.Caption = "Supplier";
            this.supplier.FieldName = "supplier";
            this.supplier.Name = "supplier";
            this.supplier.Visible = true;
            this.supplier.VisibleIndex = 6;
            // 
            // TrackItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 712);
            this.Controls.Add(this.gcProcDetails);
            this.Controls.Add(this.dtTrack);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TrackItemForm";
            this.Text = "TrackItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProcDetails)).EndInit();
            this.gcProcDetails.ResumeLayout(false);
            this.gcProcDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtItemDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGridParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerGridProc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtTrack;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTrack;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn pr_no;
        private DevExpress.XtraGrid.Columns.GridColumn description;
        private DevExpress.XtraGrid.Columns.GridColumn end_user;
        private DevExpress.XtraGrid.Columns.GridColumn mode_of_pr;
        private DevExpress.XtraGrid.Columns.GridColumn abc;
        private DevExpress.XtraGrid.Columns.GridColumn pre_proc;
        private DevExpress.XtraGrid.Columns.GridColumn posting;
        private DevExpress.XtraGrid.Columns.GridColumn pre_bid;
        private DevExpress.XtraGrid.Columns.GridColumn opening_of_bids;
        private DevExpress.XtraGrid.Columns.GridColumn detailed_bid_eval;
        private DevExpress.XtraGrid.Columns.GridColumn award;
        private DevExpress.XtraGrid.Columns.GridColumn po;
        private DevExpress.XtraGrid.Columns.GridColumn ntp;
        private DevExpress.XtraGrid.Columns.GridColumn delivery;
        private DevExpress.XtraEditors.GroupControl gcProcDetails;
        private DevExpress.XtraGrid.GridControl dtItemDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gvItemDetails;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn property_no;
        private DevExpress.XtraGrid.Columns.GridColumn ItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn Unit;
        private DevExpress.XtraGrid.Columns.GridColumn Cost;
        private DevExpress.XtraGrid.Columns.GridColumn pr;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl lblProcurementNo;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraBars.PopupMenu popupMenuGridParent;
        private DevExpress.XtraBars.BarButtonItem btnprocdet;
        private DevExpress.XtraBars.BarManager barManagerGridProc;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton btnSaveExit;
        private DevExpress.XtraGrid.Columns.GridColumn supplier;

    }
}
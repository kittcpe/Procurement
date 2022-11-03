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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseForm));
            this.dtPurchase = new DevExpress.XtraGrid.GridControl();
            this.gvSupplier = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sl_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.added_on = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.cmbSupplier = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbstatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bwViewSupplierList = new System.ComponentModel.BackgroundWorker();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::SAMPLE_MEMO_NOTIF.WaitForm1), true, true);
            this.bwViewProcurementList = new System.ComponentModel.BackgroundWorker();
            this.bwPurchase = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dtPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbstatus.Properties)).BeginInit();
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
            this.dtPurchase.Size = new System.Drawing.Size(422, 480);
            this.dtPurchase.TabIndex = 262;
            this.dtPurchase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSupplier});
            this.dtPurchase.DoubleClick += new System.EventHandler(this.dtPurchase_DoubleClick);
            this.dtPurchase.MouseEnter += new System.EventHandler(this.dtPurchase_MouseEnter);
            // 
            // gvSupplier
            // 
            this.gvSupplier.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.description,
            this.Amount,
            this.sl_name,
            this.status,
            this.added_on,
            this.gridColumn2});
            this.gvSupplier.GridControl = this.dtPurchase;
            this.gvSupplier.Name = "gvSupplier";
            this.gvSupplier.OptionsBehavior.Editable = false;
            this.gvSupplier.OptionsFind.AlwaysVisible = true;
            this.gvSupplier.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSupplier.OptionsView.RowAutoHeight = true;
            this.gvSupplier.OptionsView.ShowGroupPanel = false;
            this.gvSupplier.OptionsView.ShowIndicator = false;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // description
            // 
            this.description.Caption = "Description";
            this.description.FieldName = "description";
            this.description.Name = "description";
            this.description.Visible = true;
            this.description.VisibleIndex = 0;
            // 
            // Amount
            // 
            this.Amount.Caption = "Amount";
            this.Amount.FieldName = "amount";
            this.Amount.Name = "Amount";
            this.Amount.Visible = true;
            this.Amount.VisibleIndex = 1;
            // 
            // sl_name
            // 
            this.sl_name.Caption = "Supplier";
            this.sl_name.FieldName = "name";
            this.sl_name.Name = "sl_name";
            this.sl_name.Visible = true;
            this.sl_name.VisibleIndex = 2;
            // 
            // status
            // 
            this.status.Caption = "Status";
            this.status.FieldName = "status";
            this.status.Name = "status";
            this.status.Visible = true;
            this.status.VisibleIndex = 3;
            // 
            // added_on
            // 
            this.added_on.Caption = "Date Purchased";
            this.added_on.FieldName = "added_on";
            this.added_on.Name = "added_on";
            this.added_on.Visible = true;
            this.added_on.VisibleIndex = 4;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "id";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnLogin.Location = new System.Drawing.Point(780, 439);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(123, 53);
            this.btnLogin.TabIndex = 263;
            this.btnLogin.Text = "Purchase";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(542, 27);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Size = new System.Drawing.Size(361, 22);
            this.txtDescription.TabIndex = 264;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(440, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 16);
            this.labelControl1.TabIndex = 265;
            this.labelControl1.Text = "Description:";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(480, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 16);
            this.labelControl2.TabIndex = 266;
            this.labelControl2.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Location = new System.Drawing.Point(542, 61);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Properties.Appearance.Options.UseFont = true;
            this.txtAmount.Size = new System.Drawing.Size(361, 22);
            this.txtAmount.TabIndex = 267;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSupplier.EditValue = "-- Select File Category --";
            this.cmbSupplier.Location = new System.Drawing.Point(542, 99);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.Properties.Appearance.Options.UseFont = true;
            this.cmbSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSupplier.Properties.NullText = "-- Select Supplier --";
            this.cmbSupplier.Properties.View = this.searchLookUpEdit1View;
            this.cmbSupplier.Size = new System.Drawing.Size(361, 22);
            this.cmbSupplier.TabIndex = 302;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.name});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "id";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // name
            // 
            this.name.Caption = "Category";
            this.name.FieldName = "name";
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(464, 102);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 16);
            this.labelControl3.TabIndex = 303;
            this.labelControl3.Text = "Supplier:";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(480, 138);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 16);
            this.labelControl4.TabIndex = 304;
            this.labelControl4.Text = "Status:";
            // 
            // cmbstatus
            // 
            this.cmbstatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbstatus.Location = new System.Drawing.Point(543, 135);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Properties.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstatus.Properties.Appearance.Options.UseFont = true;
            this.cmbstatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbstatus.Properties.Items.AddRange(new object[] {
            "To Ship",
            "To Receive",
            "Received"});
            this.cmbstatus.Properties.NullText = "-- Select Status --";
            this.cmbstatus.Size = new System.Drawing.Size(360, 22);
            this.cmbstatus.TabIndex = 305;
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
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 504);
            this.Controls.Add(this.cmbstatus);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.dtPurchase);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchaseForm";
            this.Text = "Purchase";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.PurchaseForm_Shown_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbstatus.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtPurchase;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn description;
        private DevExpress.XtraGrid.Columns.GridColumn Amount;
        private DevExpress.XtraGrid.Columns.GridColumn sl_name;
        private DevExpress.XtraGrid.Columns.GridColumn status;
        private DevExpress.XtraGrid.Columns.GridColumn added_on;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cmbstatus;
        private System.ComponentModel.BackgroundWorker bwViewSupplierList;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.ComponentModel.BackgroundWorker bwViewProcurementList;
        private System.ComponentModel.BackgroundWorker bwPurchase;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}
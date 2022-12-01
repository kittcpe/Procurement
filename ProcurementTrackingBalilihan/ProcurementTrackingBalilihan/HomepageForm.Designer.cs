namespace ProcurementTrackingBalilihan
{
    partial class HomepageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSupplier = new DevExpress.XtraBars.BarButtonItem();
            this.btnPurchase = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrackItem = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.rpHomepage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.btnSuppliers = new DevExpress.XtraBars.BarButtonItem();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.BackColor = System.Drawing.Color.DodgerBlue;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnSupplier,
            this.btnPurchase,
            this.btnTrackItem,
            this.btnLogout,
            this.barButtonItem1,
            this.btnPrint});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.barButtonItem1);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpHomepage});
            this.ribbon.Size = new System.Drawing.Size(1095, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnSupplier
            // 
            this.btnSupplier.Caption = "Suppliers";
            this.btnSupplier.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSupplier.Glyph")));
            this.btnSupplier.Id = 1;
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSupplier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSupplier_ItemClick);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Caption = "Purchase";
            this.btnPurchase.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPurchase.Glyph")));
            this.btnPurchase.Id = 2;
            this.btnPurchase.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPurchase.LargeGlyph")));
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPurchase.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPurchase_ItemClick);
            // 
            // btnTrackItem
            // 
            this.btnTrackItem.Caption = "Track Item";
            this.btnTrackItem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTrackItem.Glyph")));
            this.btnTrackItem.Id = 3;
            this.btnTrackItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTrackItem.LargeGlyph")));
            this.btnTrackItem.Name = "btnTrackItem";
            this.btnTrackItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTrackItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTrackItem_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Logout";
            this.btnLogout.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLogout.Glyph")));
            this.btnLogout.Id = 4;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Logout [user]";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "Print";
            this.btnPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPrint.Glyph")));
            this.btnPrint.Id = 3;
            this.btnPrint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPrint.LargeGlyph")));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // rpHomepage
            // 
            this.rpHomepage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rpHomepage.Name = "rpHomepage";
            this.rpHomepage.Text = "Home Page";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSupplier);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPurchase);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTrackItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPrint);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 514);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1095, 31);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Caption = "Suppliers";
            this.btnSuppliers.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSuppliers.Glyph")));
            this.btnSuppliers.Id = 1;
            this.btnSuppliers.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSuppliers.LargeGlyph")));
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // HomepageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::ProcurementTrackingBalilihan.Properties.Resources.bg_photo;
            this.ClientSize = new System.Drawing.Size(1095, 545);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "HomepageForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "HomepageForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomepageForm_FormClosing);
            this.Shown += new System.EventHandler(this.HomepageForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpHomepage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnSuppliers;
        private DevExpress.XtraBars.BarButtonItem btnSupplier;
        private DevExpress.XtraBars.BarButtonItem btnPurchase;
        private DevExpress.XtraBars.BarButtonItem btnTrackItem;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
    }
}
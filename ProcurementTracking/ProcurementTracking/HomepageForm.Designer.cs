namespace ProcurementTracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSuppliers = new DevExpress.XtraBars.BarButtonItem();
            this.btnPurchase = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrackItem = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnSuppliers,
            this.btnPurchase,
            this.btnTrackItem,
            this.btnLogout});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1034, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
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
            // btnPurchase
            // 
            this.btnPurchase.Caption = "Purchase";
            this.btnPurchase.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPurchase.Glyph")));
            this.btnPurchase.Id = 2;
            this.btnPurchase.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPurchase.LargeGlyph")));
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnTrackItem
            // 
            this.btnTrackItem.Caption = "Track Item";
            this.btnTrackItem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTrackItem.Glyph")));
            this.btnTrackItem.Id = 3;
            this.btnTrackItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTrackItem.LargeGlyph")));
            this.btnTrackItem.Name = "btnTrackItem";
            this.btnTrackItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Logout";
            this.btnLogout.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLogout.Glyph")));
            this.btnLogout.Id = 4;
            this.btnLogout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLogout.LargeGlyph")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Homepage";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSuppliers);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPurchase);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTrackItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 515);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1034, 31);
            // 
            // HomepageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 546);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "HomepageForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "HomepageForm";
            this.Shown += new System.EventHandler(this.HomepageForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnSuppliers;
        private DevExpress.XtraBars.BarButtonItem btnPurchase;
        private DevExpress.XtraBars.BarButtonItem btnTrackItem;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
    }
}
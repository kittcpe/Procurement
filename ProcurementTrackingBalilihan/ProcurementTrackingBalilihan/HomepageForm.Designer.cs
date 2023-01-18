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
            this.applicationMenu2 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.btnSupplier = new DevExpress.XtraBars.BarButtonItem();
            this.btnPurchase = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrackItem = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.LogOutBtn = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.Appearancebtn = new DevExpress.XtraBars.BarButtonItem();
            this.UserManagementbtn = new DevExpress.XtraBars.BarButtonItem();
            this.rpHomepage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.UserManagementbr = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.btnSuppliers = new DevExpress.XtraBars.BarButtonItem();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.applicationMenu2;
            this.ribbon.BackColor = System.Drawing.Color.DodgerBlue;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnSupplier,
            this.btnPurchase,
            this.btnTrackItem,
            this.btnLogout,
            this.LogOutBtn,
            this.btnPrint,
            this.Appearancebtn,
            this.UserManagementbtn});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.LogOutBtn);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpHomepage});
            this.ribbon.Size = new System.Drawing.Size(1101, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // applicationMenu2
            // 
            this.applicationMenu2.Name = "applicationMenu2";
            this.applicationMenu2.Ribbon = this.ribbon;
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
            // LogOutBtn
            // 
            this.LogOutBtn.Caption = "Logout [user]";
            this.LogOutBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("LogOutBtn.Glyph")));
            this.LogOutBtn.Id = 2;
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.LogOutBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LogOutBtn_ItemClick);
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
            // Appearancebtn
            // 
            this.Appearancebtn.Caption = "Appearance";
            this.Appearancebtn.Id = 4;
            this.Appearancebtn.Name = "Appearancebtn";
            // 
            // UserManagementbtn
            // 
            this.UserManagementbtn.Caption = "User Management";
            this.UserManagementbtn.Glyph = ((System.Drawing.Image)(resources.GetObject("UserManagementbtn.Glyph")));
            this.UserManagementbtn.Id = 5;
            this.UserManagementbtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("UserManagementbtn.LargeGlyph")));
            this.UserManagementbtn.Name = "UserManagementbtn";
            this.UserManagementbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.UserManagementbtn_ItemClick);
            // 
            // rpHomepage
            // 
            this.rpHomepage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.UserManagementbr});
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
            // UserManagementbr
            // 
            this.UserManagementbr.ItemLinks.Add(this.UserManagementbtn);
            this.UserManagementbr.Name = "UserManagementbr";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 514);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1101, 31);
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbon;
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
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Dark Style";
            // 
            // HomepageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::ProcurementTrackingBalilihan.Properties.Resources.bg_photo;
            this.ClientSize = new System.Drawing.Size(1101, 545);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "HomepageForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Procurement Tracking";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomepageForm_FormClosed);
            this.Shown += new System.EventHandler(this.HomepageForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem LogOutBtn;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu2;
        private DevExpress.XtraBars.BarButtonItem Appearancebtn;
        private DevExpress.XtraBars.BarButtonItem UserManagementbtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup UserManagementbr;
    }
}
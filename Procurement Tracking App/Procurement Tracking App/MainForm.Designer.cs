﻿namespace Procurement_Tracking_App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnlogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnsupplier = new DevExpress.XtraBars.BarButtonItem();
            this.btnpurchase = new DevExpress.XtraBars.BarButtonItem();
            this.btnprocurementtracking = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnprint = new DevExpress.XtraBars.BarButtonItem();
            this.btnusermanagement = new DevExpress.XtraBars.BarButtonItem();
            this.btnreport = new DevExpress.XtraBars.BarButtonItem();
            this.btnmainlogout = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnlogout,
            this.btnsupplier,
            this.btnpurchase,
            this.btnprocurementtracking,
            this.barButtonItem4,
            this.btnprint,
            this.btnusermanagement,
            this.btnreport,
            this.btnmainlogout});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.btnlogout);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1004, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnlogout
            // 
            this.btnlogout.Caption = "Logout";
            this.btnlogout.Glyph = ((System.Drawing.Image)(resources.GetObject("btnlogout.Glyph")));
            this.btnlogout.Id = 1;
            this.btnlogout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnlogout.LargeGlyph")));
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnlogout_ItemClick);
            // 
            // btnsupplier
            // 
            this.btnsupplier.Caption = "Supplier";
            this.btnsupplier.Glyph = ((System.Drawing.Image)(resources.GetObject("btnsupplier.Glyph")));
            this.btnsupplier.Id = 2;
            this.btnsupplier.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnsupplier.LargeGlyph")));
            this.btnsupplier.Name = "btnsupplier";
            this.btnsupplier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsupplier_ItemClick);
            // 
            // btnpurchase
            // 
            this.btnpurchase.Caption = "Purchase";
            this.btnpurchase.Glyph = ((System.Drawing.Image)(resources.GetObject("btnpurchase.Glyph")));
            this.btnpurchase.Id = 3;
            this.btnpurchase.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnpurchase.LargeGlyph")));
            this.btnpurchase.Name = "btnpurchase";
            // 
            // btnprocurementtracking
            // 
            this.btnprocurementtracking.Caption = "Procurement Tracking";
            this.btnprocurementtracking.Glyph = ((System.Drawing.Image)(resources.GetObject("btnprocurementtracking.Glyph")));
            this.btnprocurementtracking.Id = 4;
            this.btnprocurementtracking.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnprocurementtracking.LargeGlyph")));
            this.btnprocurementtracking.Name = "btnprocurementtracking";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Report";
            this.barButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.Glyph")));
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.LargeGlyph")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnprint
            // 
            this.btnprint.Caption = "Print";
            this.btnprint.Glyph = ((System.Drawing.Image)(resources.GetObject("btnprint.Glyph")));
            this.btnprint.Id = 6;
            this.btnprint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnprint.LargeGlyph")));
            this.btnprint.Name = "btnprint";
            // 
            // btnusermanagement
            // 
            this.btnusermanagement.Caption = "User Management";
            this.btnusermanagement.Glyph = ((System.Drawing.Image)(resources.GetObject("btnusermanagement.Glyph")));
            this.btnusermanagement.Id = 7;
            this.btnusermanagement.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnusermanagement.LargeGlyph")));
            this.btnusermanagement.Name = "btnusermanagement";
            // 
            // btnreport
            // 
            this.btnreport.Caption = "Report";
            this.btnreport.Glyph = ((System.Drawing.Image)(resources.GetObject("btnreport.Glyph")));
            this.btnreport.Id = 8;
            this.btnreport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnreport.LargeGlyph")));
            this.btnreport.Name = "btnreport";
            // 
            // btnmainlogout
            // 
            this.btnmainlogout.Caption = "Logout";
            this.btnmainlogout.Glyph = ((System.Drawing.Image)(resources.GetObject("btnmainlogout.Glyph")));
            this.btnmainlogout.Id = 9;
            this.btnmainlogout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnmainlogout.LargeGlyph")));
            this.btnmainlogout.Name = "btnmainlogout";
            this.btnmainlogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnmainlogout_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnsupplier);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnpurchase);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnprint);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnusermanagement);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnreport);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnprocurementtracking);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnmainlogout);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1004, 31);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnlogout;
        private DevExpress.XtraBars.BarButtonItem btnsupplier;
        private DevExpress.XtraBars.BarButtonItem btnpurchase;
        private DevExpress.XtraBars.BarButtonItem btnprocurementtracking;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnprint;
        private DevExpress.XtraBars.BarButtonItem btnusermanagement;
        private DevExpress.XtraBars.BarButtonItem btnreport;
        private DevExpress.XtraBars.BarButtonItem btnmainlogout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}
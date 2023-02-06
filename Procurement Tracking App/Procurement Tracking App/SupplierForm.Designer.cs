namespace Procurement_Tracking_App
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
            this.dtsupplier = new DevExpress.XtraGrid.GridControl();
            this.gvsupplier = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtsupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvsupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dtsupplier
            // 
            this.dtsupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtsupplier.Location = new System.Drawing.Point(309, 12);
            this.dtsupplier.MainView = this.gvsupplier;
            this.dtsupplier.Name = "dtsupplier";
            this.dtsupplier.Size = new System.Drawing.Size(559, 463);
            this.dtsupplier.TabIndex = 0;
            this.dtsupplier.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvsupplier});
            // 
            // gvsupplier
            // 
            this.gvsupplier.GridControl = this.dtsupplier;
            this.gvsupplier.Name = "gvsupplier";
            this.gvsupplier.OptionsFind.AlwaysVisible = true;
            this.gvsupplier.OptionsFind.SearchInPreview = true;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 487);
            this.Controls.Add(this.dtsupplier);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtsupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvsupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtsupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gvsupplier;
    }
}
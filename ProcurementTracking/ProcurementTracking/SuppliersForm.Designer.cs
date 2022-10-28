namespace ProcurementTracking
{
    partial class SuppliersForm
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
            this.dtSuppliers = new DevExpress.XtraGrid.GridControl();
            this.gvSuppliers = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // dtSuppliers
            // 
            this.dtSuppliers.Location = new System.Drawing.Point(12, 12);
            this.dtSuppliers.MainView = this.gvSuppliers;
            this.dtSuppliers.Name = "dtSuppliers";
            this.dtSuppliers.Size = new System.Drawing.Size(843, 479);
            this.dtSuppliers.TabIndex = 0;
            this.dtSuppliers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSuppliers});
            // 
            // gvSuppliers
            // 
            this.gvSuppliers.GridControl = this.dtSuppliers;
            this.gvSuppliers.Name = "gvSuppliers";
            // 
            // SuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 503);
            this.Controls.Add(this.dtSuppliers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuppliersForm";
            this.Text = "SuppliersForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SuppliersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtSuppliers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSuppliers;
    }
}
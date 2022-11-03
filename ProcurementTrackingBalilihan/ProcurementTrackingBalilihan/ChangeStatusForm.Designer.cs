namespace ProcurementTrackingBalilihan
{
    partial class ChangeStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeStatusForm));
            this.cmbstatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbstatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbstatus
            // 
            this.cmbstatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbstatus.Location = new System.Drawing.Point(86, 27);
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
            this.cmbstatus.TabIndex = 307;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(23, 30);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 16);
            this.labelControl4.TabIndex = 306;
            this.labelControl4.Text = "Status:";
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnupdate.Appearance.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Appearance.Options.UseFont = true;
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnupdate.Location = new System.Drawing.Point(160, 66);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(123, 53);
            this.btnupdate.TabIndex = 308;
            this.btnupdate.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // ChangeStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 131);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.cmbstatus);
            this.Controls.Add(this.labelControl4);
            this.MinimizeBox = false;
            this.Name = "ChangeStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangeStatusForm";
            ((System.ComponentModel.ISupportInitialize)(this.cmbstatus.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbstatus;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
    }
}
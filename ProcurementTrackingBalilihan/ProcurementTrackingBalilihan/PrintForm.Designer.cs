namespace ProcurementTrackingBalilihan
{
    partial class PrintForm
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
            this.btnprint = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(497, 369);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(138, 48);
            this.btnprint.TabIndex = 0;
            this.btnprint.Text = "Print";
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 429);
            this.Controls.Add(this.btnprint);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnprint;
    }
}
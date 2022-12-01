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
            this.dtReport = new DevExpress.XtraGrid.GridControl();
            this.gvReport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stock_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unit_cost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.total_cost = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReport)).BeginInit();
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
            // dtReport
            // 
            this.dtReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtReport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReport.Location = new System.Drawing.Point(12, 44);
            this.dtReport.MainView = this.gvReport;
            this.dtReport.Name = "dtReport";
            this.dtReport.Size = new System.Drawing.Size(623, 320);
            this.dtReport.TabIndex = 262;
            this.dtReport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReport});
            // 
            // gvReport
            // 
            this.gvReport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.stock_no,
            this.unit,
            this.description,
            this.quantity,
            this.unit_cost,
            this.total_cost});
            this.gvReport.GridControl = this.dtReport;
            this.gvReport.Name = "gvReport";
            this.gvReport.OptionsBehavior.Editable = false;
            this.gvReport.OptionsFind.AlwaysVisible = true;
            this.gvReport.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvReport.OptionsView.RowAutoHeight = true;
            this.gvReport.OptionsView.ShowGroupPanel = false;
            this.gvReport.OptionsView.ShowIndicator = false;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // stock_no
            // 
            this.stock_no.Caption = "Stock/Property No.";
            this.stock_no.FieldName = "stock_no";
            this.stock_no.Name = "stock_no";
            this.stock_no.Visible = true;
            this.stock_no.VisibleIndex = 0;
            // 
            // unit
            // 
            this.unit.Caption = "Unit";
            this.unit.FieldName = "unit";
            this.unit.Name = "unit";
            this.unit.Visible = true;
            this.unit.VisibleIndex = 1;
            // 
            // description
            // 
            this.description.Caption = "Item Desciption";
            this.description.FieldName = "description";
            this.description.Name = "description";
            this.description.Visible = true;
            this.description.VisibleIndex = 2;
            // 
            // quantity
            // 
            this.quantity.Caption = "Quantity";
            this.quantity.FieldName = "quantity";
            this.quantity.Name = "quantity";
            this.quantity.Visible = true;
            this.quantity.VisibleIndex = 3;
            // 
            // unit_cost
            // 
            this.unit_cost.Caption = "Unit Cost";
            this.unit_cost.FieldName = "unit_cost";
            this.unit_cost.Name = "unit_cost";
            this.unit_cost.Visible = true;
            this.unit_cost.VisibleIndex = 4;
            // 
            // total_cost
            // 
            this.total_cost.Caption = "Total Cost";
            this.total_cost.FieldName = "total_cost";
            this.total_cost.Name = "total_cost";
            this.total_cost.Visible = true;
            this.total_cost.VisibleIndex = 5;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 429);
            this.Controls.Add(this.dtReport);
            this.Controls.Add(this.btnprint);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnprint;
        private DevExpress.XtraGrid.GridControl dtReport;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReport;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn stock_no;
        private DevExpress.XtraGrid.Columns.GridColumn unit;
        private DevExpress.XtraGrid.Columns.GridColumn description;
        private DevExpress.XtraGrid.Columns.GridColumn quantity;
        private DevExpress.XtraGrid.Columns.GridColumn unit_cost;
        private DevExpress.XtraGrid.Columns.GridColumn total_cost;
    }
}
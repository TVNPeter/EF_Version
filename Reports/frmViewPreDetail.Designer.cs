namespace EF_Version.Reports
{
    partial class frmViewPreDetail
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1 = new EF_Version.DataSet.DataSet1();
            this.dataForPrescriptionDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataForPrescriptionDetailTableAdapter = new EF_Version.DataSet.DataSet1TableAdapters.DataForPrescriptionDetailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataForPrescriptionDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataForPrescriptionDetailBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EF_Version.Reports.RpViewPreDetails.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataForPrescriptionDetailBindingSource
            // 
            this.dataForPrescriptionDetailBindingSource.DataMember = "DataForPrescriptionDetail";
            this.dataForPrescriptionDetailBindingSource.DataSource = this.dataSet1;
            // 
            // dataForPrescriptionDetailTableAdapter
            // 
            this.dataForPrescriptionDetailTableAdapter.ClearBeforeFill = true;
            // 
            // frmViewPreDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmViewPreDetail";
            this.Text = "frmViewPreDetail";
            this.Load += new System.EventHandler(this.frmViewPreDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataForPrescriptionDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataForPrescriptionDetailBindingSource;
        private DataSet.DataSet1 dataSet1;
        private DataSet.DataSet1TableAdapters.DataForPrescriptionDetailTableAdapter dataForPrescriptionDetailTableAdapter;
    }
}
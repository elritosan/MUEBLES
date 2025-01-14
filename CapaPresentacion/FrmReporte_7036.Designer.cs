namespace CapaPresentacion
{
    partial class FrmReporte_7036
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
            this.clientes7036BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clientes7036TableAdapter = new CapaPresentacion.DataSetBDMueblesTableAdapters.Clientes7036TableAdapter();
            this.dataSetBDMuebles1 = new CapaPresentacion.DataSetBDMuebles();
            this.clientes7036BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clientes7036BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBDMuebles1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientes7036BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientes7036BindingSource
            // 
            this.clientes7036BindingSource.DataMember = "Clientes7036";
            this.clientes7036BindingSource.DataSource = this.dataSetBDMuebles1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.clientes7036BindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Report7036.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // clientes7036TableAdapter
            // 
            this.clientes7036TableAdapter.ClearBeforeFill = true;
            // 
            // dataSetBDMuebles1
            // 
            this.dataSetBDMuebles1.DataSetName = "DataSetBDMuebles";
            this.dataSetBDMuebles1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientes7036BindingSource1
            // 
            this.clientes7036BindingSource1.DataMember = "Clientes7036";
            this.clientes7036BindingSource1.DataSource = this.dataSetBDMuebles1;
            // 
            // FrmReporte_7036
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporte_7036";
            this.Text = "FrmReporte_7036";
            this.Load += new System.EventHandler(this.FrmReporte_7036_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientes7036BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBDMuebles1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientes7036BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetBDMuebles dataSetBDMuebles1;
        private System.Windows.Forms.BindingSource clientes7036BindingSource;
        private DataSetBDMueblesTableAdapters.Clientes7036TableAdapter clientes7036TableAdapter;
        private System.Windows.Forms.BindingSource clientes7036BindingSource1;
    }
}
namespace CapaPresentacion
{
    partial class FrmReporte_7122
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
            this.muebles7122BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBDMuebles = new CapaPresentacion.DataSetBDMuebles();
            this.muebles7122BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.muebles7122TableAdapter = new CapaPresentacion.DataSetBDMueblesTableAdapters.Muebles7122TableAdapter();
            this.muebles7133BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muebles7133TableAdapter = new CapaPresentacion.DataSetBDMueblesTableAdapters.Muebles7133TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.muebles7122BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBDMuebles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muebles7122BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muebles7133BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // muebles7122BindingSource1
            // 
            this.muebles7122BindingSource1.DataMember = "Muebles7122";
            this.muebles7122BindingSource1.DataSource = this.dataSetBDMuebles;
            // 
            // dataSetBDMuebles
            // 
            this.dataSetBDMuebles.DataSetName = "DataSetBDMuebles";
            this.dataSetBDMuebles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // muebles7122BindingSource
            // 
            this.muebles7122BindingSource.DataMember = "Muebles7122";
            this.muebles7122BindingSource.DataSource = this.dataSetBDMuebles;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.muebles7133BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Report7122.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // muebles7122TableAdapter
            // 
            this.muebles7122TableAdapter.ClearBeforeFill = true;
            // 
            // muebles7133BindingSource
            // 
            this.muebles7133BindingSource.DataMember = "Muebles7133";
            this.muebles7133BindingSource.DataSource = this.dataSetBDMuebles;
            // 
            // muebles7133TableAdapter
            // 
            this.muebles7133TableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporte_7122
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporte_7122";
            this.Text = "FrmReporte_7122";
            this.Load += new System.EventHandler(this.FrmReporte_7122_Load);
            ((System.ComponentModel.ISupportInitialize)(this.muebles7122BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBDMuebles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muebles7122BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muebles7133BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetBDMuebles dataSetBDMuebles;
        private System.Windows.Forms.BindingSource muebles7122BindingSource;
        private DataSetBDMueblesTableAdapters.Muebles7122TableAdapter muebles7122TableAdapter;
        private System.Windows.Forms.BindingSource muebles7122BindingSource1;
        private System.Windows.Forms.BindingSource muebles7133BindingSource;
        private DataSetBDMueblesTableAdapters.Muebles7133TableAdapter muebles7133TableAdapter;
    }
}
﻿namespace CapaPresentacion
{
    partial class FrmReporte___6858
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
            this.dataSetBDMuebles1 = new CapaPresentacion.DataSetBDMuebles();
            this.muebles6858BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muebles6858TableAdapter = new CapaPresentacion.DataSetBDMueblesTableAdapters.Muebles6858TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBDMuebles1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muebles6858BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.muebles6858BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Report6858.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetBDMuebles1
            // 
            this.dataSetBDMuebles1.DataSetName = "DataSetBDMuebles";
            this.dataSetBDMuebles1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // muebles6858BindingSource
            // 
            this.muebles6858BindingSource.DataMember = "Muebles6858";
            this.muebles6858BindingSource.DataSource = this.dataSetBDMuebles1;
            // 
            // muebles6858TableAdapter
            // 
            this.muebles6858TableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporte___6858
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporte___6858";
            this.Text = "FrmReporte_6858";
            this.Load += new System.EventHandler(this.FrmReporte___6858_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBDMuebles1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muebles6858BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetBDMuebles dataSetBDMuebles1;
        private System.Windows.Forms.BindingSource muebles6858BindingSource;
        private DataSetBDMueblesTableAdapters.Muebles6858TableAdapter muebles6858TableAdapter;
    }
}
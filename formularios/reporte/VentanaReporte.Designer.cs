namespace LatamDS.formularios.reporte
{
    partial class VentanaReporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Factura_Totales";
            reportDataSource1.Value = this.FacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LatamDS.formularios.reporte.REPORTE_FACTURA_TOTALES.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reportViewer1.Size = new System.Drawing.Size(358, 257);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Visible = false;
            // 
            // reportViewer2
            // 
            this.reportViewer2.DocumentMapWidth = 8;
            reportDataSource2.Name = "Factura_Totales";
            reportDataSource2.Value = this.FacturaBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "LatamDS.formularios.reporte.REPORTE_FACTURA_TOTALES.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(376, 12);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(477, 257);
            this.reportViewer2.TabIndex = 1;
            this.reportViewer2.Visible = false;
            // 
            // FacturaBindingSource
            // 
            this.FacturaBindingSource.DataSource = typeof(LatamDS.clases.Factura);
            // 
            // VentanaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 257);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "VentanaReporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VentanaReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource FacturaBindingSource;
    }
}
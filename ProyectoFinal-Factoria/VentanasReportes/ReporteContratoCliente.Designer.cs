namespace ProyectoFinal_Factoria.VentanasReportes
{
    partial class ReporteContratoCliente
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
            this.ContratosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FactoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ContratosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Contratos";
            reportDataSource1.Value = this.ContratosBindingSource;
            reportDataSource2.Name = "Factoria";
            reportDataSource2.Value = this.FactoriasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoFinal_Factoria.Reportes.ReporteContratosCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(617, 407);
            this.reportViewer1.TabIndex = 0;
            // 
            // ContratosBindingSource
            // 
            this.ContratosBindingSource.DataSource = typeof(Entidades.Contratos);
            // 
            // FactoriasBindingSource
            // 
            this.FactoriasBindingSource.DataSource = typeof(Entidades.Factorias);
            // 
            // ReporteContratoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 407);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteContratoCliente";
            this.Text = "ReporteContratoCliente";
            this.Load += new System.EventHandler(this.ReporteContratoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContratosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactoriasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ContratosBindingSource;
        private System.Windows.Forms.BindingSource FactoriasBindingSource;
    }
}
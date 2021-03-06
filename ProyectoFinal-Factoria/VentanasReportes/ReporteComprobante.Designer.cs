﻿namespace ProyectoFinal_Factoria.VentanasReportes
{
    partial class ReporteComprobante
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
            this.ComprobanteRecepcionCacaosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ComprobanteRecepcionCacaosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Comprobantes";
            reportDataSource1.Value = this.ComprobanteRecepcionCacaosBindingSource;
            reportDataSource2.Name = "Productor";
            reportDataSource2.Value = this.ProductoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoFinal_Factoria.Reportes.ConsultaComprobante.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(621, 391);
            this.reportViewer1.TabIndex = 0;
            // 
            // ComprobanteRecepcionCacaosBindingSource
            // 
            this.ComprobanteRecepcionCacaosBindingSource.DataSource = typeof(Entidades.ComprobanteRecepcionCacaos);
            // 
            // ProductoresBindingSource
            // 
            this.ProductoresBindingSource.DataSource = typeof(Entidades.Productores);
            // 
            // ReporteComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 391);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteComprobante";
            this.Text = "ReporteComprobante";
            this.Load += new System.EventHandler(this.ReporteComprobante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComprobanteRecepcionCacaosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ComprobanteRecepcionCacaosBindingSource;
        private System.Windows.Forms.BindingSource ProductoresBindingSource;
    }
}
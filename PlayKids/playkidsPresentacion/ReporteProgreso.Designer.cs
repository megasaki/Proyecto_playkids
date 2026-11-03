namespace playkidsPresentacion
{
    partial class ReporteProgreso
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
            this.playKidsCapasDBDataSet1 = new playkidsPresentacion.PlayKidsCapasDBDataSet1();
            this.playKidsCapasDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playKidsCapasDBDataSet2 = new playkidsPresentacion.PlayKidsCapasDBDataSet2();
            this.playKidsCapasDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playKidsCapasDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playKidsCapasDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playKidsCapasDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playKidsCapasDBDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "reporte";
            reportDataSource1.Value = this.playKidsCapasDBDataSet2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "playkidsPresentacion.Reportes.rptProgreso.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(814, 594);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // playKidsCapasDBDataSet1
            // 
            this.playKidsCapasDBDataSet1.DataSetName = "PlayKidsCapasDBDataSet1";
            this.playKidsCapasDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playKidsCapasDBDataSet1BindingSource
            // 
            this.playKidsCapasDBDataSet1BindingSource.DataSource = this.playKidsCapasDBDataSet1;
            this.playKidsCapasDBDataSet1BindingSource.Position = 0;
            // 
            // playKidsCapasDBDataSet2
            // 
            this.playKidsCapasDBDataSet2.DataSetName = "PlayKidsCapasDBDataSet2";
            this.playKidsCapasDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playKidsCapasDBDataSet2BindingSource
            // 
            this.playKidsCapasDBDataSet2BindingSource.DataSource = this.playKidsCapasDBDataSet2;
            this.playKidsCapasDBDataSet2BindingSource.Position = 0;
            // 
            // ReporteProgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 594);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteProgreso";
            this.Text = "ReporteProgreso";
            this.Load += new System.EventHandler(this.ReporteProgreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playKidsCapasDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playKidsCapasDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playKidsCapasDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playKidsCapasDBDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource playKidsCapasDBDataSet2BindingSource;
        private PlayKidsCapasDBDataSet2 playKidsCapasDBDataSet2;
        private PlayKidsCapasDBDataSet1 playKidsCapasDBDataSet1;
        private System.Windows.Forms.BindingSource playKidsCapasDBDataSet1BindingSource;
    }
}
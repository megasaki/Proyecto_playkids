namespace playkidsPresentacion
{
    partial class ReporteEstudiantes
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
            this.playKidsCapasDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playKidsCapasDBDataSet1 = new playkidsPresentacion.PlayKidsCapasDBDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.playKidsCapasDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playKidsCapasDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // playKidsCapasDBDataSet1BindingSource
            // 
            this.playKidsCapasDBDataSet1BindingSource.DataSource = this.playKidsCapasDBDataSet1;
            this.playKidsCapasDBDataSet1BindingSource.Position = 0;
            // 
            // playKidsCapasDBDataSet1
            // 
            this.playKidsCapasDBDataSet1.DataSetName = "PlayKidsCapasDBDataSet1";
            this.playKidsCapasDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.playKidsCapasDBDataSet1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "playkidsPresentacion.Reportes.rptEstudiantes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(734, 487);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 487);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteEstudiantes";
            this.Text = "ReporteEstudiantes";
            this.Load += new System.EventHandler(this.ReporteEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playKidsCapasDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playKidsCapasDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource playKidsCapasDBDataSet1BindingSource;
        private PlayKidsCapasDBDataSet1 playKidsCapasDBDataSet1;
    }
}
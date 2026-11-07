namespace playkidsPresentacion
{
    partial class ReporteBitacora
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
            this.playKidsCapasDBDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playKidsCapasDBDataSet4 = new playkidsPresentacion.PlayKidsCapasDBDataSet4();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_ReporteBitacoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playKidsCapasDBDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playKidsCapasDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ReporteBitacoraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // playKidsCapasDBDataSet4BindingSource
            // 
            this.playKidsCapasDBDataSet4BindingSource.DataSource = this.playKidsCapasDBDataSet4;
            this.playKidsCapasDBDataSet4BindingSource.Position = 0;
            // 
            // playKidsCapasDBDataSet4
            // 
            this.playKidsCapasDBDataSet4.DataSetName = "PlayKidsCapasDBDataSet4";
            this.playKidsCapasDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "bitacora";
            reportDataSource1.Value = this.playKidsCapasDBDataSet4BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "playkidsPresentacion.Reportes.rptBitacora.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(869, 547);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // sp_ReporteBitacoraBindingSource
            // 
            this.sp_ReporteBitacoraBindingSource.DataMember = "sp_ReporteBitacora";
            this.sp_ReporteBitacoraBindingSource.DataSource = this.playKidsCapasDBDataSet4;
            // 
            // ReporteBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 547);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReporteBitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteBitacora";
            this.Load += new System.EventHandler(this.ReporteBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playKidsCapasDBDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playKidsCapasDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ReporteBitacoraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource playKidsCapasDBDataSet4BindingSource;
        private PlayKidsCapasDBDataSet4 playKidsCapasDBDataSet4;
        private System.Windows.Forms.BindingSource sp_ReporteBitacoraBindingSource;
    }
}
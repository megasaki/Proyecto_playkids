using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace playkidsPresentacion
{
    public partial class ReporteProgreso : Form
    {
        public ReporteProgreso()
        {
            InitializeComponent();
        }

        private void ReporteProgreso_Load(object sender, EventArgs e)
        {
            try
            {
                PlayKidsCapasDBDataSet2TableAdapters.sp_ReporteProgresoTableAdapter adaptador =
                    new PlayKidsCapasDBDataSet2TableAdapters.sp_ReporteProgresoTableAdapter();

                PlayKidsCapasDBDataSet2 ds = new PlayKidsCapasDBDataSet2();

                adaptador.Fill(ds.sp_ReporteProgreso);

                this.reportViewer1.LocalReport.DataSources.Clear();

          
                ReportDataSource rds = new ReportDataSource("reporte", (DataTable)ds.sp_ReporteProgreso);

                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte de progreso: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

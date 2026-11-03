using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace playkidsPresentacion
{
    public partial class ReporteEstudiantes : Form
    {
        public ReporteEstudiantes()
        {
            InitializeComponent();
        }

        private void ReporteEstudiantes_Load(object sender, EventArgs e)
        {
            try
            {
                // Instanciamos el TableAdapter y el Dataset tipado correspondiente a estudiantes
                // (Nota: Si tu Dataset de estudiantes es el 1, 2 o el que sea, asegúrate de mantener el número correcto)
                PlayKidsCapasDBDataSet1TableAdapters.sp_ReporteEstudiantesTableAdapter adaptador =
                    new PlayKidsCapasDBDataSet1TableAdapters.sp_ReporteEstudiantesTableAdapter();

                PlayKidsCapasDBDataSet1 ds = new PlayKidsCapasDBDataSet1();

                // Llenamos el dataset con el procedimiento almacenado o consulta de estudiantes
                adaptador.Fill(ds.sp_ReporteEstudiantes);

                // Enlazamos con el ReportViewer cumpliendo con el dataset tipado exigido
                this.reportViewer1.LocalReport.DataSources.Clear();

                // "DataSet1" debe coincidir exactamente con el nombre del DataSet configurado en tu archivo rptEstudiantes.rdlc
                ReportDataSource rds = new ReportDataSource("DataSet1", (DataTable)ds.sp_ReporteEstudiantes);

                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte de estudiantes: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
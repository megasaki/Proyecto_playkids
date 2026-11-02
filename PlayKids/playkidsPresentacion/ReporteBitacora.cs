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
    public partial class ReporteBitacora : Form
    {
        public ReporteBitacora()
        {
            InitializeComponent();
        }

        private void ReporteBitacora_Load(object sender, EventArgs e)
        {
            try
            {
                // Instanciamos el TableAdapter y el Dataset tipado usando el namespace completo de tu proyecto
                PlayKidsCapasDBDataSet4TableAdapters.sp_ReporteBitacoraTableAdapter adaptador =
                    new PlayKidsCapasDBDataSet4TableAdapters.sp_ReporteBitacoraTableAdapter();

                PlayKidsCapasDBDataSet4 ds = new PlayKidsCapasDBDataSet4();

                // Llenamos el dataset con el procedimiento almacenado
                adaptador.Fill(ds.sp_ReporteBitacora);

                // Enlazamos con el ReportViewer cumpliendo con el dataset tipado exigido
                this.reportViewer1.LocalReport.DataSources.Clear();

                // "bitacora" debe coincidir exactamente con el nombre del DataSet en tu archivo rptBitacora.rdlc
                ReportDataSource rds = new ReportDataSource("bitacora", (DataTable)ds.sp_ReporteBitacora);

                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte de bitácora: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }
    }
}
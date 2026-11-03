using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace playkidsPresentacion
{
    public partial class AdminReportes : Form
    {
        public AdminReportes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
        
            ReporteBitacora frmBitacora = new ReporteBitacora();
            frmBitacora.ShowDialog();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            ReporteEstudiantes frmEstudiantes = new ReporteEstudiantes();
            frmEstudiantes.ShowDialog();
        }

        private void btnProgreso_Click(object sender, EventArgs e)
        {
            ReporteProgreso frmProgreso = new ReporteProgreso();
            frmProgreso.ShowDialog();
        }
    }
}

using System;
using System.Windows.Forms;

namespace playkidsPresentacion
{

    public partial class Resultados : Form
    {
        private int puntaje;
        private int errores;
        private Form menu;
        private Menu formanterio;

        public Resultados(int puntaje, int errores, Form menu)
        {
            this.formanterio = menu as Menu;
            InitializeComponent();
            this.puntaje = puntaje;
            this.errores = errores;
            this.menu = menu;
            CargarDatos();
        }

        public Resultados()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            lblAciertos.Text = "Aciertos: " + puntaje;
            lblErrores.Text = "Errores: " + errores;
            lblPuntaje.Text = "Puntaje: " + puntaje;

            int total = puntaje + errores;
            if (total > 0)
            {
                double porcentaje = (puntaje * 100.0) / total;
                lblPuntaje.Text += $" ({porcentaje:0}%)";
            }

            if (puntaje == 0) lblMensaje.Text = "💀 Necesitas practicar...";
            else if (puntaje <= 2) lblMensaje.Text = "🙂 Vas mejorando";
            else if (puntaje <= 4) lblMensaje.Text = "😎 Buen trabajo";
            else lblMensaje.Text = "🔥 PERFECTO!";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (menu != null) menu.Show();
        }

        private void Resultados_Load(object sender, EventArgs e) { }
        private void lblAciertos_Click(object sender, EventArgs e) { }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            if (formanterio != null)
                formanterio.Show(); 
        }
    }
}
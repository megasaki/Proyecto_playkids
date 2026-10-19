using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using playkidsEntidades;
using playkidsNegocio;

namespace playkidsPresentacion
{
    public partial class juego_de_ingles : Form
    {
        private Menu formanterior;
        private Usuario usuario;
        private SeleccionMultiple juego;
        private ProgresoNegocio progresoNegocio = new ProgresoNegocio();

        public juego_de_ingles()
        {
            InitializeComponent();
        }

        
        public juego_de_ingles(Menu formanterior)
        {
            InitializeComponent();
            this.formanterior = formanterior;
            this.usuario = formanterior.UsuarioActual;

            
            IntentoGlobal.Limpiar();

            
            juego = new SeleccionMultiple();
            juego.GenerarPregunta();

            MostrarPregunta();
        }

        private void MostrarPregunta()
        {
            if (juego == null || juego.PreguntaActual == null) return;

       
            lblPalabraEspañol.Text = juego.PreguntaActual.Espanol;

            
            btnOpcion1.Text = juego.Opciones[0];
            btnOpcion2.Text = juego.Opciones[1];
            btnOpcion3.Text = juego.Opciones[2];

            lblPuntaje.Text = "Puntaje: " + juego.Puntaje;
            lblResultado.Text = "";

            
            btnOpcion1.Enabled = true;
            btnOpcion2.Enabled = true;
            btnOpcion3.Enabled = true;
            btnSiguiente.Enabled = false;
        }

        private void Verificar(string respuesta)
        {
            if (juego == null) return;

            string correcta = juego.PreguntaActual.Ingles;

            
            bool esCorrecto = juego.VerificarRespuesta(respuesta);

            
            Respuesta r = new Respuesta(respuesta, esCorrecto);
            IntentoGlobal.Agregar(r);

            
            if (esCorrecto)
            {
                lblResultado.Text = "¡Correcto!";
                lblResultado.ForeColor = Color.Green;
            }
            else
            {
                lblResultado.Text = "Incorrecto (Era: " + correcta + ")";
                lblResultado.ForeColor = Color.Red;
            }

            lblPuntaje.Text = "Puntaje: " + juego.Puntaje;

            
            btnOpcion2.Enabled = false;
            btnOpcion3.Enabled = false;

            if (juego.JuegoTerminado())
            {
                FinalizarJuego();
            }
            else
            {
                
                btnSiguiente.Enabled = true;
            }
        }

        private void FinalizarJuego()
        {
            btnSiguiente.Enabled = false;
            lblPalabraEspañol.Text = "¡Juego terminado!";

            int puntaje = IntentoGlobal.CalcularPuntaje();
            int errores = IntentoGlobal.CalcularErrores();

            Progreso progreso = new Progreso
            {
                IdUsuario = usuario.IdUsuario,
                IdLeccion = 2,
                Puntaje = puntaje,
                Errores = errores,
                Fecha = DateTime.Now
            };

            try
            {
              
                progresoNegocio.GuardarProgreso(progreso);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar progreso: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            Resultados form = new Resultados(puntaje, errores, formanterior);
            form.Show();
            this.Hide();
        }



        private void butregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (formanterior != null)
                formanterior.Show();
        }

        private void btnOpcion1_Click(object sender, EventArgs e)
        {
            Verificar(btnOpcion1.Text);
        }

        private void btnOpcion2_Click(object sender, EventArgs e)
        {
            Verificar(btnOpcion2.Text);
        }

        private void btnOpcion3_Click(object sender, EventArgs e)
        {
            Verificar(btnOpcion3.Text);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (juego != null && !juego.JuegoTerminado())
            {
                juego.GenerarPregunta();
                MostrarPregunta();
            }
        }

        
        private void lblPuntaje_Click(object sender, EventArgs e) { }
        private void lblPalabraEspañol_Click(object sender, EventArgs e) { }
        private void lblResultado_Click(object sender, EventArgs e) { }
    }
}
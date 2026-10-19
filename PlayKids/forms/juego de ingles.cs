using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PlayKids.Clases;
using PlayKids.Juegos;
using PlayKids.Servicios;

namespace PlayKids
{
    public partial class juego_de_ingles : Form
    {
        private SeleccionMultiple juego;
        private Menu formanterior;

        private Usuario usuario;

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
            if (juego == null) return;

            lblPalabraEspañol.Text = juego.PreguntaActual.Espanol;

            btnOpcion1.Text = juego.Opciones[0];
            btnOpcion2.Text = juego.Opciones[1];
            btnOpcion3.Text = juego.Opciones[2];

            lblPuntaje.Text = "Puntaje: " + juego.Puntaje;

            lblResultado.Text = "";
        }

        private void Verificar(string respuesta)
        {
            if (juego == null) return;

            string correcta = juego.PreguntaActual.Ingles;

            bool correcto = juego.VerificarRespuesta(respuesta);

            Respuesta r = new Respuesta
            {
                RespuestaUsuario = respuesta,
                EsCorrecta = correcto
            };

            IntentoGlobal.Agregar(r);

            if (correcto)
                lblResultado.Text = "Correcto";
            else
                lblResultado.Text =
                    "Incorrecto (Era: " + correcta + ")";

            lblPuntaje.Text =
                "Puntaje: " + juego.Puntaje;

            if (juego.JuegoTerminado())
                FinalizarJuego();
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
            if (juego == null) return;

            if (!juego.JuegoTerminado())
            {
                juego.GenerarPregunta();
                MostrarPregunta();
            }
        }

        private void butregresar_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (formanterior != null)
                formanterior.Show();
        }

        private void FinalizarJuego()
        {
            btnOpcion1.Enabled = false;
            btnOpcion2.Enabled = false;
            btnOpcion3.Enabled = false;
            btnSiguiente.Enabled = false;

            lblPalabraEspañol.Text = "Juego terminado";

            int puntaje =
                IntentoGlobal.CalcularPuntaje();

            int errores =
                IntentoGlobal.CalcularErrores();

            Progreso progreso = new Progreso();

            progreso.IdUsuario = usuario.IdUsuario;

            progreso.IdLeccion = 2;

            progreso.Puntaje = puntaje;
            progreso.Errores = errores;

            progreso.Respuestas =
                new List<Respuesta>(
                    IntentoGlobal.Respuestas);

            try
            {
                ProgresoService progresoService =
                    new ProgresoService();

                progresoService.Guardar(progreso);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error guardando progreso:\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            Resultados form = new Resultados(
                puntaje,
                errores,
                formanterior
            );

            form.Show();
            this.Hide();
        }
    }
}
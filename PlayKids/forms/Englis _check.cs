using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayKids.Clases;
using PlayKids.Juegos;
using PlayKids.Servicios;

namespace PlayKids
{
    public partial class Englis__check : Form
    {
        private Menu menuForm;
        private Usuario usuario;
        private VerdaderoFalso juego;
        private bool juegoIniciado = false;

        public Englis__check()
        {
            InitializeComponent();
        }

        public Englis__check(Menu menuForm)
        {
            InitializeComponent();

            this.menuForm = menuForm;
            this.usuario = menuForm.UsuarioActual;

            prepararjuego();
        }

        private void prepararjuego()
        {
            label3.Text = "Presiona 'Iniciar Juego' para comenzar.";
            label1.Text = "";
            label2.Text = "";

            butcorrecto.Enabled = false;
            butincorrecto.Enabled = false;

            juegoIniciado = false;
        }

        private void iniciarjuego()
        {
            IntentoGlobal.Limpiar();

            label3.Text = "¿La siguiente oración es correcta?";
            juegoIniciado = true;

            juego = new VerdaderoFalso();

            butcorrecto.Enabled = true;
            butincorrecto.Enabled = true;

            juego.GenerarPregunta();
            mostraroracion();
        }

        private void mostraroracion()
        {
            if (juego == null) return;

            if (!juego.JuegoTerminado())
            {
                label1.Text = juego.Pregunta;
                label2.Text = "";
            }
        }

        private async Task evaluarrespuesta(bool respuestaUsuario)
        {
            if (juego == null) return;

            bool correcto = juego.VerificarRespuesta(respuestaUsuario);

            Respuesta r = new Respuesta
            {
                RespuestaUsuario = respuestaUsuario.ToString(),
                EsCorrecta = correcto
            };

            IntentoGlobal.Agregar(r);

            label2.Text = correcto ? "Correct!" : "Incorrect!";

            butcorrecto.Enabled = false;
            butincorrecto.Enabled = false;

            await Task.Delay(1000);

            juego.Siguiente();

            if (juego.JuegoTerminado())
            {
                int puntaje = IntentoGlobal.CalcularPuntaje();
                int errores = IntentoGlobal.CalcularErrores();

                Progreso progreso = new Progreso();

                progreso.IdUsuario = usuario.IdUsuario;
                progreso.IdLeccion = 1;

                progreso.Puntaje = puntaje;
                progreso.Errores = errores;

                progreso.Respuestas =
                    new List<Respuesta>(IntentoGlobal.Respuestas);

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
                    menuForm
                );

                form.Show();
                this.Hide();

                return;
            }

            juego.GenerarPregunta();
            mostraroracion();

            butcorrecto.Enabled = true;
            butincorrecto.Enabled = true;
        }

        private void butiniciar_Click(object sender, EventArgs e)
        {
            iniciarjuego();
        }

        private void butcorrecto_Click(object sender, EventArgs e)
        {
            if (juegoIniciado)
                _ = evaluarrespuesta(true);
        }

        private void butincorrecto_Click(object sender, EventArgs e)
        {
            if (juegoIniciado)
                _ = evaluarrespuesta(false);
        }

        private void butregresar_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (menuForm != null)
                menuForm.Show();

            juegoIniciado = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void Englis__check_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}
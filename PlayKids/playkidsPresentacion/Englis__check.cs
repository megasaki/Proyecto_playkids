using System;
using System.Collections.Generic;
using System.Windows.Forms;
using playkidsEntidades;
using playkidsNegocio;

namespace playkidsPresentacion
{
    public partial class Englis__check : Form
    {
        private Menu menuForm;
        private Usuario usuario;
        private VerdaderoFalso juego;
        private ProgresoNegocio progresoNegocio = new ProgresoNegocio();
        private bool juegoIniciado = false;

        private int preguntasRespondidas = 0;
        private const int TOTAL_PREGUNTAS = 5;

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

            // El botón de iniciar está activo para dar el vamos
            butiniciar.Enabled = true;
            butiniciar.Text = "Iniciar Juego";

            juegoIniciado = false;
            preguntasRespondidas = 0;
        }

        private void iniciarjuego()
        {
            IntentoGlobal.Limpiar();
            preguntasRespondidas = 0;

            label3.Text = "¿La siguiente oración es correcta?";
            juegoIniciado = true;

            juego = new VerdaderoFalso();

            // Habilitamos respuestas y desactivamos el botón de iniciar temporalmente
            butcorrecto.Enabled = true;
            butincorrecto.Enabled = true;
            butiniciar.Enabled = false;
            butiniciar.Text = "Siguiente";

            juego.GenerarPregunta();
            mostraroracion();
        }

        private void mostraroracion()
        {
            if (juego == null) return;

            if (preguntasRespondidas < TOTAL_PREGUNTAS)
            {
                label1.Text = juego.Pregunta;
                label2.Text = "";
            }
        }

        private void evaluarrespuesta(bool respuestaUsuario)
        {
            if (juego == null) return;

            // La capa de Negocio evalúa si es correcta
            bool correcto = juego.VerificarRespuesta(respuestaUsuario);

            // Registramos la respuesta en el intento global 
            Respuesta r = new Respuesta(respuestaUsuario.ToString(), correcto);
            IntentoGlobal.Agregar(r);

            label2.Text = correcto ? "Correct!" : "Incorrect!";

            // Bloqueamos los botones de respuesta para que no puedan presionar dos veces
            butcorrecto.Enabled = false;
            butincorrecto.Enabled = false;

            preguntasRespondidas++;

            // Si ya llegamos al límite de preguntas, el botón ahora servirá para ir a Resultados
            if (preguntasRespondidas >= TOTAL_PREGUNTAS || juego.JuegoTerminado())
            {
                butiniciar.Text = "Ver Resultados";
                butiniciar.Enabled = true; // Se activa para que el usuario decida cuándo ver sus notas
                return;
            }

            // Activamos el botón (que ahora funciona como "Siguiente") para que el usuario avance cuando esté listo
            butiniciar.Enabled = true;
        }

        private void SiguientePregunta()
        {
            // Si ya completamos las preguntas y dio clic en Ver Resultados
            if (preguntasRespondidas >= TOTAL_PREGUNTAS)
            {
                FinalizarJuego();
                return;
            }

            // Avanzamos en la lógica y mostramos la nueva oración
            juego.Siguiente();
            juego.GenerarPregunta();
            mostraroracion();

            // Preparamos los botones para la nueva ronda
            butiniciar.Enabled = false;
            butiniciar.Text = "Siguiente";
            butcorrecto.Enabled = true;
            butincorrecto.Enabled = true;
        }

        private void FinalizarJuego()
        {
            int puntaje = IntentoGlobal.CalcularPuntaje();
            int errores = IntentoGlobal.CalcularErrores();

            Progreso progreso = new Progreso
            {
                IdUsuario = usuario.IdUsuario,
                IdLeccion = 1,
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
                MessageBox.Show(
                    "Error guardando progreso:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            Resultados form = new Resultados(puntaje, errores, menuForm);
            form.Show();
            this.Hide();
        }

        // El botón de iniciar ahora maneja las tres fases: Iniciar -> Siguiente -> Ver Resultados
        private void butiniciar_Click_1(object sender, EventArgs e)
        {
            if (!juegoIniciado)
            {
                iniciarjuego();
            }
            else
            {
                SiguientePregunta();
            }
        }

        private void butcorrecto_Click_1(object sender, EventArgs e)
        {
            if (juegoIniciado && butcorrecto.Enabled)
                evaluarrespuesta(true);
        }

        private void butincorrecto_Click_1(object sender, EventArgs e)
        {
            if (juegoIniciado && butincorrecto.Enabled)
                evaluarrespuesta(false);
        }

        private void butregresar_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            if (menuForm != null)
                menuForm.Show();

            juegoIniciado = false;
        }
    }
}
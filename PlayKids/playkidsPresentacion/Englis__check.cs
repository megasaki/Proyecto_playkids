using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        public Englis__check()
        {
            InitializeComponent();
        }

        // Recibimos el menú para poder regresar y obtener el usuario que inició sesión
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

            // La capa de Negocio evalúa si es correcta
            bool correcto = juego.VerificarRespuesta(respuestaUsuario);

            // Registramos la respuesta en el intento global 
            Respuesta r = new Respuesta(respuestaUsuario.ToString(), correcto);
            IntentoGlobal.Agregar(r);

            label2.Text = correcto ? "Correct!" : "Incorrect!";

            butcorrecto.Enabled = false;
            butincorrecto.Enabled = false;

            await Task.Delay(1000); // Pausa de 1 segundo para que el niño vea si acertó

            juego.Siguiente();

            if (juego.JuegoTerminado())
            {
                FinalizarJuego();
                return;
            }

            juego.GenerarPregunta();
            mostraroracion();

            butcorrecto.Enabled = true;
            butincorrecto.Enabled = true;
        }

        private void FinalizarJuego()
        {
            int puntaje = IntentoGlobal.CalcularPuntaje();
            int errores = IntentoGlobal.CalcularErrores();

            // Armamos la Entidad del progreso
            Progreso progreso = new Progreso
            {
                IdUsuario = usuario.IdUsuario,
                IdLeccion = 1, // ID 1 representa a Verdadero/Falso en la base de datos
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

            // Llamamos a la pantalla de resultados
            Resultados form = new Resultados(puntaje, errores, menuForm);
            form.Show();
            this.Hide();
        }

  
        private void butiniciar_Click_1(object sender, EventArgs e)
        {
            iniciarjuego();
        }

        private void butcorrecto_Click_1(object sender, EventArgs e)
        {
            if (juegoIniciado)
                _ = evaluarrespuesta(true);
        }

        private void butincorrecto_Click_1(object sender, EventArgs e)
        {
            if (juegoIniciado)
                _ = evaluarrespuesta(false);
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
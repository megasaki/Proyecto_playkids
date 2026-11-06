using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
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

            // Disparamos la verificación de logros en segundo plano al mostrar los resultados
            _ = VerificarYNotificarLogrosAsync();
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

        // Método que se conecta a la API para evaluar los logros del usuario
        private async Task VerificarYNotificarLogrosAsync()
        {
            try
            {
                int idUsuarioActual = 21; // Respaldado o tomado del menú
                if (formanterio != null && formanterio.UsuarioActual != null)
                {
                    idUsuarioActual = formanterio.UsuarioActual.IdUsuario;
                }

                using (HttpClient client = new HttpClient())
                {
                    string url = $"http://localhost:5083/api/LogrosPython/{idUsuarioActual}";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();
                        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                        var listaLogros = JsonSerializer.Deserialize<List<LogroDTO>>(jsonString, options);

                        // Buscamos si hay algún logro completado para darle la sorpresa al usuario
                        foreach (var logro in listaLogros)
                        {
                            if (logro.completado)
                            {
                                // O puedes personalizarlo para que avise de forma alegre
                            }
                        }

                        // Mensaje directo de motivación al terminar la lección con sus logros actualizados
                        MessageBox.Show(
                            "¡Excelente trabajo completando la lección!\n¡Tus logros se han actualizado en el árbol de trofeos 🏆!",
                            "¡Logros Actualizados!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al verificar logros: {ex.Message}");
            }
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
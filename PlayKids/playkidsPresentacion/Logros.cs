using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace playkidsPresentacion
{
    public partial class Logros : Form
    {
        private Menu menuForm;
        private int idUsuario = 21; // ID por defecto de respaldo

        public Logros()
        {
            InitializeComponent();
        }

        public Logros(Menu menu)
        {
            InitializeComponent();
            this.menuForm = menu;

            if (menu != null && menu.UsuarioActual != null)
            {
                this.idUsuario = menu.UsuarioActual.IdUsuario;
            }
        }

        private async void FrmLogros_Load(object sender, EventArgs e)
        {
            await CargarDatosLogrosAsync();
        }

        private async void btnCargarLogros_Click(object sender, EventArgs e)
        {
            await CargarDatosLogrosAsync();
        }

        private async Task CargarDatosLogrosAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string urlApi = $"http://localhost:5083/api/LogrosPython/{this.idUsuario}";
                    HttpResponseMessage response = await client.GetAsync(urlApi);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();

                        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                        var listaLogros = JsonSerializer.Deserialize<List<LogroDTO>>(jsonString, options);

                        dataGridViewLogros.DataSource = listaLogros;

                        if (dataGridViewLogros.Columns["id_logro"] != null)
                            dataGridViewLogros.Columns["id_logro"].HeaderText = "ID";
                        if (dataGridViewLogros.Columns["titulo"] != null)
                            dataGridViewLogros.Columns["titulo"].HeaderText = "Título del Logro";
                        if (dataGridViewLogros.Columns["descripcion"] != null)
                            dataGridViewLogros.Columns["descripcion"].HeaderText = "Descripción";
                        if (dataGridViewLogros.Columns["completado"] != null)
                            dataGridViewLogros.Columns["completado"].HeaderText = "¡Completado!";

                        // Descargar el gráfico generado directamente desde la API por HTTP
                        string urlImagen = "http://localhost:5083/arbol_logros.png";
                        byte[] bytesImagen = await client.GetByteArrayAsync(urlImagen);

                        if (bytesImagen != null && bytesImagen.Length > 0)
                        {
                            if (pictureBoxArbol.Image != null)
                            {
                                pictureBoxArbol.Image.Dispose();
                                pictureBoxArbol.Image = null;
                            }

                            using (var ms = new MemoryStream(bytesImagen))
                            {
                                pictureBoxArbol.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    else
                    {
                        string errorServidor = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error al obtener los logros: {errorServidor}", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión o imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }





    public class LogroDTO
    {
        public int id_logro { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public bool completado { get; set; }
    }

    


}


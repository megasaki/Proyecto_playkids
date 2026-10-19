using System;
using System.Windows.Forms;
using PlayKids.Servicios;
using PlayKids.Clases; 

namespace PlayKids
{
    public partial class logind : Form
    {

        private UsuarioService usuarioService;

        public logind()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
        }

        private void logind_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void butIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string correo = textCorreo.Text.Trim();
                string contra = textContra.Text.Trim();

             
                if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contra))
                {
                    MessageBox.Show("Por favor ingrese todos los campos",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

 
                Usuario usuario = usuarioService.Validar(correo, contra);

                if (usuario != null)
                {
                    MessageBox.Show($"Bienvenido {usuario.Nombre} ",
                        "Acceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information); 

                    this.Hide();

                    Menu menu = new Menu(usuario);
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta ",
                        "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textCorreo.Clear();
                    textContra.Clear();
                    textCorreo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Windows.Forms;
using playkidsEntidades;
using playkidsNegocio;

namespace playkidsPresentacion
{
    public partial class Login : Form
    {
        private UsuarioNegocio negocio = new UsuarioNegocio();

        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = negocio.AutenticarUsuario(
                    txtCorreoLogin.Text,
                    txtContrasenaLogin.Text
                );

                if (usuario != null)
                {
                    MessageBox.Show(
                        "Bienvenido " + usuario.Nombre,
                        "PlayKids",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );


                    Menu menuPrincipal = new Menu(usuario);
                    menuPrincipal.Show(); 
                    this.Hide();         

                }
                else
                {
                    MessageBox.Show(
                        "El correo o la contraseña son incorrectos.",
                        "PlayKids",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "PlayKids",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro formRegistro = new Registro(this);
            formRegistro.Show();
            this.Hide();
        }
    }
}
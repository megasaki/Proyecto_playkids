using System;
using System.Windows.Forms;
using playkidsEntidades;
using playkidsNegocio;

namespace playkidsPresentacion
{
    public partial class Registro : Form
    {
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        private Form formLogin;

        
        public Registro(Form login)
        {
            InitializeComponent();
            this.formLogin = login;

            
            txtContrasena.PasswordChar = '*';
            
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                
                Usuario nuevoUsuario = new Usuario
                {
                    Nombre = txtNombre.Text.Trim(),
                    Edad = int.Parse(txtEdad.Text.Trim()),
                    Sexo = cmbSexo.Text.Substring(0, 1),    
                    Correo = txtCorreo.Text.Trim(),
                    Contrasena = txtContrasena.Text.Trim()
                };

                int idGenerado = usuarioNegocio.RegistrarUsuario(nuevoUsuario);

                MessageBox.Show("¡Cuenta creada con éxito! Ahora puedes iniciar sesión.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                this.Close();
                if (formLogin != null) formLogin.Show();
            }
            catch (FormatException)
            {
            
                MessageBox.Show("Por favor, ingrese un número válido en la edad.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
              
                MessageBox.Show(ex.Message, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            if (formLogin != null) formLogin.Show();
        }

       
        private void Registro_Load(object sender, EventArgs e) { }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
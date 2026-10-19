using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PlayKids
{
    public partial class agregarUsuario : Form
    {
        private Menu formanterio;
        private ConexionDB conexion = new ConexionDB();

        public agregarUsuario(Menu menu)
        {
            InitializeComponent();

            Inicializacion();

            this.formanterio = menu;

            btnEditar.Visible = false;
            tnBorrar.Visible = false;
        }

        private void Inicializacion()
        {
            dgvUsuarios.ColumnCount = 5;

            dgvUsuarios.Columns[0].Name = "Nombre";
            dgvUsuarios.Columns[1].Name = "Sexo";
            dgvUsuarios.Columns[2].Name = "Edad";
            dgvUsuarios.Columns[3].Name = "Correo";
            dgvUsuarios.Columns[4].Name = "Contraseña";

            dgvUsuarios.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.Rows.Clear();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query =
                    @"SELECT Nombre, Sexo, Edad, Correo, Contrasena
                      FROM Usuarios";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader =
                    cmd.ExecuteReader();

                while (reader.Read())
                {
                    dgvUsuarios.Rows.Add(
                        reader["Nombre"].ToString(),
                        reader["Sexo"].ToString(),
                        reader["Edad"].ToString(),
                        reader["Correo"].ToString(),
                        reader["Contrasena"].ToString()
                    );
                }
            }
        }

        private bool validarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show(
                    "Por favor completa todos los campos.");

                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();

            numericEdad.Value = 18;

            txtCorreo.Clear();
            txtContrasena.Clear();

            txtNombre.Focus();
        }

        private void btnAgregar_Click(
            object sender,
            EventArgs e)
        {
            if (!validarCampos())
                return;

            try
            {
                using (SqlConnection conn =
                    conexion.ObtenerConexion())
                {
                    string query =
                        @"INSERT INTO Usuarios
                          (Nombre, Edad, Sexo, Correo, Contrasena)
                          VALUES
                          (@Nombre, @Edad, @Sexo, @Correo, @Contrasena)";

                    SqlCommand cmd =
                        new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@Nombre",
                        txtNombre.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Edad",
                        (int)numericEdad.Value);

                    cmd.Parameters.AddWithValue(
                        "@Sexo",
                        txtApellido.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Correo",
                        txtCorreo.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Contrasena",
                        txtContrasena.Text.Trim());

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Usuario registrado correctamente.");

                LimpiarCampos();
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message);
            }
        }

        private void butregresar_Click(
            object sender,
            EventArgs e)
        {
            formanterio.Show();
            Close();
        }

        private void AgregarUsuario_Load(
            object sender,
            EventArgs e)
        {
            CargarUsuarios();
        }

        private void pictureBox1_Click(
            object sender,
            EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
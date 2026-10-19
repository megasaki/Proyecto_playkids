using System;
using System.Windows.Forms;
using PlayKids.Clases;

using PlayKids.Juegos;

namespace PlayKids
{
    public partial class Menu : Form
    {
        private Usuario usuario;

        public Usuario UsuarioActual
        {
            get { return usuario; }
        }

        public Menu(Usuario usuarioLogueado)
        {
            InitializeComponent();
            usuario = usuarioLogueado;
        }

        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Englis__check englisCheckForm =
                new Englis__check(this);

            englisCheckForm.Show();
        }

        private void butsalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Trofeos trofeosForm = new Trofeos(this);

            trofeosForm.Show();

            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                MessageBox.Show(
                    $"Bienvenido {usuario.Nombre} 😎");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            juego_de_ingles juegoInglesForm =
                new juego_de_ingles(this);

            juegoInglesForm.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            agregarUsuario agregarUsuarioForm =
                new agregarUsuario(this);

            agregarUsuarioForm.Show();

            this.Hide();
        }
    }
}
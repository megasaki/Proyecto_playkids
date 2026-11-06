using System;
using System.Windows.Forms;
using playkidsEntidades;

namespace playkidsPresentacion
{
    public partial class Menu : Form
    {
        public Usuario UsuarioActual { get; private set; }

        public Menu(Usuario usuarioLogueado)
        {
            InitializeComponent();
            UsuarioActual = usuarioLogueado;
        }

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (UsuarioActual != null)
            {
                this.Text = "PlayKids - Menú Principal | " + UsuarioActual.Nombre + " (" + UsuarioActual.NombreRol + ")";

                
                aplicarPermisosPorRol();
            }
        }

        private void aplicarPermisosPorRol()
        {
           
            if (UsuarioActual.NombreRol == "Estudiante")
            {
               
            }
            else if (UsuarioActual.NombreRol == "Administrador" || UsuarioActual.NombreRol == "Docente")
            {
                
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnJuegoVF_Click_1(object sender, EventArgs e)
        {
            Englis__check englisCheckForm = new Englis__check(this);
            englisCheckForm.Show();
            this.Hide();
        }

        private void btnJuegoOpciones_Click_1(object sender, EventArgs e)
        {
            juego_de_ingles juegoInglesForm = new juego_de_ingles(this);
            juegoInglesForm.Show();
            this.Hide();
        }

        private void btnTrofeos_Click_1(object sender, EventArgs e)
        {
            Logros formLogros = new Logros(this);
            formLogros.Show();
        }

        private void butSalir_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
            "¿Estás seguro de que deseas salir?",
            "Confirmar salida",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void butregresar_Click(object sender, EventArgs e)
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
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayKids
{
    public partial class Trofeos : Form
    {
        private Menu formularioAnterior;
        public Trofeos(Menu menu)
        {
            InitializeComponent();
            this.formularioAnterior = menu;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioAnterior.Show();

        }

        private void Trofeos_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Cargando : Form
    {
        public Cargando()
        {
            InitializeComponent();
        }

        private void Cargando_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;   
            timer1.Interval = 100;   
            timer1.Start();          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 2; 
            }
            else
            {
                timer1.Stop(); 

                this.Hide(); 

                logind login = new logind();
                login.Show(); 
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System.Collections.Generic;
using PlayKids.Clases;

namespace PlayKids.Clases
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }

        public List<Progreso> Progresos { get; set; }

        public Usuario()
        {
            Progresos = new List<Progreso>();
        }

      
        public void AgregarProgreso(Progreso progreso)
        {
            Progresos.Add(progreso);
        }

        public int ObtenerPuntajeTotal()
        {
            int total = 0;

            foreach (var progreso in Progresos)
            {
                total += progreso.Puntaje;
            }

            return total;
        }

        
    }
}
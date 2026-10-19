using System;

namespace playkidsEntidades
{
    public class Progreso
    {
        public int IdProgreso { get; set; }
        public int IdUsuario { get; set; }
        public int IdLeccion { get; set; }
        public int Puntaje { get; set; }
        public int Errores { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
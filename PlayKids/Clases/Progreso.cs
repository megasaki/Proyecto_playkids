using System;
using System.Collections.Generic;

namespace PlayKids.Clases
{
    public class Progreso
    {
       
        public int IdProgreso { get; set; }

       
        public int IdUsuario { get; set; }

        
        public int IdLeccion { get; set; }

        public int Puntaje { get; set; }
        public int Errores { get; set; }
        public DateTime Fecha { get; set; }

        
        public List<Respuesta> Respuestas { get; set; }

        public Progreso()
        {
            Fecha = DateTime.Now;
            Respuestas = new List<Respuesta>();
        }


        public Progreso(int idUsuario, int puntaje, int errores)
        {
            IdUsuario = idUsuario;
            Puntaje = puntaje;
            Errores = errores;
            Fecha = DateTime.Now;
            Respuestas = new List<Respuesta>();
        }

    
        public void CalcularDesdeIntento(Intento intento)
        {
            Puntaje = intento.CalcularPuntaje();
            Errores = intento.CalcularErrores();
            Respuestas = intento.Respuestas;
        }

       
        public double ObtenerPrecision()
        {
            int total = Puntaje + Errores;
            if (total == 0) return 0;

            return (double)Puntaje / total * 100;
        }

        public override string ToString()
        {
            return $"Puntaje: {Puntaje} | Errores: {Errores} | Fecha: {Fecha}";
        }
    }
}
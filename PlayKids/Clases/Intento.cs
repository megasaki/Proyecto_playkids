using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayKids.Clases
{
    public class Intento
    {
        public int IdIntento { get; set; }

        public int IdSesion { get; set; }

        public DateTime Fecha { get; set; }
        public int Duracion { get; set; }

        public List<Respuesta> Respuestas { get; set; }

        public Intento()
        {
            Fecha = DateTime.Now;
            Respuestas = new List<Respuesta>();
        }

        public void AgregarRespuesta(Respuesta respuesta)
        {
            Respuestas.Add(respuesta);
        }

        public int CalcularPuntaje()
        {
            return Respuestas.Count(r => r.EsCorrecta);
        }

        public int CalcularErrores()
        {
            return Respuestas.Count(r => !r.EsCorrecta);
        }

        

       
        
    }
}
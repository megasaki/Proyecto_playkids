using System.Collections.Generic;
using playkidsEntidades;

namespace playkidsNegocio
{
    public abstract class Actividad
    {
        public int IdActividad { get; set; }
        public string Pregunta { get; set; }
        public string Categoria { get; set; }
        public int Puntaje { get; set; }

        public List<Progreso> Historial { get; set; }

        public Actividad()
        {
            Historial = new List<Progreso>();
        }

        public abstract void GenerarPregunta();
        public abstract bool VerificarRespuesta(object respuesta);

        public void RegistrarProgreso(Progreso progreso)
        {
            Historial.Add(progreso);
        }
    }
}
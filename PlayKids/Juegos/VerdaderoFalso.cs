using System.Collections.Generic;
using PlayKids.Clases;

namespace PlayKids.Juegos
{
    public class VerdaderoFalso : Actividad
    {
        private List<PreguntaVF> preguntas = new List<PreguntaVF>
        {
            new PreguntaVF("I am a student.", true),
            new PreguntaVF("He are my friend.", false),
            new PreguntaVF("She is happy.", true),
            new PreguntaVF("We is at home.", false),
            new PreguntaVF("They are teachers.", true),
            new PreguntaVF("You is my brother.", false)
        };

        private int indiceActual = 0;

        public int Puntos { get; private set; }

     
        public Intento IntentoActual { get; set; }

        public VerdaderoFalso()
        {
            Puntos = 0;
            Puntaje = 0; 
        }

        public override void GenerarPregunta()
        {
            if (!JuegoTerminado())
            {
                Pregunta = preguntas[indiceActual].Oracion;
            }
        }

        public override bool VerificarRespuesta(object respuesta)
        {
            bool correcto =
                (bool)respuesta ==
                preguntas[indiceActual].EsCorrecta;

            if (correcto)
            {
                Puntos++;
                Puntaje++; 
            }

         
            Respuesta r = new Respuesta(respuesta.ToString(), correcto);

            if (IntentoActual != null)
            {
                r.IdIntento = IntentoActual.IdIntento;

               

                IntentoActual.AgregarRespuesta(r);
            }

  
            Progreso progreso = new Progreso();
            progreso.Puntaje = correcto ? 1 : 0;
            progreso.Errores = correcto ? 0 : 1;

            RegistrarProgreso(progreso);

            return correcto;
        }

        public void Siguiente()
        {
            indiceActual++;
        }

        public bool JuegoTerminado()
        {
            return indiceActual >= preguntas.Count;
        }

        public int TotalPreguntas()
        {
            return preguntas.Count;
        }
    }   
}
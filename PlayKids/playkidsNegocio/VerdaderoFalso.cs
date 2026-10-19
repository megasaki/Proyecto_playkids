using System.Collections.Generic;
using playkidsEntidades;

namespace playkidsNegocio
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
            bool correcto = (bool)respuesta == preguntas[indiceActual].EsCorrecta;

            if (correcto)
            {
                Puntos++;
                Puntaje++;
            }

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
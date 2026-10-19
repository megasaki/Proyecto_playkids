using System;
using System.Collections.Generic;
using System.Linq;
using playkidsEntidades;

namespace playkidsNegocio
{
    public class SeleccionMultiple : Actividad
    {
        private List<Pregunta> preguntas;
        private List<int> usadas;
        private Random random;

        public Pregunta PreguntaActual { get; private set; }
        public List<string> Opciones { get; private set; }
        public int Errores { get; private set; }
        public int MaxErrores { get; set; } = 3;

        public SeleccionMultiple()
        {
            preguntas = new List<Pregunta>
            {
                new Pregunta("gato", "cat"),
                new Pregunta("perro", "dog"),
                new Pregunta("casa", "house"),
                new Pregunta("árbol", "tree"),
                new Pregunta("libro", "book")
            };

            usadas = new List<int>();
            random = new Random();
            Opciones = new List<string>();

            Puntaje = 0;
            Errores = 0;
        }

        public override void GenerarPregunta()
        {
            if (usadas.Count == preguntas.Count)
                return;

            int index;
            do
            {
                index = random.Next(preguntas.Count);
            } while (usadas.Contains(index));

            usadas.Add(index);
            PreguntaActual = preguntas[index];

            Opciones.Clear();
            Opciones.Add(PreguntaActual.Ingles);

            while (Opciones.Count < 3)
            {
                var otra = preguntas[random.Next(preguntas.Count)].Ingles;
                if (!Opciones.Contains(otra))
                    Opciones.Add(otra);
            }

            Opciones = Opciones.OrderBy(x => Guid.NewGuid()).ToList();
        }

        public override bool VerificarRespuesta(object respuesta)
        {
            string respuestaUsuario = respuesta.ToString();
            bool correcto = PreguntaActual.EsCorrecta(respuestaUsuario);

            if (correcto)
                Puntaje++;
            else
                Errores++;

            return correcto;
        }

        public bool JuegoTerminado()
        {
            return Errores >= MaxErrores || usadas.Count == preguntas.Count;
        }
    }
}
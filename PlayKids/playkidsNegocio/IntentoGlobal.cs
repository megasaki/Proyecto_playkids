using System.Collections.Generic;
using playkidsEntidades;

namespace playkidsNegocio
{
    public static class IntentoGlobal
    {
        public static List<Respuesta> Respuestas { get; private set; } = new List<Respuesta>();

        public static void Agregar(Respuesta r)
        {
            Respuestas.Add(r);
        }

        public static void Limpiar()
        {
            Respuestas.Clear();
        }

        public static int CalcularPuntaje()
        {
            int total = 0;
            foreach (var r in Respuestas)
                if (r.EsCorrecta) total++;
            return total;
        }

        public static int CalcularErrores()
        {
            return Respuestas.Count - CalcularPuntaje();
        }
    }
}
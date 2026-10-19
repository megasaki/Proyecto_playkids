namespace playkidsEntidades
{
    public class Pregunta
    {
        public string Espanol { get; set; }
        public string Ingles { get; set; }

        public Pregunta(string espanol, string ingles)
        {
            Espanol = espanol;
            Ingles = ingles;
        }

        public bool EsCorrecta(string respuesta)
        {
            return respuesta.ToLower() == Ingles.ToLower();
        }
    }
}

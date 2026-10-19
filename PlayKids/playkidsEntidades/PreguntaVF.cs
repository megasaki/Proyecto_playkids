namespace playkidsEntidades
{
    public class PreguntaVF
    {
        public string Oracion { get; set; }
        public bool EsCorrecta { get; set; }

        public PreguntaVF(string oracion, bool esCorrecta)
        {
            Oracion = oracion;
            EsCorrecta = esCorrecta;
        }
    }
}
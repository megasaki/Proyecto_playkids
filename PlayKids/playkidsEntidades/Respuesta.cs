using System;

namespace playkidsEntidades
{
    public class Respuesta
    {
        public int IdRespuesta { get; set; }
        public int IdIntento { get; set; }
        public int IdPregunta { get; set; }
        public string RespuestaUsuario { get; set; }
        public bool EsCorrecta { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;

        public Respuesta() { }

        public Respuesta(string respuestaUsuario, bool esCorrecta)
        {
            RespuestaUsuario = respuestaUsuario;
            EsCorrecta = esCorrecta;
            Fecha = DateTime.Now;
        }
    }
}

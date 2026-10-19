using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayKids.Clases
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

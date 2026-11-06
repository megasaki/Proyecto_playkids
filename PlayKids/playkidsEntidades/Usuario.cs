using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema; // <--- 1. Agrega este using

namespace playkidsEntidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public int IdRol { get; set; }

        [NotMapped] 
        public string NombreRol { get; set; }
    }
}
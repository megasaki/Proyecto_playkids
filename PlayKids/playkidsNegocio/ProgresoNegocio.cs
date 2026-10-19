using System;
using playkidsEntidades;
using playkidsDatos;

namespace playkidsNegocio
{
    public class ProgresoNegocio
    {
      
        private ProgresoDatos progresoDatos = new ProgresoDatos();

      
        public void GuardarProgreso(Progreso progreso)
        {
            
            if (progreso.Puntaje < 0)
            {
                throw new ArgumentException("El puntaje no puede ser menor a cero.");
            }

            if (progreso.IdUsuario <= 0 || progreso.IdLeccion <= 0)
            {
                throw new ArgumentException("El ID del usuario o la lección no son válidos.");
            }

            
            progresoDatos.InsertarProgreso(progreso);
        }
    }
}
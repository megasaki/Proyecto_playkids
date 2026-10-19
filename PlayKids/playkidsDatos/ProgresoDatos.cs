using System;
using System.Data;
using System.Data.SqlClient;
using playkidsEntidades;

namespace playkidsDatos
{
    public class ProgresoDatos
    {
        public void InsertarProgreso(Progreso progreso)
        {
            
            ConexionDB db = new ConexionDB();

            
            using (SqlConnection conexion = db.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("sp_GuardarProgreso", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    // Pasamos los parámetros de forma segura al Procedimiento Almacenado
                    comando.Parameters.AddWithValue("@IdUsuario", progreso.IdUsuario);
                    comando.Parameters.AddWithValue("@IdLeccion", progreso.IdLeccion);
                    comando.Parameters.AddWithValue("@Puntaje", progreso.Puntaje);
                    comando.Parameters.AddWithValue("@Errores", progreso.Errores);
                    comando.Parameters.AddWithValue("@Fecha", progreso.Fecha);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
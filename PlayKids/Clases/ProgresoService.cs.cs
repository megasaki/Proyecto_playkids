using System;
using System.Data.SqlClient;
using PlayKids.Clases;

namespace PlayKids.Servicios
{
    public class ProgresoService
    {
        private ConexionDB conexion = new ConexionDB();

        public void Guardar(Progreso progreso)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"INSERT INTO Progresos
                                (IdUsuario, IdLeccion, Puntaje, Errores)
                                VALUES
                                (@IdUsuario, @IdLeccion, @Puntaje, @Errores)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@IdUsuario", progreso.IdUsuario);
                cmd.Parameters.AddWithValue("@IdLeccion", progreso.IdLeccion);
                cmd.Parameters.AddWithValue("@Puntaje", progreso.Puntaje);
                cmd.Parameters.AddWithValue("@Errores", progreso.Errores);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
using System;
using System.Data.SqlClient;
using PlayKids.Clases;

namespace PlayKids.Servicios
{
    public class UsuarioService
    {
        private ConexionDB conexion = new ConexionDB();

        public Usuario Validar(string correo, string contrasena)
        {
            Usuario usuario = null;

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"SELECT *
                                 FROM Usuarios
                                 WHERE Correo = @correo
                                 AND Contrasena = @contrasena";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                        Nombre = reader["Nombre"].ToString(),
                        Edad = Convert.ToInt32(reader["Edad"]),
                        Sexo = reader["Sexo"].ToString(),
                        Correo = reader["Correo"].ToString(),
                        Contrasena = reader["Contrasena"].ToString()
                    };
                }
            }

            return usuario;
        }

        public bool Registrar(Usuario nuevoUsuario)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"INSERT INTO Usuarios
                                (Nombre, Edad, Sexo, Correo, Contrasena)
                                VALUES
                                (@nombre, @edad, @sexo, @correo, @contrasena)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nombre", nuevoUsuario.Nombre);
                cmd.Parameters.AddWithValue("@edad", nuevoUsuario.Edad);
                cmd.Parameters.AddWithValue("@sexo", nuevoUsuario.Sexo);
                cmd.Parameters.AddWithValue("@correo", nuevoUsuario.Correo);
                cmd.Parameters.AddWithValue("@contrasena", nuevoUsuario.Contrasena);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}

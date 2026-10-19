using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using playkidsEntidades;

namespace playkidsDatos
{
    public class UsuarioDatos
    {
        private ConexionDB db = new ConexionDB();

        public int InsertarUsuario(Usuario usuario)
        {
            using (SqlConnection conexion = db.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("sp_InsertarUsuario", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@Edad", usuario.Edad);
                    comando.Parameters.AddWithValue("@Sexo", usuario.Sexo);
                    comando.Parameters.AddWithValue("@Correo", usuario.Correo);
                    comando.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);

                    conexion.Open();

                    return (int)comando.ExecuteScalar();
                }
            }
        }

        public Usuario IniciarSesion(string correo, string contrasena)
        {
            using (SqlConnection conexion = db.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("sp_IniciarSesion", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@Correo", correo);
                    comando.Parameters.AddWithValue("@Contrasena", contrasena);

                    conexion.Open();
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            Usuario usuario = new Usuario();
                            usuario.IdUsuario = Convert.ToInt32(lector["IdUsuario"]);
                            usuario.Nombre = lector["Nombre"].ToString();
                            usuario.Edad = Convert.ToInt32(lector["Edad"]);
                            usuario.Sexo = lector["Sexo"].ToString();
                            usuario.Correo = lector["Correo"].ToString();
                            usuario.Contrasena = lector["Contrasena"].ToString();
                            return usuario;
                        }
                    }
                }
            }
            return null;
        }

        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection conexion = db.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("sp_ObtenerTodosLosUsuarios", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            lista.Add(new Usuario
                            {
                                IdUsuario = Convert.ToInt32(lector["IdUsuario"]),
                                Nombre = lector["Nombre"].ToString(),
                                Edad = Convert.ToInt32(lector["Edad"]),
                                Sexo = lector["Sexo"].ToString(),
                                Correo = lector["Correo"].ToString(),
                                Contrasena = lector["Contrasena"].ToString()
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}
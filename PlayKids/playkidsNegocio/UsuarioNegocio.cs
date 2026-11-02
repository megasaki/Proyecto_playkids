using System;
using System.Security.Cryptography;
using System.Text;
using playkidsEntidades;
using playkidsDatos;

namespace playkidsNegocio
{
    public class UsuarioNegocio
    {
        private UsuarioDatos usuarioDatos = new UsuarioDatos();

     
        private string EncriptarSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        public int RegistrarUsuario(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Nombre) ||
                string.IsNullOrWhiteSpace(usuario.Correo) ||
                string.IsNullOrWhiteSpace(usuario.Contrasena))
            {
                throw new ArgumentException("El nombre, correo y contraseña son obligatorios.");
            }

            if (usuario.Edad <= 0 || usuario.Edad > 99)
            {
                throw new ArgumentException("Por favor, ingresa una edad válida.");
            }

            if (string.IsNullOrWhiteSpace(usuario.Sexo))
            {
                throw new ArgumentException("Debe seleccionar el sexo del jugador.");
            }

           
            usuario.Contrasena = EncriptarSHA256(usuario.Contrasena);

            return usuarioDatos.InsertarUsuario(usuario);
        }

        public Usuario AutenticarUsuario(string correo, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contrasena))
            {
                throw new ArgumentException("Debe ingresar su correo y contraseña para entrar.");
            }

            // Ciframos la contraseña ingresada para que coincida con el hash almacenado en la BD
            string contrasenaCifrada = EncriptarSHA256(contrasena);

            return usuarioDatos.IniciarSesion(correo, contrasenaCifrada);
        }
    }
}
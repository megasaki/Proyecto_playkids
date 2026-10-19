using System;
using playkidsEntidades;
using playkidsDatos;

namespace playkidsNegocio
{
    public class UsuarioNegocio
    {
        private UsuarioDatos usuarioDatos = new UsuarioDatos();

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

           
            return usuarioDatos.InsertarUsuario(usuario);
        }

        public Usuario AutenticarUsuario(string correo, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contrasena))
            {
                throw new ArgumentException("Debe ingresar su correo y contraseña para entrar.");
            }

            return usuarioDatos.IniciarSesion(correo, contrasena);
        }
    }
}
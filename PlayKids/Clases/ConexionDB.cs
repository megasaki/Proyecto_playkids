using System.Data.SqlClient;

namespace PlayKids
{
    public class ConexionDB
    {
        private string cadena =
            "Server=.\\PLAYKIDS;Database=PlayKidsDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
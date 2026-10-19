using System.Data.SqlClient;

namespace playkidsDatos
{
    public class ConexionDB
    {
        
        private string cadenaConexion =
            "Server=.\\PLAYKIDS;Database=PlayKidsCapasDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
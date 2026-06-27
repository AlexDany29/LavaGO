using System.Configuration;
using System.Data.SqlClient;

namespace LavaGO
{
    public class ConexionBD
    {
        public static SqlConnection ObtenerConexion()
        {
            string cadena = ConfigurationManager.ConnectionStrings["LavaGO_BD"].ConnectionString;
            return new SqlConnection(cadena);
        }
    }
}
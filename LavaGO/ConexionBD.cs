using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaGO
{
    public class ConexionBD
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(
                "Data Source=.;Initial Catalog=LavaGO_BD;Integrated Security=True"
            );

            return cn;
        }
    }
}

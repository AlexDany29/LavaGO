using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LavaGO.Clase
{
    public class VentaDAO
    {
        public static List<Venta> Listar()
        {
            List<Venta> lista = new List<Venta>();

            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand("SP_ListarVentas", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Venta v = new Venta
                            {
                                Codigo = dr["Codigo"].ToString(),
                                Fecha = Convert.ToDateTime(dr["Fecha"]),
                                Cliente = dr["Cliente"].ToString(),
                                Servicio = dr["Servicio"].ToString(),
                                Peso = Convert.ToDecimal(dr["Peso"]),
                                Detalle = Convert.ToDecimal(dr["Detalle"]),
                                ImporteTotal = Convert.ToDecimal(dr["ImporteTotal"]),
                                Estado = dr["Estado"].ToString(),
                                FechaEntrega = Convert.ToDateTime(dr["FechaEntrega"])
                            };

                            lista.Add(v);
                        }
                    }
                }
            }

            return lista;
        }

        public static void Insertar(Venta v)
        {
            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand("SP_InsertarVenta", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Codigo", v.Codigo);
                    cmd.Parameters.AddWithValue("@Fecha", v.Fecha);
                    cmd.Parameters.AddWithValue("@Cliente", v.Cliente);
                    cmd.Parameters.AddWithValue("@Servicio", v.Servicio);
                    cmd.Parameters.AddWithValue("@Peso", v.Peso);
                    cmd.Parameters.AddWithValue("@Detalle", v.Detalle);
                    cmd.Parameters.AddWithValue("@ImporteTotal", v.ImporteTotal);
                    cmd.Parameters.AddWithValue("@Estado", v.Estado);
                    cmd.Parameters.AddWithValue("@FechaEntrega", v.FechaEntrega);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Actualizar(Venta v)
        {
            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand("SP_ActualizarVenta", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Codigo", v.Codigo);
                    cmd.Parameters.AddWithValue("@Fecha", v.Fecha);
                    cmd.Parameters.AddWithValue("@Cliente", v.Cliente);
                    cmd.Parameters.AddWithValue("@Servicio", v.Servicio);
                    cmd.Parameters.AddWithValue("@Peso", v.Peso);
                    cmd.Parameters.AddWithValue("@Detalle", v.Detalle);
                    cmd.Parameters.AddWithValue("@ImporteTotal", v.ImporteTotal);
                    cmd.Parameters.AddWithValue("@Estado", v.Estado);
                    cmd.Parameters.AddWithValue("@FechaEntrega", v.FechaEntrega);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static bool Eliminar(string codigo)
        {
            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand("SP_EliminarVenta", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo", codigo);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
            }
        }

        public static int ObtenerSiguienteCodigo()
        {
            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand("SP_GenerarCodigoVenta", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    string codigo = cmd.ExecuteScalar().ToString(); // Ejemplo: LVG006
                    return int.Parse(codigo.Substring(3));
                }
            }
        }
    }
}
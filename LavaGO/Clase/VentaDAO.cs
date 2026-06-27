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
                SqlCommand cmd = new SqlCommand("SP_ListarVentas", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Venta v = new Venta();
                    v.Codigo = dr["Codigo"].ToString();
                    v.Fecha = Convert.ToDateTime(dr["Fecha"]);
                    v.Cliente = dr["Cliente"].ToString();
                    v.Servicio = dr["Servicio"].ToString();
                    v.Peso = Convert.ToDecimal(dr["Peso"]);
                    v.Detalle = Convert.ToDecimal(dr["Detalle"]);
                    v.ImporteTotal = Convert.ToDecimal(dr["ImporteTotal"]);
                    v.Estado = dr["Estado"].ToString();
                    v.FechaEntrega = Convert.ToDateTime(dr["FechaEntrega"]);

                    lista.Add(v);
                }
            }

            return lista;
        }

        public static void Insertar(Venta v)
        {
            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_InsertarVenta", cn);
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

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void Actualizar(Venta v)
        {
            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_ActualizarVenta", cn);
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

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void Eliminar(string codigo)
        {
            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_EliminarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Codigo", codigo);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static string GenerarCodigo()
        {
            string codigo = "";

            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_GenerarCodigoVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                codigo = cmd.ExecuteScalar().ToString();
            }

            return codigo;
        }

        public static List<Venta> Ultimas3Ventas()
        {
            List<Venta> lista = new List<Venta>();

            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Ultimas3Ventas", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Venta v = new Venta();
                    v.Codigo = dr["Codigo"].ToString();
                    v.Fecha = Convert.ToDateTime(dr["Fecha"]);
                    v.Cliente = dr["Cliente"].ToString();
                    v.Servicio = dr["Servicio"].ToString();
                    v.Peso = Convert.ToDecimal(dr["Peso"]);
                    v.Detalle = Convert.ToDecimal(dr["Detalle"]);
                    v.ImporteTotal = Convert.ToDecimal(dr["ImporteTotal"]);
                    v.Estado = dr["Estado"].ToString();
                    v.FechaEntrega = Convert.ToDateTime(dr["FechaEntrega"]);

                    lista.Add(v);
                }
            }

            return lista;
        }
    }
}
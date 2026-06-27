using System.Collections.Generic;
using System.Linq;
using System;

namespace LavaGO.Clase
{
    public class VentaDAO
    {
        private static List<Venta> listaVentas = new List<Venta>();
        private static readonly object _lock = new object();

        public static List<Venta> Listar()
        {
            lock (_lock)
            {
                return listaVentas;
            }
        }

        public static void Insertar(Venta v)
        {
            if (v == null) return;
            lock (_lock)
            {
                listaVentas.Add(v);
            }
        }

        public static int ObtenerSiguienteCodigo()
        {
            lock (_lock)
            {
                if (listaVentas == null || listaVentas.Count == 0) return 1;

                int maxNumero = 0;
                foreach (var v in listaVentas)
                {
                    if (string.IsNullOrEmpty(v?.Codigo)) continue;
                    string[] partes = v.Codigo.Split('-');
                    if (partes.Length > 1 && int.TryParse(partes[1], out int numero))
                    {
                        if (numero > maxNumero) maxNumero = numero;
                    }
                }
                return maxNumero + 1;
            }
        }

        public static void Actualizar(Venta v)
        {
            if (v == null) return;
            lock (_lock)
            {
                var existente = listaVentas.FirstOrDefault(x => x.Codigo == v.Codigo);
                if (existente != null)
                {
                    existente.Fecha = v.Fecha;
                    existente.FechaEntrega = v.FechaEntrega;
                    existente.Cliente = v.Cliente;
                    existente.Servicio = v.Servicio;
                    existente.Peso = v.Peso;
                    existente.Detalle = v.Detalle;
                    existente.ImporteTotal = v.ImporteTotal;
                    existente.Estado = v.Estado;
                }
            }
        }

        // Nuevo: elimina la venta por código. Devuelve true si eliminó algo.
        public static bool Eliminar(string codigo)
        {
            if (string.IsNullOrEmpty(codigo)) return false;
            lock (_lock)
            {
                var existente = listaVentas.FirstOrDefault(x => x.Codigo == codigo);
                if (existente != null)
                {
                    return listaVentas.Remove(existente);
                }
                return false;
            }
        }
    }
}
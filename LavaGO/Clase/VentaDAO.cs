using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaGO.Clase
{
    public class VentaDAO
    {
        public static List<Venta> lista = new List<Venta>();
        static VentaDAO()
        {
            for (int i = 1; i <= 50; i++)
            {
                DateTime fechaRegistro = DateTime.Now.AddDays(-i);
                string estadoSimulado = "Lavado";
                if (i % 3 == 0) estadoSimulado = "Secado";
                else if (i % 3 == 1) estadoSimulado = "Listo para entregar";

                lista.Add(new Venta
                {
                    Codigo = "LVG" + i.ToString("000"),
                    Fecha = fechaRegistro,
                    Cliente = "Cliente Simulado " + i,
                    Servicio = (i % 2 == 0) ? "Por peso" : "Prendas delicadas",
                    Peso = 3.5m + (i % 5),
                    Detalle = (i % 2 == 0) ? 5.00m : 7.50m,
                    ImporteTotal = (3.5m + (i % 5)) * ((i % 2 == 0) ? 5.00m : 7.50m),
                    Estado = estadoSimulado,
                    FechaEntrega = fechaRegistro.AddDays(2)
                });
            }
        }
        public static List<Venta> Listar() => lista;
        public static void Insertar(Venta v) => lista.Add(v);
        public static void Actualizar(Venta v)
        {
            var item = lista.FirstOrDefault(x => x.Codigo == v.Codigo);
            if (item != null)
            {
                item.Fecha = v.Fecha;
                item.Cliente = v.Cliente;
                item.Servicio = v.Servicio;
                item.Peso = v.Peso;
                item.Detalle = v.Detalle;
                item.ImporteTotal = v.ImporteTotal;
                item.Estado = v.Estado;
                item.FechaEntrega = v.FechaEntrega;
            }
        }
        public static void Eliminar(string codigo)
        {
            var item = lista.FirstOrDefault(x => x.Codigo == codigo);
            if (item != null) lista.Remove(item);
        }
    }
}

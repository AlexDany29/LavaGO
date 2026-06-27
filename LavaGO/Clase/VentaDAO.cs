using System;
using System.Collections.Generic;

namespace LavaGO.Clase
{
    public class VentaDAO
    {
        // Método que reemplaza la conexión a BD por una generación local
        public static List<Venta> Listar()
        {
            List<Venta> lista = new List<Venta>();
            Random rnd = new Random();

            string[] servicios = { "Por peso", "Prendas delicadas" };
            string[] estados = { "Lavado", "Secado", "Listo para entregar" };
            string[] clientes = { "Juan Perez", "Maria Lopez", "Carlos Ruiz", "Ana Gomez", "Luis Torres" };

            for (int i = 1; i <= 100; i++)
            {
                decimal peso = (decimal)(rnd.Next(1, 20) + rnd.NextDouble());
                decimal precio = (i % 2 == 0) ? 5.00m : 7.50m;

                lista.Add(new Venta
                {
                    Codigo = "V-" + i.ToString("D3"),
                    Fecha = DateTime.Now.AddDays(-rnd.Next(0, 30)),
                    Cliente = clientes[rnd.Next(clientes.Length)],
                    Servicio = servicios[rnd.Next(servicios.Length)],
                    Peso = Math.Round(peso, 2),
                    Detalle = precio,
                    ImporteTotal = Math.Round(peso * precio, 2),
                    Estado = estados[rnd.Next(estados.Length)],
                    FechaEntrega = DateTime.Now.AddDays(rnd.Next(1, 5))
                });
            }

            return lista;
        }

        // Métodos vacíos o simplificados para evitar errores de compilación
        public static void Insertar(Venta v) { /* Simulación: no hace nada */ }
        public static void Actualizar(Venta v) { /* Simulación: no hace nada */ }
        public static void Eliminar(string codigo) { /* Simulación: no hace nada */ }
        public static string GenerarCodigo() { return "V-101"; }
        public static List<Venta> Ultimas3Ventas() { return Listar().GetRange(0, 3); }
    }
}
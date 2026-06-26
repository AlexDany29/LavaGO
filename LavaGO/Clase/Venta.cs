using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaGO.Clase
{
    public class Venta
    {
        public string Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Servicio { get; set; }
        public decimal Peso { get; set; }
        public decimal Detalle { get; set; }
        public decimal ImporteTotal { get; set; }
        public string Estado { get; set; }
        public DateTime FechaEntrega { get; set; }
    }
}

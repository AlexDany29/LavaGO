using System;
using System.Windows.Forms;
using LavaGO.Clase;
using LavaGO.Botones;
using System.Linq;

namespace LavaGO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio ventanaInicio = new Inicio();
            ventanaInicio.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BotonAgregar().ShowDialog();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BotonActualizar(null).ShowDialog();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Buscar().ShowDialog();
        }

        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormInformacion().ShowDialog();
        }

        private void precioServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TARIFARIO DE SERVICIOS:\n\n" +
                            "• Por peso: S/. 5.00\n" +
                            "• Prendas delicadas: S/. 7.50",
                            "Precios de Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void reporteVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporte = "REPORTE DE LAS 3 ÚLTIMAS VENTAS:\n\n";
            var lista = VentaDAO.Listar();
            var ultimas = lista.OrderByDescending(v => v.Fecha).Take(3).ToList();

            foreach (var v in ultimas)
            {
                reporte += $"Código: {v.Codigo} | Cliente: {v.Cliente} | Total: S/. {v.ImporteTotal:0.00}\n";
            }
            MessageBox.Show(reporte, "Reporte de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void informacionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormInformacion ventanaInfo = new FormInformacion();
            ventanaInfo.ShowDialog();
        }
    }
}

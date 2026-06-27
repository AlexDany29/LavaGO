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

            // Asegurar que el menú "Eliminar" llame al manejador
            this.eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
        }

        private void inicioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is Inicio ventanaAbierta)
                {
                    ventanaAbierta.MostrarDatos();
                    ventanaAbierta.Focus();
                    return;
                }
            }

            Inicio ventanaInicio = new Inicio();
            ventanaInicio.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            BotonAgregar ventana = new BotonAgregar();
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f is Inicio ventanaInicio)
                    {
                        ventanaInicio.MostrarDatos();
                    }
                }
            }
        }

        private void reporteVentasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var lista = VentaDAO.Listar();

            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("No hay ventas registradas para generar el reporte.", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var ultimas = lista.OrderByDescending(v => v.Fecha).Take(3).ToList();
            string reporte = "REPORTE DE LAS 3 ÚLTIMAS VENTAS:\n\n";

            foreach (var v in ultimas)
            {
                reporte += $"Código: {v.Codigo} | Cliente: {v.Cliente} | Total: S/. {v.ImporteTotal:0.00}\n";
            }

            MessageBox.Show(reporte, "Reporte de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void precioServiciosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("TARIFARIO DE SERVICIOS:\n\n" +
                            "• Por peso: S/. 5.00\n" +
                            "• Prendas delicadas: S/. 7.50",
                            "Precios de Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void actualizarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is Inicio ventanaInicio)
                {
                    var ventaSeleccionada = ventanaInicio.ObtenerVentaSeleccionada();
                    if (ventaSeleccionada == null)
                    {
                        MessageBox.Show("Seleccione un registro en la ventana Inicio para actualizar.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ventanaInicio.Focus();
                        return;
                    }

                    using (var dlg = new BotonActualizar(ventaSeleccionada))
                    {
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            ventanaInicio.MostrarDatos();
                        }
                    }
                    return;
                }
            }

            MessageBox.Show("Abra la ventana Inicio y seleccione un registro para actualizar.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buscarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new Buscar().ShowDialog();
        }

        // Nuevo: manejador para el menú Eliminar.
        private void eliminarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (var dlg = new Eliminar()) 
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f is Inicio inicio)
                        {
                            inicio.MostrarDatos();
                        }
                    }
                }
            }
        }

        
        private void horarioDeAtencionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHorario frm = new FormHorario();
            frm.ShowDialog();
        }
    }
}

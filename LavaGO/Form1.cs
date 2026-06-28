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

            this.eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            this.actualizarToolStripMenuItem.Click += actualizarToolStripMenuItem_Click;
            this.MnuListos.Click += listoParaEntregarToolStripMenuItem_Click;
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

        private void reporteVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportedeVentas frm = new ReportedeVentas();
            frm.ShowDialog();
        }

        private void precioServiciosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormPrecios frm = new FormPrecios();
            frm.ShowDialog();
        }

        private void actualizarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is BotonActualizar ventanaAbierta)
                {
                    ventanaAbierta.Focus();
                    return;
                }
            }

            BotonActualizar ventana = new BotonActualizar();
            ventana.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new Buscar().ShowDialog();
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new Eliminar())
            {
                dlg.ShowDialog();
            }
        }

        private void listoParaEntregarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is ListosEntregar ventanaAbierta)
                {
                    ventanaAbierta.Focus();
                    return;
                }
            }

            ListosEntregar ventana = new ListosEntregar();
            ventana.Show();
        }
        private void historiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistoria frm = new FormHistoria();
            frm.ShowDialog();
        }

        private void horarioDeAtencionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHorario frm = new FormHorario();
            frm.ShowDialog();
        }

        private void misiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMision frm = new FormMision();
            frm.ShowDialog();
        }

        private void visiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVision frm = new FormVision();
            frm.ShowDialog();
        }

        private void redesSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRedes frm = new FormRedes();
            frm.ShowDialog();
        }

        private void contactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInformacion frm = new FormInformacion();
            frm.ShowDialog();
        }
    }
}

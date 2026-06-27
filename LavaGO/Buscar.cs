using LavaGO.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LavaGO
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();

            cboOpciones.Items.Clear();
            cboOpciones.Items.Add("Código");
            cboOpciones.Items.Add("Nombre");

            cboOpciones.SelectedIndex = 0;
        }

        private void btnIngresarBusqueda_Click(object sender, EventArgs e)
        {
            string criterio = txtBusqueda.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(criterio))
            {
                MessageBox.Show("Por favor, ingrese un término para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var listaCompleta = VentaDAO.Listar();
            string opcionSeleccionada = cboOpciones.SelectedItem?.ToString();

            // Filtra dinámicamente según la opción elegida en el ComboBox
            var resultados = listaCompleta.Where(v =>
                (opcionSeleccionada == "Código" && v.Codigo.ToString().ToLower().Contains(criterio)) ||
                (opcionSeleccionada == "Nombre" && v.Cliente.ToLower().Contains(criterio))
            ).ToList();

            dgvBusqueda.DataSource = null;
            dgvBusqueda.DataSource = resultados;

            if (resultados.Count == 0)
            {
                MessageBox.Show("No se encontraron registros que coincidan con la búsqueda.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

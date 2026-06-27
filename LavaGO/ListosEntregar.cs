using System;
using System.Linq;
using System.Windows.Forms;
using LavaGO.Clase;

namespace LavaGO
{
    public partial class ListosEntregar : Form
    {
        public ListosEntregar()
        {
            InitializeComponent();
            this.Load += ListosEntregar_Load;
        }

        private void ListosEntregar_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarDatos();
        }

        private void ConfigurarDataGridView()
        {
            if (dgvListos == null) return;

            dgvListos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListos.MultiSelect = false;
            dgvListos.ReadOnly = true;
            dgvListos.AllowUserToAddRows = false;
        }

        private void CargarDatos()
        {
            if (dgvListos == null) return;

            // Filtrar solo ventas cuyo Estado indica que están listas para entregar.
            var todas = VentaDAO.Listar() ?? new System.Collections.Generic.List<Venta>();
            var listos = todas
                .Where(v => !string.IsNullOrEmpty(v?.Estado) &&
                            (v.Estado.Equals("Listo", StringComparison.OrdinalIgnoreCase)
                             || v.Estado.Equals("Listo para entregar", StringComparison.OrdinalIgnoreCase)
                             || v.Estado.IndexOf("listo", StringComparison.OrdinalIgnoreCase) >= 0))
                .ToList();

            dgvListos.DataSource = null;
            dgvListos.DataSource = listos;
            dgvListos.Refresh();
        }
    }
}

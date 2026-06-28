using System;
using System.Linq;
using System.Windows.Forms;
using LavaGO.Clase;

namespace LavaGO
{
    public partial class ReportedeVentas : Form
    {
        public ReportedeVentas()
        {
            InitializeComponent();

            this.Load += ReportedeVentas_Load;

            btnFiltrar.Click += btnFiltrar_Click;
            btnMostrarTodo.Click += btnMostrarTodo_Click;
            btnFiltrarEstado.Click += btnFiltrarEstado_Click;
            btnLimpiarFiltros.Click += btnLimpiarFiltros_Click;
            btnCerrar.Click += btnCerrar_Click;
        }

        private void ReportedeVentas_Load(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Today.AddDays(-30);
            dtpFechaFin.Value = DateTime.Today;

            cboEstado.Items.Clear();
            cboEstado.Items.Add("Estado de Servicio");
            cboEstado.Items.Add("Pendiente");
            cboEstado.Items.Add("En proceso");
            cboEstado.Items.Add("Listo para entregar");
            cboEstado.Items.Add("Entregado");
            cboEstado.SelectedIndex = 0;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            CargarTodasLasVentas();
        }

        private void CargarTodasLasVentas()
        {
            var ventas = VentaDAO.Listar()
                .OrderByDescending(v => v.Fecha)
                .ThenByDescending(v => v.Codigo)
                .ToList();

            MostrarEnGrid(ventas);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btnFiltrarEstado_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            DateTime inicio = dtpFechaInicio.Value.Date;
            DateTime fin = dtpFechaFin.Value.Date;

            if (inicio > fin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final.",
                    "Filtro de fechas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var ventas = VentaDAO.Listar()
                .Where(v => v.Fecha.Date >= inicio && v.Fecha.Date <= fin);

            if (cboEstado.SelectedItem != null && cboEstado.SelectedItem.ToString() != "Todos")
            {
                string estado = cboEstado.SelectedItem.ToString();
                ventas = ventas.Where(v => v.Estado == estado);
            }

            var resultado = ventas
                .OrderByDescending(v => v.Fecha)
                .ThenByDescending(v => v.Codigo)
                .ToList();

            MostrarEnGrid(resultado);
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            CargarTodasLasVentas();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Today.AddDays(-30);
            dtpFechaFin.Value = DateTime.Today;
            cboEstado.SelectedIndex = 0;

            CargarTodasLasVentas();
        }

        private void MostrarEnGrid(object datos)
        {
            dgvReporteDeVentas.DataSource = null;
            dgvReporteDeVentas.DataSource = datos;

            dgvReporteDeVentas.ReadOnly = true;
            dgvReporteDeVentas.AllowUserToAddRows = false;
            dgvReporteDeVentas.AllowUserToDeleteRows = false;
            dgvReporteDeVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporteDeVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvReporteDeVentas.Columns.Count > 0)
            {
                dgvReporteDeVentas.Columns["Codigo"].HeaderText = "Código";
                dgvReporteDeVentas.Columns["Fecha"].HeaderText = "Fecha";
                dgvReporteDeVentas.Columns["Cliente"].HeaderText = "Cliente";
                dgvReporteDeVentas.Columns["Servicio"].HeaderText = "Servicio";
                dgvReporteDeVentas.Columns["Peso"].HeaderText = "Peso";
                dgvReporteDeVentas.Columns["Detalle"].HeaderText = "Precio";
                dgvReporteDeVentas.Columns["ImporteTotal"].HeaderText = "Importe Total";
                dgvReporteDeVentas.Columns["Estado"].HeaderText = "Estado";
                dgvReporteDeVentas.Columns["FechaEntrega"].HeaderText = "Fecha Entrega";

                dgvReporteDeVentas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvReporteDeVentas.Columns["FechaEntrega"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvReporteDeVentas.Columns["Peso"].DefaultCellStyle.Format = "0.00";
                dgvReporteDeVentas.Columns["Detalle"].DefaultCellStyle.Format = "0.00";
                dgvReporteDeVentas.Columns["ImporteTotal"].DefaultCellStyle.Format = "0.00";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
using LavaGO.Clase;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace LavaGO
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

            this.Load += Inicio_Load;
            this.Activated += Inicio_Activated;

            // Inicializar los items de los ComboBox para que puedan mostrar el Estado/Servicio
            InicializarCombos();

            // Suscribir el evento de selección del DataGridView
            this.dgvCliente.SelectionChanged += DgvCliente_SelectionChanged;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void Inicio_Activated(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void InicializarCombos()
        {
            cboServicioBusqueda.Items.Clear();
            cboServicioBusqueda.Items.AddRange(new string[] { "Por peso", "Prendas delicadas" });
            cboServicioBusqueda.Enabled = false;

            cboEstado.Items.Clear();
            // Se añade "Listo para entregar" como tercera opción (índice 2)
            cboEstado.Items.AddRange(new string[] { "Pendiente", "En proceso", "Listo para entregar", "Entregado" });
            cboEstado.Enabled = false;
        }

        public void MostrarDatos()
        {
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = VentaDAO.Listar();

            if (dgvCliente.Columns.Count > 8)
            {
                dgvCliente.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy"; // Fecha
                dgvCliente.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy"; // FechaEntrega
            }

            // Seleccionar la primera fila por defecto (si existe) para mostrar datos en los recuadros
            if (dgvCliente.Rows.Count > 0)
            {
                dgvCliente.ClearSelection();
                dgvCliente.Rows[0].Selected = true;
                ActualizarCamposDesdeSeleccion();
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void DgvCliente_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarCamposDesdeSeleccion();
        }

        private void ActualizarCamposDesdeSeleccion()
        {
            if (dgvCliente == null || dgvCliente.SelectedRows == null || dgvCliente.SelectedRows.Count == 0)
            {
                LimpiarCampos();
                return;
            }

            var venta = dgvCliente.SelectedRows[0].DataBoundItem as Venta;
            if (venta == null)
            {
                LimpiarCampos();
                return;
            }

            // Rellenar controles (usar la cultura actual para formato numérico)
            txtCodigo.Text = venta.Codigo ?? string.Empty;
            dtpFecha.Value = venta.Fecha == default ? DateTime.Now : venta.Fecha;
            txtCliente.Text = venta.Cliente ?? string.Empty;
            SetComboValue(cboServicioBusqueda, venta.Servicio);
            txtPeso.Text = venta.Peso.ToString("F2", CultureInfo.CurrentCulture);
            txtDetalle.Text = venta.Detalle.ToString("F2", CultureInfo.CurrentCulture);
            txtImporteTotal.Text = venta.ImporteTotal.ToString("F2", CultureInfo.CurrentCulture);
            SetComboValue(cboEstado, venta.Estado);
            dtpFechaEntrega.Value = venta.FechaEntrega == default ? DateTime.Now : venta.FechaEntrega;
        }

        private void SetComboValue(ComboBox combo, string value)
        {
            if (combo == null) return;

            if (string.IsNullOrEmpty(value))
            {
                combo.SelectedIndex = -1;
                return;
            }

            // Si el valor ya existe lo seleccionamos, si no lo añadimos temporalmente para que se muestre
            if (combo.Items.Contains(value))
            {
                combo.SelectedItem = value;
            }
            else
            {
                combo.Items.Add(value);
                combo.SelectedItem = value;
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = string.Empty;
            dtpFecha.Value = DateTime.Now;
            txtCliente.Text = string.Empty;
            cboServicioBusqueda.SelectedIndex = -1;
            txtPeso.Text = string.Empty;
            txtDetalle.Text = string.Empty;
            txtImporteTotal.Text = string.Empty;
            cboEstado.SelectedIndex = -1;
            dtpFechaEntrega.Value = DateTime.Now;
        }

        // Método auxiliar público (mantengo compatibilidad con usos previos)
        public Venta ObtenerVentaSeleccionada()
        {
            if (dgvCliente == null) return null;
            if (dgvCliente.SelectedRows == null || dgvCliente.SelectedRows.Count == 0) return null;
            return dgvCliente.SelectedRows[0].DataBoundItem as Venta;
        }
    }
}
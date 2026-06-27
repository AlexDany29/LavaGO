using System;
using System.Windows.Forms;
using System.Globalization;
using LavaGO.Clase;
using System.Linq;

namespace LavaGO.Botones
{
    public partial class BotonActualizar : Form
    {
        private Venta ventaAEditar;

        public BotonActualizar()
        {
            InitializeComponent();
            AsignarEventos();
        }

        public BotonActualizar(Venta ventaSeleccionada)
        {
            InitializeComponent();
            AsignarEventos();
            this.ventaAEditar = ventaSeleccionada;
        }

        private void AsignarEventos()
        {
            this.Load += BotonActualizar_Load;
            cboServicioBusqueda.SelectedIndexChanged += cboServicioBusqueda_SelectedIndexChanged;
            txtPeso.TextChanged += txtPeso_TextChanged;
            txtPeso.KeyPress += txtPeso_KeyPress;
            txtPeso.Leave += txtPeso_Leave;
            btnActualizar.Click += btnActualizar_Click;

            if (dgvActualizar != null)
                dgvActualizar.SelectionChanged += DgvActualizar_SelectionChanged;
        }

        private void BotonActualizar_Load(object sender, EventArgs e)
        {
            cboServicioBusqueda.Items.Clear();
            cboServicioBusqueda.Items.AddRange(new string[] { "Por peso", "Prendas delicadas" });

            cboEstado.Items.Clear();
            cboEstado.Items.AddRange(new string[] { "Pendiente", "En proceso", "Listo para entregar", "Entregado" });

            if (dgvActualizar != null)
            {
                ConfigurarDataGridView();
                CargarGrid();
            }
            if (ventaAEditar != null)
            {
                SeleccionarVentaEnGrid(ventaAEditar.Codigo);
                CargarCamposDesdeVenta(ventaAEditar);
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvActualizar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActualizar.MultiSelect = false;
            dgvActualizar.ReadOnly = true;
            dgvActualizar.AllowUserToAddRows = false;
            dgvActualizar.AutoGenerateColumns = true;
        }

        private void CargarGrid()
        {
            var lista = VentaDAO.Listar() ?? new System.Collections.Generic.List<Venta>();
            dgvActualizar.DataSource = null;
            dgvActualizar.DataSource = lista;
            if (dgvActualizar.Columns.Count > 1)
            {
                for (int i = 0; i < dgvActualizar.Columns.Count; i++)
                {
                    var colName = dgvActualizar.Columns[i].Name.ToLowerInvariant();
                    if (colName.Contains("fecha"))
                        dgvActualizar.Columns[i].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
            }
        }

        private void DgvActualizar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvActualizar == null) return;
            if (dgvActualizar.SelectedRows == null || dgvActualizar.SelectedRows.Count == 0) return;

            var venta = dgvActualizar.SelectedRows[0].DataBoundItem as Venta;
            if (venta == null) return;

            ventaAEditar = venta;
            CargarCamposDesdeVenta(venta);
        }

        private void SeleccionarVentaEnGrid(string codigo)
        {
            if (dgvActualizar == null || string.IsNullOrEmpty(codigo)) return;
            foreach (DataGridViewRow row in dgvActualizar.Rows)
            {
                var v = row.DataBoundItem as Venta;
                if (v != null && v.Codigo == codigo)
                {
                    row.Selected = true;
                    dgvActualizar.CurrentCell = row.Cells[0];
                    return;
                }
            }
        }

        private void CargarCamposDesdeVenta(Venta venta)
        {
            if (venta == null) return;

            txtCodigo.Text = venta.Codigo;
            dtpFecha.Value = venta.Fecha == default ? DateTime.Now : venta.Fecha;
            dtpFechaEntrega.Value = venta.FechaEntrega == default ? DateTime.Now : venta.FechaEntrega;
            txtCliente.Text = venta.Cliente;
            cboServicioBusqueda.Text = venta.Servicio;
            cboEstado.Text = venta.Estado;
            txtPeso.Text = venta.Peso.ToString("F2", CultureInfo.CurrentCulture);
            txtDetalle.Text = venta.Detalle.ToString("F2", CultureInfo.CurrentCulture);
            txtImporteTotal.Text = venta.ImporteTotal.ToString("F2", CultureInfo.CurrentCulture);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ventaAEditar == null)
            {
                MessageBox.Show("No hay ningún registro seleccionado para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("El campo Cliente no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return;
            }

            if (!decimal.TryParse(txtPeso.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal pesoValido) || pesoValido <= 0)
            {
                MessageBox.Show("Ingrese un peso válido mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeso.Focus();
                return;
            }

            if (!decimal.TryParse(txtDetalle.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal detalleValido))
            {
                MessageBox.Show("El campo Detalle no tiene un formato numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtImporteTotal.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal totalValido))
            {
                MessageBox.Show("El campo Importe Total no tiene un formato numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ventaAEditar.Fecha = dtpFecha.Value;
            ventaAEditar.FechaEntrega = dtpFechaEntrega.Value;
            ventaAEditar.Cliente = txtCliente.Text.Trim();
            ventaAEditar.Servicio = cboServicioBusqueda.Text;
            ventaAEditar.Estado = cboEstado.Text;
            ventaAEditar.Peso = pesoValido;
            ventaAEditar.Detalle = detalleValido;
            ventaAEditar.ImporteTotal = totalValido;

            VentaDAO.Actualizar(ventaAEditar);

            CargarGrid();

            MessageBox.Show("El registro se actualizó correctamente.", "LavaGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cboServicioBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularImporteTotal();
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            CalcularImporteTotal();
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != decimalSeparator)
            {
                e.Handled = true;
            }

            if (e.KeyChar == decimalSeparator && (sender as TextBox).Text.IndexOf(decimalSeparator) > -1)
            {
                e.Handled = true;
            }
        }

        private void txtPeso_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPeso.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal peso))
            {
                txtPeso.Text = peso.ToString("F2", CultureInfo.CurrentCulture);
            }
        }

        private void CalcularImporteTotal()
        {
            decimal precioPorKilo = (cboServicioBusqueda.Text == "Prendas delicadas") ? 7.50m : 5.00m;

            if (decimal.TryParse(txtPeso.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal peso))
            {
                decimal total = peso * precioPorKilo;
                txtDetalle.Text = precioPorKilo.ToString("F2", CultureInfo.CurrentCulture);
                txtImporteTotal.Text = total.ToString("F2", CultureInfo.CurrentCulture);
            }
            else
            {
                txtDetalle.Text = precioPorKilo.ToString("F2", CultureInfo.CurrentCulture);
                txtImporteTotal.Text = 0m.ToString("F2", CultureInfo.CurrentCulture);
            }
        }
    }
}

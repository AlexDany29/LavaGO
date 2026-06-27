using LavaGO.Clase;
using System;
using System.Windows.Forms;
using System.Globalization;

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
        }

        private void BotonActualizar_Load(object sender, EventArgs e)
        {
            cboServicioBusqueda.Items.Clear();
            cboServicioBusqueda.Items.AddRange(new string[] { "Por peso", "Prendas delicadas" });

            cboEstado.Items.Clear();
            cboEstado.Items.AddRange(new string[] { "Pendiente", "En proceso", "Entregado" });

            if (ventaAEditar != null)
            {
                txtCodigo.Text = ventaAEditar.Codigo;
                dtpFecha.Value = ventaAEditar.Fecha;
                dtpFechaEntrega.Value = ventaAEditar.FechaEntrega;
                txtCliente.Text = ventaAEditar.Cliente;
                cboServicioBusqueda.Text = ventaAEditar.Servicio;
                cboEstado.Text = ventaAEditar.Estado;
                txtPeso.Text = ventaAEditar.Peso.ToString("F2", CultureInfo.CurrentCulture);
                txtDetalle.Text = ventaAEditar.Detalle.ToString("F2", CultureInfo.CurrentCulture);
                txtImporteTotal.Text = ventaAEditar.ImporteTotal.ToString("F2", CultureInfo.CurrentCulture);
            }
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

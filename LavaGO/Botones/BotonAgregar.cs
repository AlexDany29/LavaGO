using System;
using System.Windows.Forms;
using System.Globalization;
using LavaGO.Clase;

namespace LavaGO.Botones
{
    public partial class BotonAgregar : Form
    {
        public BotonAgregar()
        {
            InitializeComponent();

            this.Load += BotonAgregar_Load;
            this.txtPeso.TextChanged += (s, e) => CalcularImporteTotal();
            this.cboServicioBusqueda.SelectedIndexChanged += (s, e) => CalcularImporteTotal();
            // Aceptar separador decimal según cultura actual en el KeyPress del peso si existe
            this.txtPeso.KeyPress += (s, e) =>
            {
                char decimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != decimalSeparator)
                {
                    e.Handled = true;
                }
                if (e.KeyChar == decimalSeparator && (s as TextBox).Text.IndexOf(decimalSeparator) > -1)
                {
                    e.Handled = true;
                }
            };
        }

        private void BotonAgregar_Load(object sender, EventArgs e)
        {
            int siguienteCodigo = VentaDAO.ObtenerSiguienteCodigo();
            txtCodigo.Text = "V-" + siguienteCodigo.ToString("D3");
            txtCodigo.ReadOnly = true;

            cboServicioBusqueda.Items.Clear();
            cboServicioBusqueda.Items.AddRange(new string[] { "Por peso", "Prendas delicadas" });
            cboServicioBusqueda.SelectedIndex = 0;

            cboEstado.Items.Clear();
            cboEstado.Items.AddRange(new string[] { "Pendiente", "En proceso", "Entregado" });
            cboEstado.SelectedIndex = 0;

            CalcularImporteTotal();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente.");
                return;
            }

            if (!decimal.TryParse(txtPeso.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal peso) || peso <= 0)
            {
                MessageBox.Show("Ingrese un peso válido.");
                return;
            }

            // Parse seguro de detalle e importe total usando cultura actual
            decimal detalle = 0m;
            decimal importeTotal = 0m;
            decimal.TryParse(txtDetalle.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out detalle);
            decimal.TryParse(txtImporteTotal.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out importeTotal);

            Venta nuevaVenta = new Venta
            {
                Codigo = txtCodigo.Text,
                Fecha = dtpFecha.Value,
                FechaEntrega = dtpFechaEntrega.Value,
                Cliente = txtCliente.Text.Trim(),
                Servicio = cboServicioBusqueda.Text,
                Estado = cboEstado.Text,
                Peso = peso,
                Detalle = detalle,
                ImporteTotal = importeTotal
            };

            VentaDAO.Insertar(nuevaVenta);

            MessageBox.Show("Registro guardado con éxito.");
            this.DialogResult = DialogResult.OK;
            this.Close();
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

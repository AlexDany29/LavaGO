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

        // Constructor que recibe la fila seleccionada desde el Form1
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

            // CORREGIDO: Enlazado al nuevo nombre del botón "btnActualizar"
            btnActualizar.Click += btnActualizar_Click;
        }

        private void BotonActualizar_Load(object sender, EventArgs e)
        {
            cboServicioBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cboServicioBusqueda.Items.Clear();
            cboServicioBusqueda.Items.AddRange(new string[] { "Por peso", "Prendas delicadas" });

            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.Items.Clear();
            cboEstado.Items.AddRange(new string[] { "Lavado", "Secado", "Listo para entregar" });

            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFechaEntrega.Format = DateTimePickerFormat.Short;

            txtCodigo.ReadOnly = true; // No permitir editar el ID único

            if (ventaAEditar != null)
            {
                txtCodigo.Text = ventaAEditar.Codigo;
                dtpFecha.Value = ventaAEditar.Fecha;
                dtpFechaEntrega.Value = ventaAEditar.FechaEntrega;
                txtCliente.Text = ventaAEditar.Cliente;
                cboServicioBusqueda.Text = ventaAEditar.Servicio;
                cboEstado.Text = ventaAEditar.Estado;
                txtPeso.Text = ventaAEditar.Peso.ToString("0.00");
                txtDetalle.Text = ventaAEditar.Detalle.ToString("0.00");
                txtImporteTotal.Text = ventaAEditar.ImporteTotal.ToString("0.00");
            }
        }

        private void cboServicioBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboServicioBusqueda.Text == "Por peso") txtDetalle.Text = "5.00";
            else if (cboServicioBusqueda.Text == "Prendas delicadas") txtDetalle.Text = "7.50";
            CalcularTotal();
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') e.Handled = true;
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains(".")) e.Handled = true;
        }

        private void txtPeso_TextChanged(object sender, EventArgs e) => CalcularTotal();

        private void txtPeso_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPeso.Text, out decimal peso)) txtPeso.Text = peso.ToString("0.00");
        }

        private void CalcularTotal()
        {
            decimal.TryParse(txtPeso.Text, out decimal peso);
            decimal.TryParse(txtDetalle.Text, out decimal precio);
            txtImporteTotal.Text = (peso * precio).ToString("0.00");
        }

        // CORREGIDO: Nombre del método alineado con el control btnActualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return;
            }

            if (!decimal.TryParse(txtPeso.Text, out decimal pesoValido) || pesoValido <= 0)
            {
                MessageBox.Show("Debe ingresar un peso válido mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeso.Focus();
                return;
            }

            // Guardamos los datos modificados en el objeto original por referencia
            ventaAEditar.Fecha = dtpFecha.Value;
            ventaAEditar.FechaEntrega = dtpFechaEntrega.Value;
            ventaAEditar.Cliente = txtCliente.Text.Trim();
            ventaAEditar.Servicio = cboServicioBusqueda.Text;
            ventaAEditar.Estado = cboEstado.Text;
            ventaAEditar.Peso = pesoValido;
            ventaAEditar.Detalle = Convert.ToDecimal(txtDetalle.Text);
            ventaAEditar.ImporteTotal = Convert.ToDecimal(txtImporteTotal.Text);

            VentaDAO.Actualizar(ventaAEditar);

            MessageBox.Show("El registro se actualizó correctamente.", "LavaGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }   
}

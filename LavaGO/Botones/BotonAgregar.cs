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

        public partial class BotonAgregar : Form
        {
            public BotonAgregar()
            {
                InitializeComponent();
                // Vinculamos los eventos principales de control
                this.Load += BotonAgregar_Load;
                cboServicioBusqueda.SelectedIndexChanged += cboServicioBusqueda_SelectedIndexChanged;
                txtPeso.TextChanged += txtPeso_TextChanged;
                txtPeso.KeyPress += txtPeso_KeyPress;
                txtPeso.Leave += txtPeso_Leave;
                btnAdd.Click += btnAdd_Click; // Vinculación con el botón de tu diseñador
            }

            private void BotonAgregar_Load(object sender, EventArgs e)
            {
                // 1. Configuración de los ComboBoxes
                cboServicioBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
                cboServicioBusqueda.Items.Clear();
                cboServicioBusqueda.Items.AddRange(new string[] { "Por peso", "Prendas delicadas" });
                cboServicioBusqueda.SelectedIndex = 0;

                cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
                cboEstado.Items.Clear();
                cboEstado.Items.AddRange(new string[] { "Lavado", "Secado", "Listo para entregar" });
                cboEstado.SelectedIndex = 0;

                // 2. Configuración de Fechas
                dtpFecha.Format = DateTimePickerFormat.Short;
                dtpFecha.Value = DateTime.Now;
                dtpFechaEntrega.Format = DateTimePickerFormat.Short;
                dtpFechaEntrega.Value = DateTime.Now.AddDays(2); // Sugerencia de entrega a 2 días

                // 3. Generar el código correlativo de manera automática basándose en la lista actual
                GenerarCodigoAutoincremental();
            }

            private void GenerarCodigoAutoincremental()
            {
                var lista = VentaDAO.Listar();
                int siguienteNumero = 1;

                if (lista.Count > 0)
                {
                    // Busca el número más alto en los códigos existentes que tengan formato "LVGxxx"
                    var maxCodigo = lista
                        .Select(v => v.Codigo.Replace("LVG", ""))
                        .Where(c => int.TryParse(c, out _))
                        .Select(int.Parse)
                        .DefaultIfEmpty(0)
                        .Max();

                    siguienteNumero = maxCodigo + 1;
                }

                txtCodigo.Text = "LVG" + siguienteNumero.ToString("000");
            }

            // Cambia automáticamente el precio base (Detalle) según el tipo de servicio
            private void cboServicioBusqueda_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (cboServicioBusqueda.Text == "Por peso")
                {
                    txtDetalle.Text = "5.00";
                }
                else if (cboServicioBusqueda.Text == "Prendas delicadas")
                {
                    txtDetalle.Text = "7.50";
                }
                CalcularTotal();
            }

            // Filtro para permitir únicamente números y un punto decimal en el Peso
            private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }

            private void txtPeso_TextChanged(object sender, EventArgs e)
            {
                CalcularTotal();
            }

            private void txtPeso_Leave(object sender, EventArgs e)
            {
                if (decimal.TryParse(txtPeso.Text, out decimal peso))
                {
                    txtPeso.Text = peso.ToString("0.00");
                }
            }

            // Método encargado de unificar y procesar el Importe Total
            private void CalcularTotal()
            {
                decimal.TryParse(txtPeso.Text, out decimal peso);
                decimal.TryParse(txtDetalle.Text, out decimal precio);

                decimal total = peso * precio;
                txtImporteTotal.Text = total.ToString("0.00");
            }

            // ================================================================
            // ACCIÓN DEL BOTÓN AGREGAR (btnAdd)
            // ================================================================
            private void btnAdd_Click(object sender, EventArgs e)
            {
                // Validación: Asegurar que el campo cliente tenga datos
                if (string.IsNullOrWhiteSpace(txtCliente.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCliente.Focus();
                    return;
                }

                // Validación: Asegurar que el peso ingresado sea correcto y mayor que cero
                if (!decimal.TryParse(txtPeso.Text, out decimal pesoValido) || pesoValido <= 0)
                {
                    MessageBox.Show("Debe ingresar un peso válido mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPeso.Focus();
                    return;
                }

                // Mapeo del objeto Venta con la información ingresada en este Formulario independiente
                Venta nuevaVenta = new Venta
                {
                    Codigo = txtCodigo.Text,
                    Fecha = dtpFecha.Value,
                    FechaEntrega = dtpFechaEntrega.Value,
                    Cliente = txtCliente.Text.Trim(),
                    Servicio = cboServicioBusqueda.Text,
                    Estado = cboEstado.Text,
                    Peso = pesoValido,
                    Detalle = Convert.ToDecimal(txtDetalle.Text),
                    ImporteTotal = Convert.ToDecimal(txtImporteTotal.Text)
                };

                // Inserción en la base de datos simulada en memoria (VentaDAO)
                VentaDAO.Insertar(nuevaVenta);

                MessageBox.Show("Registro guardado con éxito.", "LavaGO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerramos la ventana para retornar de forma automática al Form1 principal
                this.Close();
            }
        }   
}

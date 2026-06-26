using LavaGO.Botones;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Eventos del formulario y controles principales
            this.Load += Form1_Load;
            dgvCliente.CellClick += dgvCliente_CellClick;
            cboServicioBusqueda.SelectedIndexChanged += cboServicioBusqueda_SelectedIndexChanged;
            txtPeso.TextChanged += txtPeso_TextChanged;
            txtPeso.KeyPress += txtPeso_KeyPress;
            txtPeso.Leave += txtPeso_Leave;

            // Redirección de botones a las ventanas emergentes y acciones
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnPrecioServicios.Click += btnPrecioServicios_Click;
            btnReporteVentas.Click += btnReporteVentas_Click;
            btnMenus.Click += btnMenus_Click;
        }
        public void MostrarDatos()
        {
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = VentaDAO.Listar();
            if (dgvCliente.Columns.Count > 8)
            {
                dgvCliente.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvCliente.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }
        public void Limpiar()
        {
            txtCliente.Clear();
            txtPeso.Clear();
            txtDetalle.Clear();
            txtImporteTotal.Clear();
            cboServicioBusqueda.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now;
            dtpFechaEntrega.Value = DateTime.Now.AddDays(2);

            txtCodigo.Text = "LVG" + (VentaDAO.Listar().Count + 1).ToString("000");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cboServicioBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cboServicioBusqueda.Items.Clear();
            cboServicioBusqueda.Items.AddRange(new string[] { "Por peso", "Prendas delicadas" });
            cboServicioBusqueda.SelectedIndex = 0;

            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.Items.Clear();
            cboEstado.Items.AddRange(new string[] { "Lavado", "Secado", "Listo para entregar" });
            cboEstado.SelectedIndex = 0;

            MostrarDatos();
            Limpiar();
        }
        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCliente.CurrentRow == null) return;

            Venta v = (Venta)dgvCliente.CurrentRow.DataBoundItem;
            if (v != null)
            {
                txtCodigo.Text = v.Codigo;
                dtpFecha.Value = v.Fecha;
                txtCliente.Text = v.Cliente;
                cboServicioBusqueda.Text = v.Servicio;
                txtPeso.Text = v.Peso.ToString("0.00");
                txtDetalle.Text = v.Detalle.ToString("0.00");
                txtImporteTotal.Text = v.ImporteTotal.ToString("0.00");
                cboEstado.Text = v.Estado;
                dtpFechaEntrega.Value = v.FechaEntrega;
            }
        }
        private void cboServicioBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboServicioBusqueda.Text == "Por peso") txtDetalle.Text = "5.00";
            else if (cboServicioBusqueda.Text == "Prendas delicadas") txtDetalle.Text = "7.50";
            CalcularImporte();
        }
        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') e.Handled = true;
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains(".")) e.Handled = true;
        }

        private void txtPeso_TextChanged(object sender, EventArgs e) => CalcularImporte();

        private void txtPeso_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPeso.Text, out decimal peso)) txtPeso.Text = peso.ToString("0.00");
        }

        private void CalcularImporte()
        {
            decimal.TryParse(txtPeso.Text, out decimal peso);
            decimal.TryParse(txtDetalle.Text, out decimal precio);
            txtImporteTotal.Text = (peso * precio).ToString("0.00");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LavaGO.Botones.BotonAgregar ventanaAgregar = new LavaGO.Botones.BotonAgregar();
            ventanaAgregar.ShowDialog(); // Abre la ventana emergente como modal

            // Al regresar de la ventana, refresca la tabla y limpia los campos
            MostrarDatos();
            Limpiar();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una fila de la tabla para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Venta ventaSeleccionada = (Venta)dgvCliente.CurrentRow.DataBoundItem;

            LavaGO.Botones.BotonActualizar ventanaActualizar = new LavaGO.Botones.BotonActualizar(ventaSeleccionada);
            ventanaActualizar.ShowDialog();

            MostrarDatos();
            Limpiar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow == null) return;

            Venta sel = (Venta)dgvCliente.CurrentRow.DataBoundItem;
            DialogResult res = MessageBox.Show($"¿Desea eliminar la venta {sel.Codigo}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                VentaDAO.Eliminar(sel.Codigo);
                MostrarDatos();
                Limpiar();
            }
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            string reporte = "REPORTE DE LAS 3 ÚLTIMAS VENTAS LAVAGO\n\n";
            var lista = VentaDAO.Listar();
            var ultimas = lista.Skip(Math.Max(0, lista.Count - 3)).ToList();

            foreach (var v in ultimas)
            {
                reporte += $"Código: {v.Codigo} | Cliente: {v.Cliente} | Total: S/. {v.ImporteTotal:0.00}\n";
            }
            MessageBox.Show(reporte, "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPrecioServicios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por peso: S/. 5.00\nPrendas delicadas: S/. 7.50", "Tarifario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3);
        }

        private void btnMenus_Click(object sender, EventArgs e)
        {

        }
    }
}

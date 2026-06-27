using System;
using System.Windows.Forms;
using LavaGO.Clase;

namespace LavaGO
{
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
            this.Load += Eliminar_Load;
            this.button1.Click += btnEliminar_Click;
        }
        private void Eliminar_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarDatos();
        }

        private void ConfigurarDataGridView()
        {
            if (dgvEliminar == null) return;

            dgvEliminar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEliminar.MultiSelect = false;
            dgvEliminar.ReadOnly = true;
            dgvEliminar.AllowUserToAddRows = false;
        }

        private void CargarDatos()
        {
            if (dgvEliminar == null) return;

            dgvEliminar.DataSource = null;
            dgvEliminar.DataSource = VentaDAO.Listar(); 
            dgvEliminar.Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEliminar == null) return;

            if (dgvEliminar.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una fila de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Venta ventaSeleccionada = dgvEliminar.CurrentRow.DataBoundItem as Venta;
            if (ventaSeleccionada == null)
            {
                MessageBox.Show("No se pudo obtener el registro seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = MessageBox.Show($"¿Está seguro que desea eliminar la venta con código {ventaSeleccionada.Codigo}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (res == DialogResult.Yes)
            {
                bool eliminado = VentaDAO.Eliminar(ventaSeleccionada.Codigo);
                if (eliminado)
                {
                    MessageBox.Show("Registro eliminado con éxito.", "LavaGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // ← Establece el resultado
            this.Close();
        }
    }
}
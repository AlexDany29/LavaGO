using System;
using System.Windows.Forms;
using LavaGO.Clase;

namespace LavaGO
{
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent(); // Llama al diseño de Eliminar.Designer.cs
            this.Load += Eliminar_Load;
            
            // Asignar los eventos a los botones del Diseñador
            this.button1.Click += btnEliminar_Click;
            this.button2.Click += btnRegresar_Click;
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
            dgvEliminar.DataSource = VentaDAO.Listar(); // Obtiene la lista global de ventas
            dgvEliminar.Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEliminar == null) return;

            // Verificar si hay una fila seleccionada
            if (dgvEliminar.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una fila de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el objeto Venta seleccionado
            Venta ventaSeleccionada = dgvEliminar.CurrentRow.DataBoundItem as Venta;
            if (ventaSeleccionada == null)
            {
                MessageBox.Show("No se pudo obtener el registro seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmación antes de eliminar
            DialogResult res = MessageBox.Show($"¿Está seguro que desea eliminar la venta con código {ventaSeleccionada.Codigo}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (res == DialogResult.Yes)
            {
                bool eliminado = VentaDAO.Eliminar(ventaSeleccionada.Codigo);
                if (eliminado)
                {
                    MessageBox.Show("Registro eliminado con éxito.", "LavaGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos(); // Refresca la tabla local
                    this.DialogResult = DialogResult.OK; // Notifica que hubo cambios
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana actual
        }
    }
}
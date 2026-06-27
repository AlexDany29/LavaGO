using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using LavaGO.Clase;

namespace LavaGO
{
    public partial class Eliminar : Form
    {
        private ComboBox cboVentas;
        private Button btnEliminar;
        private Button btnCancelar;
        private Label lblInfo;

        public Eliminar()
        {
            InitializeComponent();
            Load += Eliminar_Load;
        }

        private void InitializeComponent()
        {
            this.Text = "Eliminar Venta";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ClientSize = new System.Drawing.Size(420, 140);
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            lblInfo = new Label()
            {
                Text = "Seleccione el código de la venta a eliminar:",
                Left = 12,
                Top = 10,
                Width = 390
            };

            cboVentas = new ComboBox()
            {
                Left = 12,
                Top = 35,
                Width = 390,
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            btnEliminar = new Button()
            {
                Text = "Eliminar",
                Left = 220,
                Top = 75,
                Width = 90,
                DialogResult = DialogResult.None
            };
            btnEliminar.Click += BtnEliminar_Click;

            btnCancelar = new Button()
            {
                Text = "Cancelar",
                Left = 322,
                Top = 75,
                Width = 80,
                DialogResult = DialogResult.Cancel
            };
            btnCancelar.Click += (s, e) => this.Close();

            this.Controls.Add(lblInfo);
            this.Controls.Add(cboVentas);
            this.Controls.Add(btnEliminar);
            this.Controls.Add(btnCancelar);
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            CargarListaVentas();
        }

        private void CargarListaVentas()
        {
            cboVentas.Items.Clear();
            var lista = VentaDAO.Listar();
            if (lista == null || lista.Count == 0)
            {
                cboVentas.Items.Add("<No hay ventas>");
                cboVentas.SelectedIndex = 0;
                cboVentas.Enabled = false;
                btnEliminar.Enabled = false;
                return;
            }

            foreach (var v in lista)
            {
                cboVentas.Items.Add(v.Codigo);
            }

            if (cboVentas.Items.Count > 0) cboVentas.SelectedIndex = 0;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (cboVentas.SelectedItem == null) return;
            string codigo = cboVentas.SelectedItem.ToString();
            if (string.IsNullOrEmpty(codigo)) return;

            var confirm = MessageBox.Show($"¿Eliminar la venta con código {codigo}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            bool eliminado = VentaDAO.Eliminar(codigo);
            if (eliminado)
            {
                MessageBox.Show("Venta eliminada correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la venta (no encontrada).", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarListaVentas();
            }
        }
    }
}

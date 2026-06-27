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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            btnIngresar.Click += btnIngresar_Click;
            txtPassword.PasswordChar = '*';
            // Al presionar Enter se ejecuta el botón Ingresar
            this.AcceptButton = btnIngresar;
            txtUsuario.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtPassword.Text.Trim();

            if (usuario == "admin" && contraseña == "123456")
            {
                MessageBox.Show("Acceso concedido", "LavaGo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 menuPrincipal = new Form1();
                this.Hide();
                menuPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUsuario.Clear();
                txtPassword.Clear();
                txtUsuario.Focus();
            }
        }
    }
}


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
    public partial class FormHistoria : Form
    {
        public FormHistoria()
        {
            InitializeComponent();
            btnCerrar.Click += btnCerrar_Click;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

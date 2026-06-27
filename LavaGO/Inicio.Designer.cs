namespace LavaGO
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImporteTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboServicioBusqueda = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaEntrega);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtImporteTotal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDetalle);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cboServicioBusqueda);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(28, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox1.Size = new System.Drawing.Size(884, 513);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nota de Ingreso";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Enabled = false;
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(572, 444);
            this.dtpFechaEntrega.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(268, 35);
            this.dtpFechaEntrega.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 408);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha Entrega:";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Enabled = false;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(44, 444);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(473, 37);
            this.cboEstado.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 408);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Estado:";
            // 
            // txtImporteTotal
            // 
            this.txtImporteTotal.Location = new System.Drawing.Point(572, 332);
            this.txtImporteTotal.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtImporteTotal.Name = "txtImporteTotal";
            this.txtImporteTotal.ReadOnly = true;
            this.txtImporteTotal.Size = new System.Drawing.Size(268, 35);
            this.txtImporteTotal.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Importe Total:";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(296, 332);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.ReadOnly = true;
            this.txtDetalle.Size = new System.Drawing.Size(221, 35);
            this.txtDetalle.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(289, 297);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 29);
            this.label12.TabIndex = 15;
            this.label12.Text = "Precio:";
            // 
            // cboServicioBusqueda
            // 
            this.cboServicioBusqueda.Enabled = false;
            this.cboServicioBusqueda.FormattingEnabled = true;
            this.cboServicioBusqueda.Location = new System.Drawing.Point(572, 91);
            this.cboServicioBusqueda.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.cboServicioBusqueda.Name = "cboServicioBusqueda";
            this.cboServicioBusqueda.Size = new System.Drawing.Size(268, 37);
            this.cboServicioBusqueda.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(565, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Servicio:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(44, 332);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.Size = new System.Drawing.Size(202, 35);
            this.txtPeso.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 297);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Peso:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(44, 91);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(202, 35);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(44, 214);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(795, 35);
            this.txtCliente.TabIndex = 8;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(296, 91);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(221, 35);
            this.dtpFecha.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cliente:";
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(28, 607);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 92;
            this.dgvCliente.Size = new System.Drawing.Size(884, 297);
            this.dgvCliente.TabIndex = 25;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 1004);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImporteTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboServicioBusqueda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCliente;
    }
}
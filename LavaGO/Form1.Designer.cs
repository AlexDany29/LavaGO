namespace LavaGO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
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
            this.btnMenus = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrecioServicios = new System.Windows.Forms.Button();
            this.btnReporteVentas = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboOpciones = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnIngresarBusqueda = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.tabPage3.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(7, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox1.Size = new System.Drawing.Size(884, 514);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nota de Ingreso";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(572, 444);
            this.dtpFechaEntrega.Margin = new System.Windows.Forms.Padding(7);
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
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(44, 444);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(7);
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
            this.txtImporteTotal.Margin = new System.Windows.Forms.Padding(7);
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
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(7);
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
            this.cboServicioBusqueda.FormattingEnabled = true;
            this.cboServicioBusqueda.Location = new System.Drawing.Point(572, 91);
            this.cboServicioBusqueda.Margin = new System.Windows.Forms.Padding(7);
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
            this.txtPeso.Margin = new System.Windows.Forms.Padding(7);
            this.txtPeso.Name = "txtPeso";
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
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(7);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(202, 35);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(44, 214);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(7);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(795, 35);
            this.txtCliente.TabIndex = 8;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(296, 91);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(7);
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
            this.dgvCliente.Location = new System.Drawing.Point(7, 533);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(7);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 92;
            this.dgvCliente.Size = new System.Drawing.Size(1451, 296);
            this.dgvCliente.TabIndex = 24;
            // 
            // btnMenus
            // 
            this.btnMenus.Location = new System.Drawing.Point(914, 24);
            this.btnMenus.Margin = new System.Windows.Forms.Padding(7);
            this.btnMenus.Name = "btnMenus";
            this.btnMenus.Size = new System.Drawing.Size(287, 69);
            this.btnMenus.TabIndex = 25;
            this.btnMenus.Text = "Ver Menús";
            this.btnMenus.UseVisualStyleBackColor = true;
            this.btnMenus.Click += new System.EventHandler(this.btnMenus_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.CausesValidation = false;
            this.btnAdd.Location = new System.Drawing.Point(914, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(287, 69);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(914, 188);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(287, 69);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(914, 267);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(287, 69);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrecioServicios
            // 
            this.btnPrecioServicios.Location = new System.Drawing.Point(1211, 24);
            this.btnPrecioServicios.Name = "btnPrecioServicios";
            this.btnPrecioServicios.Size = new System.Drawing.Size(247, 69);
            this.btnPrecioServicios.TabIndex = 29;
            this.btnPrecioServicios.Text = "Precio Servicios";
            this.btnPrecioServicios.UseVisualStyleBackColor = true;
            this.btnPrecioServicios.Click += new System.EventHandler(this.btnPrecioServicios_Click);
            // 
            // btnReporteVentas
            // 
            this.btnReporteVentas.Location = new System.Drawing.Point(1211, 103);
            this.btnReporteVentas.Name = "btnReporteVentas";
            this.btnReporteVentas.Size = new System.Drawing.Size(247, 69);
            this.btnReporteVentas.TabIndex = 30;
            this.btnReporteVentas.Text = "Reporte Ventas";
            this.btnReporteVentas.UseVisualStyleBackColor = true;
            this.btnReporteVentas.Click += new System.EventHandler(this.btnReporteVentas_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1548, 910);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnConsultar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dgvCliente);
            this.tabPage1.Controls.Add(this.btnReporteVentas);
            this.tabPage1.Controls.Add(this.btnMenus);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.btnPrecioServicios);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Location = new System.Drawing.Point(10, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1528, 853);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inicio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(914, 342);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(287, 68);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(10, 47);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1528, 853);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(914, 423);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(287, 68);
            this.btnConsultar.TabIndex = 33;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Location = new System.Drawing.Point(137, 421);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.RowHeadersWidth = 92;
            this.dgvBusqueda.RowTemplate.Height = 37;
            this.dgvBusqueda.Size = new System.Drawing.Size(1102, 225);
            this.dgvBusqueda.TabIndex = 38;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(597, 262);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(283, 35);
            this.txtBusqueda.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 29);
            this.label9.TabIndex = 36;
            this.label9.Text = "Ingresar datos:";
            // 
            // cboOpciones
            // 
            this.cboOpciones.FormattingEnabled = true;
            this.cboOpciones.Location = new System.Drawing.Point(597, 187);
            this.cboOpciones.Name = "cboOpciones";
            this.cboOpciones.Size = new System.Drawing.Size(283, 37);
            this.cboOpciones.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 29);
            this.label10.TabIndex = 34;
            this.label10.Text = "Buscar por:";
            // 
            // btnIngresarBusqueda
            // 
            this.btnIngresarBusqueda.Location = new System.Drawing.Point(589, 341);
            this.btnIngresarBusqueda.Name = "btnIngresarBusqueda";
            this.btnIngresarBusqueda.Size = new System.Drawing.Size(210, 40);
            this.btnIngresarBusqueda.TabIndex = 33;
            this.btnIngresarBusqueda.Text = "Buscar";
            this.btnIngresarBusqueda.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(826, 775);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion del Cliente";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cboOpciones);
            this.tabPage3.Controls.Add(this.dgvBusqueda);
            this.tabPage3.Controls.Add(this.btnIngresarBusqueda);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtBusqueda);
            this.tabPage3.Location = new System.Drawing.Point(10, 47);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1528, 853);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Buscar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 948);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "LavaGO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.Button btnMenus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrecioServicios;
        private System.Windows.Forms.Button btnReporteVentas;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.ComboBox cboOpciones;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnIngresarBusqueda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}


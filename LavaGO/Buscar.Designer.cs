namespace LavaGO
{
    partial class Buscar
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
            this.cboOpciones = new System.Windows.Forms.ComboBox();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.btnIngresarBusqueda = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboOpciones
            // 
            this.cboOpciones.FormattingEnabled = true;
            this.cboOpciones.Location = new System.Drawing.Point(492, 37);
            this.cboOpciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboOpciones.Name = "cboOpciones";
            this.cboOpciones.Size = new System.Drawing.Size(284, 37);
            this.cboOpciones.TabIndex = 41;
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Location = new System.Drawing.Point(32, 272);
            this.dgvBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.RowHeadersWidth = 92;
            this.dgvBusqueda.RowTemplate.Height = 37;
            this.dgvBusqueda.Size = new System.Drawing.Size(1101, 225);
            this.dgvBusqueda.TabIndex = 44;
            // 
            // btnIngresarBusqueda
            // 
            this.btnIngresarBusqueda.Location = new System.Drawing.Point(518, 189);
            this.btnIngresarBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIngresarBusqueda.Name = "btnIngresarBusqueda";
            this.btnIngresarBusqueda.Size = new System.Drawing.Size(231, 47);
            this.btnIngresarBusqueda.TabIndex = 39;
            this.btnIngresarBusqueda.Text = "Buscar";
            this.btnIngresarBusqueda.UseVisualStyleBackColor = true;
            this.btnIngresarBusqueda.Click += new System.EventHandler(this.btnIngresarBusqueda_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 29);
            this.label9.TabIndex = 42;
            this.label9.Text = "Ingresar datos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(336, 44);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 29);
            this.label10.TabIndex = 40;
            this.label10.Text = "Buscar por:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(492, 111);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(284, 35);
            this.txtBusqueda.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboOpciones);
            this.groupBox1.Controls.Add(this.dgvBusqueda);
            this.groupBox1.Controls.Add(this.btnIngresarBusqueda);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Location = new System.Drawing.Point(28, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox1.Size = new System.Drawing.Size(1161, 523);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 568);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Buscar";
            this.Text = "Buscar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboOpciones;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.Button btnIngresarBusqueda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
namespace LavaGO.Botones
{
    partial class BotonEliminar
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
            this.dgvCliente1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente1
            // 
            this.dgvCliente1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente1.Location = new System.Drawing.Point(17, 55);
            this.dgvCliente1.Margin = new System.Windows.Forms.Padding(7);
            this.dgvCliente1.Name = "dgvCliente1";
            this.dgvCliente1.RowHeadersWidth = 92;
            this.dgvCliente1.Size = new System.Drawing.Size(884, 297);
            this.dgvCliente1.TabIndex = 26;
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Dato a eliminar:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(314, 372);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(267, 49);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // BotonEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 486);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCliente1);
            this.Name = "BotonEliminar";
            this.Text = "BotonEliminar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
    }
}
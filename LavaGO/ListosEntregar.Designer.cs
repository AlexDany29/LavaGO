namespace LavaGO
{
    partial class ListosEntregar
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
            this.dgvListos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListos
            // 
            this.dgvListos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListos.Location = new System.Drawing.Point(10, 10);
            this.dgvListos.Margin = new System.Windows.Forms.Padding(1);
            this.dgvListos.Name = "dgvListos";
            this.dgvListos.RowHeadersWidth = 92;
            this.dgvListos.RowTemplate.Height = 37;
            this.dgvListos.Size = new System.Drawing.Size(780, 430);
            this.dgvListos.TabIndex = 45;
            // 
            // ListosEntregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListos);
            this.Name = "ListosEntregar";
            this.Text = "ListosEntregar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListos;
    }
}
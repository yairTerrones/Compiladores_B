namespace MapasDeKarnaugh
{
    partial class Principal
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
            this.textVariables = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSimplificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupMapa = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupMapa.SuspendLayout();
            this.SuspendLayout();
            // 
            // textVariables
            // 
            this.textVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textVariables.Location = new System.Drawing.Point(3, 16);
            this.textVariables.Name = "textVariables";
            this.textVariables.Size = new System.Drawing.Size(273, 208);
            this.textVariables.TabIndex = 0;
            this.textVariables.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textVariables);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Ingresa texto: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Función simplificada:";
            // 
            // btnSimplificar
            // 
            this.btnSimplificar.Location = new System.Drawing.Point(15, 245);
            this.btnSimplificar.Name = "btnSimplificar";
            this.btnSimplificar.Size = new System.Drawing.Size(273, 23);
            this.btnSimplificar.TabIndex = 3;
            this.btnSimplificar.Text = "Simplificar Función:";
            this.btnSimplificar.UseVisualStyleBackColor = true;
            this.btnSimplificar.Click += new System.EventHandler(this.btnSimplificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 208);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupMapa
            // 
            this.groupMapa.Controls.Add(this.dataGridView1);
            this.groupMapa.Location = new System.Drawing.Point(297, 12);
            this.groupMapa.Name = "groupMapa";
            this.groupMapa.Size = new System.Drawing.Size(411, 227);
            this.groupMapa.TabIndex = 6;
            this.groupMapa.TabStop = false;
            this.groupMapa.Text = " Mapa de Karnaugh ";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 320);
            this.Controls.Add(this.groupMapa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSimplificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Principal";
            this.Text = "Mapa de Karnaugh.";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupMapa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textVariables;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSimplificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupMapa;
    }
}


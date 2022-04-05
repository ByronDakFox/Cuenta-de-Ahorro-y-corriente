namespace Cuenta_de_Ahorro_y_corriente
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAhorro = new System.Windows.Forms.Button();
            this.btnCorriente = new System.Windows.Forms.Button();
            this.btnDepAhorro = new System.Windows.Forms.Button();
            this.btnDepCorriente = new System.Windows.Forms.Button();
            this.btnReAhorro = new System.Windows.Forms.Button();
            this.btnReCorriente = new System.Windows.Forms.Button();
            this.txtAho = new System.Windows.Forms.TextBox();
            this.txtCorr = new System.Windows.Forms.TextBox();
            this.txtDAho = new System.Windows.Forms.TextBox();
            this.txtDCorr = new System.Windows.Forms.TextBox();
            this.txtRAh = new System.Windows.Forms.TextBox();
            this.txtRCo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transacción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAhorro
            // 
            this.btnAhorro.Location = new System.Drawing.Point(33, 75);
            this.btnAhorro.Name = "btnAhorro";
            this.btnAhorro.Size = new System.Drawing.Size(232, 30);
            this.btnAhorro.TabIndex = 0;
            this.btnAhorro.Text = "Crear Ahorro";
            this.btnAhorro.UseVisualStyleBackColor = true;
            this.btnAhorro.Click += new System.EventHandler(this.btnAhorro_Click);
            // 
            // btnCorriente
            // 
            this.btnCorriente.Location = new System.Drawing.Point(33, 122);
            this.btnCorriente.Name = "btnCorriente";
            this.btnCorriente.Size = new System.Drawing.Size(232, 27);
            this.btnCorriente.TabIndex = 1;
            this.btnCorriente.Text = "Crear Corriente";
            this.btnCorriente.UseVisualStyleBackColor = true;
            this.btnCorriente.Click += new System.EventHandler(this.btnCorriente_Click);
            // 
            // btnDepAhorro
            // 
            this.btnDepAhorro.Location = new System.Drawing.Point(42, 266);
            this.btnDepAhorro.Name = "btnDepAhorro";
            this.btnDepAhorro.Size = new System.Drawing.Size(223, 30);
            this.btnDepAhorro.TabIndex = 2;
            this.btnDepAhorro.Text = "Deprositar Ahorro";
            this.btnDepAhorro.UseVisualStyleBackColor = true;
            this.btnDepAhorro.Click += new System.EventHandler(this.btnDepAhorro_Click);
            // 
            // btnDepCorriente
            // 
            this.btnDepCorriente.Location = new System.Drawing.Point(42, 312);
            this.btnDepCorriente.Name = "btnDepCorriente";
            this.btnDepCorriente.Size = new System.Drawing.Size(223, 30);
            this.btnDepCorriente.TabIndex = 3;
            this.btnDepCorriente.Text = "Depositar Corriente";
            this.btnDepCorriente.UseVisualStyleBackColor = true;
            this.btnDepCorriente.Click += new System.EventHandler(this.btnDepCorriente_Click);
            // 
            // btnReAhorro
            // 
            this.btnReAhorro.Location = new System.Drawing.Point(42, 359);
            this.btnReAhorro.Name = "btnReAhorro";
            this.btnReAhorro.Size = new System.Drawing.Size(223, 28);
            this.btnReAhorro.TabIndex = 4;
            this.btnReAhorro.Text = "Retirar Ahorros";
            this.btnReAhorro.UseVisualStyleBackColor = true;
            this.btnReAhorro.Click += new System.EventHandler(this.btnReAhorro_Click);
            // 
            // btnReCorriente
            // 
            this.btnReCorriente.Location = new System.Drawing.Point(42, 403);
            this.btnReCorriente.Name = "btnReCorriente";
            this.btnReCorriente.Size = new System.Drawing.Size(223, 27);
            this.btnReCorriente.TabIndex = 5;
            this.btnReCorriente.Text = "Retirar Corriente";
            this.btnReCorriente.UseVisualStyleBackColor = true;
            this.btnReCorriente.Click += new System.EventHandler(this.btnReCorriente_Click);
            // 
            // txtAho
            // 
            this.txtAho.Location = new System.Drawing.Point(313, 82);
            this.txtAho.Name = "txtAho";
            this.txtAho.Size = new System.Drawing.Size(100, 22);
            this.txtAho.TabIndex = 6;
            // 
            // txtCorr
            // 
            this.txtCorr.Location = new System.Drawing.Point(313, 122);
            this.txtCorr.Name = "txtCorr";
            this.txtCorr.Size = new System.Drawing.Size(100, 22);
            this.txtCorr.TabIndex = 7;
            // 
            // txtDAho
            // 
            this.txtDAho.Location = new System.Drawing.Point(301, 273);
            this.txtDAho.Name = "txtDAho";
            this.txtDAho.Size = new System.Drawing.Size(100, 22);
            this.txtDAho.TabIndex = 8;
            // 
            // txtDCorr
            // 
            this.txtDCorr.Location = new System.Drawing.Point(301, 319);
            this.txtDCorr.Name = "txtDCorr";
            this.txtDCorr.Size = new System.Drawing.Size(100, 22);
            this.txtDCorr.TabIndex = 9;
            // 
            // txtRAh
            // 
            this.txtRAh.Location = new System.Drawing.Point(301, 364);
            this.txtRAh.Name = "txtRAh";
            this.txtRAh.Size = new System.Drawing.Size(100, 22);
            this.txtRAh.TabIndex = 10;
            // 
            // txtRCo
            // 
            this.txtRCo.Location = new System.Drawing.Point(301, 405);
            this.txtRCo.Name = "txtRCo";
            this.txtRCo.Size = new System.Drawing.Size(100, 22);
            this.txtRCo.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuenta,
            this.Transacción,
            this.Cantidad,
            this.Saldo});
            this.dataGridView1.Location = new System.Drawing.Point(492, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(511, 348);
            this.dataGridView1.TabIndex = 12;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            // 
            // Transacción
            // 
            this.Transacción.HeaderText = "Transacción";
            this.Transacción.Name = "Transacción";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 527);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtRCo);
            this.Controls.Add(this.txtRAh);
            this.Controls.Add(this.txtDCorr);
            this.Controls.Add(this.txtDAho);
            this.Controls.Add(this.txtCorr);
            this.Controls.Add(this.txtAho);
            this.Controls.Add(this.btnReCorriente);
            this.Controls.Add(this.btnReAhorro);
            this.Controls.Add(this.btnDepCorriente);
            this.Controls.Add(this.btnDepAhorro);
            this.Controls.Add(this.btnCorriente);
            this.Controls.Add(this.btnAhorro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAhorro;
        private System.Windows.Forms.Button btnCorriente;
        private System.Windows.Forms.Button btnDepAhorro;
        private System.Windows.Forms.Button btnDepCorriente;
        private System.Windows.Forms.Button btnReAhorro;
        private System.Windows.Forms.Button btnReCorriente;
        private System.Windows.Forms.TextBox txtAho;
        private System.Windows.Forms.TextBox txtCorr;
        private System.Windows.Forms.TextBox txtDAho;
        private System.Windows.Forms.TextBox txtDCorr;
        private System.Windows.Forms.TextBox txtRAh;
        private System.Windows.Forms.TextBox txtRCo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transacción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
    }
}


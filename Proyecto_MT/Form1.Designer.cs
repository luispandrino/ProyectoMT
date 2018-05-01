namespace Proyecto_MT
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
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RbtnPalindromo = new System.Windows.Forms.RadioButton();
            this.RbtnCopiar = new System.Windows.Forms.RadioButton();
            this.RbtnMultiplicacion = new System.Windows.Forms.RadioButton();
            this.RbtnSuma = new System.Windows.Forms.RadioButton();
            this.RbtnResta = new System.Windows.Forms.RadioButton();
            this.CintaMT = new System.Windows.Forms.DataGridView();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CintaMT)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(12, 25);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(238, 20);
            this.txtCadena.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la cadena que desee valuar ";
            // 
            // RbtnPalindromo
            // 
            this.RbtnPalindromo.AutoSize = true;
            this.RbtnPalindromo.Location = new System.Drawing.Point(12, 102);
            this.RbtnPalindromo.Name = "RbtnPalindromo";
            this.RbtnPalindromo.Size = new System.Drawing.Size(77, 17);
            this.RbtnPalindromo.TabIndex = 2;
            this.RbtnPalindromo.TabStop = true;
            this.RbtnPalindromo.Text = "Palindromo";
            this.RbtnPalindromo.UseVisualStyleBackColor = true;
            // 
            // RbtnCopiar
            // 
            this.RbtnCopiar.AutoSize = true;
            this.RbtnCopiar.Location = new System.Drawing.Point(12, 126);
            this.RbtnCopiar.Name = "RbtnCopiar";
            this.RbtnCopiar.Size = new System.Drawing.Size(112, 17);
            this.RbtnCopiar.TabIndex = 3;
            this.RbtnCopiar.TabStop = true;
            this.RbtnCopiar.Text = "Copia de Patrones";
            this.RbtnCopiar.UseVisualStyleBackColor = true;
            // 
            // RbtnMultiplicacion
            // 
            this.RbtnMultiplicacion.AutoSize = true;
            this.RbtnMultiplicacion.Location = new System.Drawing.Point(12, 150);
            this.RbtnMultiplicacion.Name = "RbtnMultiplicacion";
            this.RbtnMultiplicacion.Size = new System.Drawing.Size(89, 17);
            this.RbtnMultiplicacion.TabIndex = 4;
            this.RbtnMultiplicacion.TabStop = true;
            this.RbtnMultiplicacion.Text = "Multiplicación";
            this.RbtnMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // RbtnSuma
            // 
            this.RbtnSuma.AutoSize = true;
            this.RbtnSuma.Location = new System.Drawing.Point(12, 174);
            this.RbtnSuma.Name = "RbtnSuma";
            this.RbtnSuma.Size = new System.Drawing.Size(86, 17);
            this.RbtnSuma.TabIndex = 5;
            this.RbtnSuma.TabStop = true;
            this.RbtnSuma.Text = "Suma Unaria";
            this.RbtnSuma.UseVisualStyleBackColor = true;
            // 
            // RbtnResta
            // 
            this.RbtnResta.AutoSize = true;
            this.RbtnResta.Location = new System.Drawing.Point(12, 198);
            this.RbtnResta.Name = "RbtnResta";
            this.RbtnResta.Size = new System.Drawing.Size(87, 17);
            this.RbtnResta.TabIndex = 6;
            this.RbtnResta.TabStop = true;
            this.RbtnResta.Text = "Resta Unaria";
            this.RbtnResta.UseVisualStyleBackColor = true;
            // 
            // CintaMT
            // 
            this.CintaMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CintaMT.ColumnHeadersVisible = false;
            this.CintaMT.Location = new System.Drawing.Point(145, 68);
            this.CintaMT.Name = "CintaMT";
            this.CintaMT.RowHeadersVisible = false;
            this.CintaMT.Size = new System.Drawing.Size(506, 51);
            this.CintaMT.TabIndex = 7;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(316, 21);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(160, 23);
            this.btnIniciar.TabIndex = 8;
            this.btnIniciar.Text = "Go!";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(326, 150);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(35, 13);
            this.lblAviso.TabIndex = 9;
            this.lblAviso.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 244);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.CintaMT);
            this.Controls.Add(this.RbtnResta);
            this.Controls.Add(this.RbtnSuma);
            this.Controls.Add(this.RbtnMultiplicacion);
            this.Controls.Add(this.RbtnCopiar);
            this.Controls.Add(this.RbtnPalindromo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCadena);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CintaMT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RbtnPalindromo;
        private System.Windows.Forms.RadioButton RbtnCopiar;
        private System.Windows.Forms.RadioButton RbtnMultiplicacion;
        private System.Windows.Forms.RadioButton RbtnSuma;
        private System.Windows.Forms.RadioButton RbtnResta;
        private System.Windows.Forms.DataGridView CintaMT;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblAviso;
    }
}


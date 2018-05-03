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
            this.components = new System.ComponentModel.Container();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RbtnPalindromo = new System.Windows.Forms.RadioButton();
            this.RbtnCopiar = new System.Windows.Forms.RadioButton();
            this.RbtnMultiplicacion = new System.Windows.Forms.RadioButton();
            this.RbtnSuma = new System.Windows.Forms.RadioButton();
            this.RbtnResta = new System.Windows.Forms.RadioButton();
            this.CintaMT = new System.Windows.Forms.DataGridView();
            this.btnPaso = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.btnInciarM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPasos = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRapido = new System.Windows.Forms.Button();
            this.numVelocidad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.CintaMT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVelocidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.RbtnPalindromo.Location = new System.Drawing.Point(24, 57);
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
            this.RbtnCopiar.Location = new System.Drawing.Point(24, 81);
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
            this.RbtnMultiplicacion.Location = new System.Drawing.Point(24, 105);
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
            this.RbtnSuma.Location = new System.Drawing.Point(24, 129);
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
            this.RbtnResta.Location = new System.Drawing.Point(24, 153);
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
            this.CintaMT.Location = new System.Drawing.Point(197, 83);
            this.CintaMT.Name = "CintaMT";
            this.CintaMT.ReadOnly = true;
            this.CintaMT.RowHeadersVisible = false;
            this.CintaMT.Size = new System.Drawing.Size(536, 51);
            this.CintaMT.TabIndex = 7;
            // 
            // btnPaso
            // 
            this.btnPaso.Location = new System.Drawing.Point(232, 19);
            this.btnPaso.Name = "btnPaso";
            this.btnPaso.Size = new System.Drawing.Size(91, 23);
            this.btnPaso.TabIndex = 8;
            this.btnPaso.Text = "Paso";
            this.btnPaso.UseVisualStyleBackColor = true;
            this.btnPaso.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.Location = new System.Drawing.Point(192, 197);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(70, 25);
            this.lblAviso.TabIndex = 9;
            this.lblAviso.Text = "label2";
            this.lblAviso.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Estado :";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(289, 152);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(18, 25);
            this.lblestado.TabIndex = 11;
            this.lblestado.Text = ".";
            // 
            // btnInciarM
            // 
            this.btnInciarM.Location = new System.Drawing.Point(6, 19);
            this.btnInciarM.Name = "btnInciarM";
            this.btnInciarM.Size = new System.Drawing.Size(91, 23);
            this.btnInciarM.TabIndex = 12;
            this.btnInciarM.Text = "Iniciar Maquina";
            this.btnInciarM.UseVisualStyleBackColor = true;
            this.btnInciarM.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Pasos : ";
            // 
            // lblPasos
            // 
            this.lblPasos.AutoSize = true;
            this.lblPasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasos.Location = new System.Drawing.Point(466, 156);
            this.lblPasos.Name = "lblPasos";
            this.lblPasos.Size = new System.Drawing.Size(18, 25);
            this.lblPasos.TabIndex = 14;
            this.lblPasos.Text = ".";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(342, 19);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(91, 23);
            this.btnReiniciar.TabIndex = 15;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRapido
            // 
            this.btnRapido.Location = new System.Drawing.Point(118, 19);
            this.btnRapido.Name = "btnRapido";
            this.btnRapido.Size = new System.Drawing.Size(91, 22);
            this.btnRapido.TabIndex = 16;
            this.btnRapido.Text = "Automatico";
            this.btnRapido.UseVisualStyleBackColor = true;
            this.btnRapido.Click += new System.EventHandler(this.btnRapido_Click);
            // 
            // numVelocidad
            // 
            this.numVelocidad.Location = new System.Drawing.Point(24, 32);
            this.numVelocidad.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numVelocidad.Name = "numVelocidad";
            this.numVelocidad.Size = new System.Drawing.Size(49, 20);
            this.numVelocidad.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Velocidad Automatico (ms)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RbtnPalindromo);
            this.groupBox1.Controls.Add(this.numVelocidad);
            this.groupBox1.Controls.Add(this.RbtnCopiar);
            this.groupBox1.Controls.Add(this.RbtnMultiplicacion);
            this.groupBox1.Controls.Add(this.RbtnSuma);
            this.groupBox1.Controls.Add(this.RbtnResta);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 178);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maquinas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInciarM);
            this.groupBox2.Controls.Add(this.btnRapido);
            this.groupBox2.Controls.Add(this.btnReiniciar);
            this.groupBox2.Controls.Add(this.btnPaso);
            this.groupBox2.Location = new System.Drawing.Point(294, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 59);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(745, 242);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPasos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.CintaMT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCadena);
            this.Name = "Form1";
            this.Text = "Simulador Maquina de Turing";
            ((System.ComponentModel.ISupportInitialize)(this.CintaMT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVelocidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnPaso;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Button btnInciarM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPasos;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRapido;
        private System.Windows.Forms.NumericUpDown numVelocidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


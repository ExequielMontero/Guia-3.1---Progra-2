namespace Ejercicio_1
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
            this.button3 = new System.Windows.Forms.Button();
            this.tbDepreciacion = new System.Windows.Forms.TextBox();
            this.tbVida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFabricacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nuAño = new System.Windows.Forms.NumericUpDown();
            this.nuModelo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbLineal = new System.Windows.Forms.RadioButton();
            this.rbAnual = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nuAño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuModelo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(-3, 273);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 50);
            this.button3.TabIndex = 30;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tbDepreciacion
            // 
            this.tbDepreciacion.Location = new System.Drawing.Point(190, 140);
            this.tbDepreciacion.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbDepreciacion.Name = "tbDepreciacion";
            this.tbDepreciacion.Size = new System.Drawing.Size(105, 22);
            this.tbDepreciacion.TabIndex = 29;
            // 
            // tbVida
            // 
            this.tbVida.Location = new System.Drawing.Point(150, 172);
            this.tbVida.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbVida.Name = "tbVida";
            this.tbVida.Size = new System.Drawing.Size(145, 22);
            this.tbVida.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Vida Util (años):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tasa de depreciacion:";
            // 
            // tbFabricacion
            // 
            this.tbFabricacion.Location = new System.Drawing.Point(189, 118);
            this.tbFabricacion.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbFabricacion.Name = "tbFabricacion";
            this.tbFabricacion.Size = new System.Drawing.Size(220, 22);
            this.tbFabricacion.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Valor de fabricacion $:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Modelo(año):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Año a calcular:";
            // 
            // nuAño
            // 
            this.nuAño.Location = new System.Drawing.Point(139, 98);
            this.nuAño.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.nuAño.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.nuAño.Minimum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.nuAño.Name = "nuAño";
            this.nuAño.Size = new System.Drawing.Size(156, 22);
            this.nuAño.TabIndex = 21;
            this.nuAño.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // nuModelo
            // 
            this.nuModelo.Location = new System.Drawing.Point(185, 83);
            this.nuModelo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.nuModelo.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.nuModelo.Minimum = new decimal(new int[] {
            1956,
            0,
            0,
            0});
            this.nuModelo.Name = "nuModelo";
            this.nuModelo.Size = new System.Drawing.Size(153, 22);
            this.nuModelo.TabIndex = 20;
            this.nuModelo.Value = new decimal(new int[] {
            1975,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Marca:";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(76, 34);
            this.tbMarca.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(220, 22);
            this.tbMarca.TabIndex = 18;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(600, 256);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(168, 50);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular Costo";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nuModelo);
            this.groupBox1.Controls.Add(this.tbMarca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbFabricacion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 188);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del vehiculo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAnual);
            this.groupBox2.Controls.Add(this.rbLineal);
            this.groupBox2.Controls.Add(this.nuAño);
            this.groupBox2.Controls.Add(this.tbVida);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbDepreciacion);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(492, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 236);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculo depreciacion";
            // 
            // rbLineal
            // 
            this.rbLineal.AutoSize = true;
            this.rbLineal.Location = new System.Drawing.Point(18, 46);
            this.rbLineal.Name = "rbLineal";
            this.rbLineal.Size = new System.Drawing.Size(67, 20);
            this.rbLineal.TabIndex = 0;
            this.rbLineal.TabStop = true;
            this.rbLineal.Text = "Lineal";
            this.rbLineal.UseVisualStyleBackColor = true;
            this.rbLineal.CheckedChanged += new System.EventHandler(this.rbLineal_CheckedChanged);
            // 
            // rbAnual
            // 
            this.rbAnual.AutoSize = true;
            this.rbAnual.Location = new System.Drawing.Point(164, 46);
            this.rbAnual.Name = "rbAnual";
            this.rbAnual.Size = new System.Drawing.Size(64, 20);
            this.rbAnual.TabIndex = 1;
            this.rbAnual.TabStop = true;
            this.rbAnual.Text = "Anual";
            this.rbAnual.UseVisualStyleBackColor = true;
            this.rbAnual.CheckedChanged += new System.EventHandler(this.rbAnual_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 322);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCalcular);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Tasacion Motos";
            ((System.ComponentModel.ISupportInitialize)(this.nuAño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuModelo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbDepreciacion;
        private System.Windows.Forms.TextBox tbVida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFabricacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nuAño;
        private System.Windows.Forms.NumericUpDown nuModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbAnual;
        private System.Windows.Forms.RadioButton rbLineal;
    }
}


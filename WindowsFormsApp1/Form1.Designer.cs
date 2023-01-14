namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.segundoNumero = new System.Windows.Forms.TextBox();
            this.primerNumero = new System.Windows.Forms.TextBox();
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.Tresultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo Numero";
            // 
            // segundoNumero
            // 
            this.segundoNumero.Location = new System.Drawing.Point(186, 85);
            this.segundoNumero.Name = "segundoNumero";
            this.segundoNumero.Size = new System.Drawing.Size(100, 20);
            this.segundoNumero.TabIndex = 2;
            // 
            // primerNumero
            // 
            this.primerNumero.Location = new System.Drawing.Point(186, 44);
            this.primerNumero.Name = "primerNumero";
            this.primerNumero.Size = new System.Drawing.Size(100, 20);
            this.primerNumero.TabIndex = 3;
            // 
            // suma
            // 
            this.suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.Location = new System.Drawing.Point(320, 22);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(39, 23);
            this.suma.TabIndex = 4;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // resta
            // 
            this.resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resta.Location = new System.Drawing.Point(320, 51);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(39, 23);
            this.resta.TabIndex = 5;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // multiplicacion
            // 
            this.multiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacion.Location = new System.Drawing.Point(320, 80);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(39, 23);
            this.multiplicacion.TabIndex = 6;
            this.multiplicacion.Text = "*";
            this.multiplicacion.UseVisualStyleBackColor = true;
            this.multiplicacion.Click += new System.EventHandler(this.multiplicacion_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(320, 109);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(39, 23);
            this.division.TabIndex = 7;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // Tresultado
            // 
            this.Tresultado.Location = new System.Drawing.Point(161, 149);
            this.Tresultado.Name = "Tresultado";
            this.Tresultado.ReadOnly = true;
            this.Tresultado.Size = new System.Drawing.Size(125, 20);
            this.Tresultado.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 191);
            this.Controls.Add(this.Tresultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.primerNumero);
            this.Controls.Add(this.segundoNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox segundoNumero;
        private System.Windows.Forms.TextBox primerNumero;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.TextBox Tresultado;
        private System.Windows.Forms.Label label3;
    }
}


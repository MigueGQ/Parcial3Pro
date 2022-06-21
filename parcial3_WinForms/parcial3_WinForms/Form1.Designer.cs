namespace parcial3_WinForms
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAvion = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.guardar = new System.Windows.Forms.Button();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.txtLlegada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Avion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salida";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Llegada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pasajeros";
            // 
            // txtAvion
            // 
            this.txtAvion.Location = new System.Drawing.Point(101, 32);
            this.txtAvion.Name = "txtAvion";
            this.txtAvion.Size = new System.Drawing.Size(305, 26);
            this.txtAvion.TabIndex = 4;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(101, 155);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(305, 26);
            this.txtNum.TabIndex = 5;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(12, 387);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(86, 34);
            this.guardar.TabIndex = 8;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(101, 64);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(305, 26);
            this.txtSalida.TabIndex = 9;
            // 
            // txtLlegada
            // 
            this.txtLlegada.Location = new System.Drawing.Point(101, 104);
            this.txtLlegada.Name = "txtLlegada";
            this.txtLlegada.Size = new System.Drawing.Size(305, 26);
            this.txtLlegada.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLlegada);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtAvion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAvion;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.TextBox txtLlegada;
    }
}


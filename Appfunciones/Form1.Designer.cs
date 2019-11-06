namespace Appfunciones
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
            this.btncerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.btmsuamar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(210, 242);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 0;
            this.btncerrar.Text = "CERRAR";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese un entero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese otro entero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultado";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(185, 55);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 4;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(185, 173);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 5;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(185, 116);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 6;
            // 
            // btmsuamar
            // 
            this.btmsuamar.Location = new System.Drawing.Point(103, 242);
            this.btmsuamar.Name = "btmsuamar";
            this.btmsuamar.Size = new System.Drawing.Size(75, 23);
            this.btmsuamar.TabIndex = 7;
            this.btmsuamar.Text = "SUMAR";
            this.btmsuamar.UseVisualStyleBackColor = true;
            this.btmsuamar.Click += new System.EventHandler(this.btmsuamar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 361);
            this.Controls.Add(this.btmsuamar);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncerrar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Button btmsuamar;
    }
}


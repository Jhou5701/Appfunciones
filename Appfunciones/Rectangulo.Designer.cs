namespace Appfunciones
{
    partial class Rectangulo
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtsuperficie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtperimetro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Superficie";
            // 
            // txtsuperficie
            // 
            this.txtsuperficie.Enabled = false;
            this.txtsuperficie.Location = new System.Drawing.Point(156, 186);
            this.txtsuperficie.Name = "txtsuperficie";
            this.txtsuperficie.Size = new System.Drawing.Size(100, 20);
            this.txtsuperficie.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Perimetro";
            // 
            // txtperimetro
            // 
            this.txtperimetro.Enabled = false;
            this.txtperimetro.Location = new System.Drawing.Point(156, 131);
            this.txtperimetro.Name = "txtperimetro";
            this.txtperimetro.Size = new System.Drawing.Size(100, 20);
            this.txtperimetro.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Base";
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(156, 25);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(100, 20);
            this.txtbase.TabIndex = 44;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(245, 255);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 43;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(129, 255);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 42;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(18, 255);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 41;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Altura";
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(156, 76);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 50;
            // 
            // Rectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsuperficie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtperimetro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbase);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btncalcular);
            this.Name = "Rectangulo";
            this.Text = "Rectangulo";
            this.Load += new System.EventHandler(this.Rectangulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsuperficie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtperimetro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaltura;
    }
}
namespace Appfunciones
{
    partial class Form2
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.txtC = new System.Windows.Forms.TextBox();
			this.txtX1 = new System.Windows.Forms.TextBox();
			this.txtX2 = new System.Windows.Forms.TextBox();
			this.btncalcular = new System.Windows.Forms.Button();
			this.btnsalir = new System.Windows.Forms.Button();
			this.btnnuevo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ingresa el valor A";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ingresa el valor B";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(45, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "lngresa el valor C";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(45, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "X1 =";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(45, 201);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "X2=";
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(155, 12);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(100, 20);
			this.txtA.TabIndex = 5;
			this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(155, 62);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(100, 20);
			this.txtB.TabIndex = 6;
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(155, 110);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(100, 20);
			this.txtC.TabIndex = 7;
			// 
			// txtX1
			// 
			this.txtX1.Enabled = false;
			this.txtX1.Location = new System.Drawing.Point(155, 158);
			this.txtX1.Name = "txtX1";
			this.txtX1.Size = new System.Drawing.Size(100, 20);
			this.txtX1.TabIndex = 8;
			// 
			// txtX2
			// 
			this.txtX2.Enabled = false;
			this.txtX2.Location = new System.Drawing.Point(155, 194);
			this.txtX2.Name = "txtX2";
			this.txtX2.Size = new System.Drawing.Size(100, 20);
			this.txtX2.TabIndex = 9;
			// 
			// btncalcular
			// 
			this.btncalcular.Location = new System.Drawing.Point(30, 229);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.Size = new System.Drawing.Size(75, 23);
			this.btncalcular.TabIndex = 10;
			this.btncalcular.Text = "Calcular";
			this.btncalcular.UseVisualStyleBackColor = true;
			this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
			// 
			// btnsalir
			// 
			this.btnsalir.Location = new System.Drawing.Point(192, 229);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(75, 23);
			this.btnsalir.TabIndex = 11;
			this.btnsalir.Text = "Salir";
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
			// 
			// btnnuevo
			// 
			this.btnnuevo.Location = new System.Drawing.Point(111, 229);
			this.btnnuevo.Name = "btnnuevo";
			this.btnnuevo.Size = new System.Drawing.Size(75, 23);
			this.btnnuevo.TabIndex = 12;
			this.btnnuevo.Text = "Nuevo";
			this.btnnuevo.UseVisualStyleBackColor = true;
			this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(302, 271);
			this.Controls.Add(this.btnnuevo);
			this.Controls.Add(this.btnsalir);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.txtX2);
			this.Controls.Add(this.txtX1);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Ecuación de segundo grado";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnnuevo;
    }
}
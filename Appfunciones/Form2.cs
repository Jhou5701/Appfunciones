using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appfunciones
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //este evento
            //se ejecuta cada vez que se abre el
            //formulario

            //establecer el control txtX2 solo lectura

        }
        //Crear un metodo o procedimiento
        private double calcularX1(double a, double b, double c)
        {
            //declarar variables
            double x1= 0, d= 0;
            //calcular discriminate
            d = (b * b) - (4 * a * c);
            //verificar si a es distinto a cero
            if (a == 0)
            {
                MessageBox.Show("Erroe al dividir para cero...");
                return 0;//abandonar
            }
            //verificar raices negativas
            if(d < 0)
            {
                MessageBox.Show("Error, la ecuacion tiene soluciones imaginarias...");
                return 0;
            }
            x1 = (-b + Math.Sqrt(d))/(2*a);
            return x1;
        }
        private double calcularX2(double a, double b, double c)
        {
            //declarar variables
            double x2 = 0, d = 0;
            //calcular discriminate
            d = (b * b) - (4 * a * c);
            //verificar si a es distinto a cero
            if (a == 0)
            {
                MessageBox.Show("Erroe al dividir para cero...");
                return 0;//abandonar
            }
            //verificar raices negativas
            if (d < 0)
            {
                MessageBox.Show("Error, la ecuacion tiene soluciones imaginarias...");
                return 0;
            }
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return x2;
        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            //llamada a la funcion calcularX1
            double a, b, c;
            //validar si el usuario a ingresado los valores
            if (this.txtA.Text.Length == 0)
            {
                MessageBox.Show("Porfavor ingresa el valor de A...");
                this.txtA.Focus();//ubica el cursor en el cuadro
                return;//abaandonar
            }
            if (this.txtB.Text.Length == 0)
            {
                MessageBox.Show("Porfavor ingresa el valor de B...");
                this.txtB.Focus();//ubica el cursor en el cuadro
                return;//abaandonar
            }
            if (this.txtC.Text.Length == 0)
            {
                MessageBox.Show("Porfavor ingresa el valor de C...");
                this.txtC.Focus();//ubica el cursor en el cuadro
                return;//abaandonar
            }
            a = Double.Parse(this.txtA.Text);
            b = Double.Parse(this.txtB.Text);
            c = Double.Parse(this.txtC.Text);

            double x1 = calcularX1(a, b, c);
            //asigno el resultado de x1 en el textbox txtX1
            this.txtX1.Text = x1.ToString();

            double x2 = calcularX2(a, b, c);
            //asigno el resultado de x2 en el textbox txtX2
            this.txtX2.Text = x2.ToString();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            //encerar cuadros de texto
            this.txtA.Text = "";
            this.txtB.Text = "";
            this.txtC.Text = "";
            this.txtX1.Text = "";
            this.txtX2.Text = "";
            this.txtA.Focus();
        }
    }
    
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //boton cerrar
        private void button1_Click(object sender, EventArgs e)
        {
            //cierra el formulario
            this.Close();
        }
        //boton sumar
        private void btmsuamar_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse( this.txtnum1.Text.ToString());
            int num2 = Int32.Parse(this.txtnum2.Text.ToString());
            int suma = fnsuma(num1, num2);
            //asigno resultado en cuadro de texto
            this.txtresultado.Text = suma.ToString();
        }
        //funsiones de las operaciones
        int fnsuma(int a, int b)
            {
            return (a + b);
        }
        int fnresta(int a, int b)
        {
            return (a - b);
        }
        int fnmultiplicar(int a, int b)
        {
            return (a * b);
        }

        int fndividir(int a, int b)
        {
            return (a / b);
        }
        //programacion de los botones
        private void btnresta_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(this.txtnum1.Text.ToString());
            int num2 = Int32.Parse(this.txtnum2.Text.ToString());
            int resta = fnresta(num1, num2);
            //asigno resultado en cuadro de texto
            this.txtresultado.Text = resta.ToString();
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(this.txtnum1.Text.ToString());
            int num2 = Int32.Parse(this.txtnum2.Text.ToString());
            int multiplicacion = fnmultiplicar(num1, num2);
            //asigno resultado en cuadro de texto
            this.txtresultado.Text = multiplicacion.ToString();
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(this.txtnum1.Text.ToString());
            int num2 = Int32.Parse(this.txtnum2.Text.ToString());
            int dividir = fndividir(num1, num2);
            //asigno resultado en cuadro de texto
            this.txtresultado.Text = dividir.ToString();
        }
    }
}

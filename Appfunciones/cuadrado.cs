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
    public partial class cuadrado : Form
    {
        public cuadrado()
        {
            InitializeComponent();
        }
        private double calcularperimetro(double lados)
        {
            double perimetro=0;
            perimetro = (lados * 4);
            return perimetro;
        }
        private double calcularsuperficie(double lados)
        {
            double superficie = 0;
            superficie = (lados *lados);
            return superficie;
        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            double a,b;
            if (this.txtlados.Text.Length == 0)
            {
                MessageBox.Show("Porfavor ingresa el valor de Lados...");
                this.txtlados.Focus();//ubica el cursor en el cuadro
                return;//abaandonar
            }
            a = Double.Parse(this.txtlados.Text);
            b = Double.Parse(this.txtlados.Text);
            double superficie = calcularsuperficie(b);
            double perimetro = calcularperimetro(a);
            this.txtperimetro.Text = perimetro.ToString();
            this.txtsuperficie.Text = superficie.ToString();

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.txtlados.Text = "";
            this.txtperimetro.Text = "";
            this.txtsuperficie.Text = "";
        }
    }
}

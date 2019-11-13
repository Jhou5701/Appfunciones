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
    public partial class Rectangulo : Form
    {
        public Rectangulo()
        {
            InitializeComponent();
        }

        private void Rectangulo_Load(object sender, EventArgs e)
        {

        }
        private double calcularsuperficie(double bas, double altura)
        {
            double superficie = 0;
            superficie  = (bas * altura);
            return superficie;
        }
        private double calcularperimetro(double bas, double altura)
        {
            double perimetro = 0;
            perimetro = (bas+altura)*2;
            return perimetro;
        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Double.Parse(this.txtbase.Text);
            b = Double.Parse(this.txtaltura.Text);
            double superficie = calcularsuperficie(a, b);
            double perimetro = calcularperimetro(a,b);
            this.txtperimetro.Text = perimetro.ToString();
            this.txtsuperficie.Text = superficie.ToString();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.txtaltura.Text = "";
            this.txtbase.Text = "";
            this.txtperimetro.Text = "";
            this.txtsuperficie.Text = "";
        }

        private void txtbase_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

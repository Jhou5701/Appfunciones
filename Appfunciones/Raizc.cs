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
    public partial class Raizc : Form
    {
        public Raizc()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private double calcularraiz(double c)
        {
            double raiz = 0;
            raiz = Math.Sqrt(c);
            return raiz;
        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            double a;
            a = Double.Parse(this.txtingreso.Text);
            double raiz = calcularraiz(a);
            this.txtresultado.Text = raiz.ToString();

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.txtingreso.Text = "";
            this.txtresultado.Text = "";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEjercicioTodos
{
    public partial class factorial1 : Form
    {
        public factorial1()
        {
            InitializeComponent();
        }
        private double  factorial (double num)
        {
            double cont = 1;
            for(double i=1;i<=num;i++)
            {
                cont = cont * (i);
            }
            return cont;
        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            double a;
            if(Double.TryParse(this.txtingreso.Text, out a))
            {
                a = Double.Parse(this.txtingreso.Text);
                double cont = factorial(a);
                this.txtresultado.Text = cont.ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar valores numericos");
                this.txtingreso.Focus();
                return;
            }
            
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

        private void factorial1_Load(object sender, EventArgs e)
        {

        }
    }
}

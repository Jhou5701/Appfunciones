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
    public partial class cilindro : Form
    {
        public cilindro()
        {
            InitializeComponent();
        }
       
        private double Carea(double radio, double altura)
        {
            double area = 0, alv = 0;
            alv = (2 * Math.PI * radio * radio );
            area = (2 * Math.PI * radio  * altura + alv);
            return area;

        }
        private double Volumen(double radio, double altura)
        {
            double volumen = 0;
            volumen = (Math.PI * radio * radio * altura);
            return volumen;
        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            double a, b;
            if(this.txtradio.Text.Length == 0)
            {
                MessageBox.Show("Porfavor ingresa el valor de Radio...");
                this.txtradio.Focus();//ubica el cursor en el cuadro
                return;//abaandonar
            }
            if (this.txtaltura.Text.Length == 0)
            {
                MessageBox.Show("Porfavor ingresa el valor de Altura...");
                this.txtvolumen.Focus();//ubica el cursor en el cuadro
                return;//abaandonar
            }
            a = Double.Parse(this.txtradio.Text);
            b = Double.Parse(this.txtaltura.Text);
            double area = Carea(a, b);
            double volumen=Volumen(a,b);
            this.txtarea.Text = area.ToString();
            this.txtvolumen.Text = volumen.ToString();
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.txtradio.Text = "";
            this.txtaltura.Text = "";
            this.txtarea.Text = "";
            this.txtvolumen.Text = "";

        }
    }
}

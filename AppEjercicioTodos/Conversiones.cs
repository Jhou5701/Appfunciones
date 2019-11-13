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
    public partial class Conversiones : Form
    {
        public Conversiones()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private double Fmetros(double metros)
        {
            return (metros * 39.37);

        }
        private double Fpies(double pies)
        {
            return (pies * 3.28084);

        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (this.txtmetros.Text.Length==0)
            {
                MessageBox.Show("Debes ingresar los metros");
                this.txtmetros.Focus();
                return;
            }
            try
            {
                double metros = Double.Parse(this.txtmetros.Text);
                this.txtpulgadas.Text = Fmetros(metros).ToString();
                double pies = Double.Parse(this.txtmetros.Text);
                this.txtpies.Text = Fpies(pies).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.txtmetros.Text = "";
            this.txtpies.Text = "";
            this.txtpulgadas.Text = "";

        }
    }
}

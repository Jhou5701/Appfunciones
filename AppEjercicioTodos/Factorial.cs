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
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }
        private long  Factorial(int factorial)
        {
            int Fa = 1;
            for
        }
        private void btncalcular_Click(object sender, EventArgs e)
        {

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

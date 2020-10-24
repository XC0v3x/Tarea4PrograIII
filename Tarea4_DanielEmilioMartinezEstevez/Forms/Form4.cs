using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_DanielEmilioMartinezEstevez.Forms
{
    public partial class Form4 : Form
    {
        public double porcentaje( double sueldo, double porcentaje)
        {
            double resultado;
            resultado = sueldo * (porcentaje / 100);
            return resultado;

            
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1, n2;
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString (porcentaje(n1, n2)); 
        }
    }
}

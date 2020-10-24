using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_DanielEmilioMartinezEstevez.Forms
{
    public partial class Form5 : Form
    {
        public double Cuota( double precio, double cuota,double meses)
        {
            double total;
            total = (precio + (cuota * precio)) / meses;
            return total;
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double precio, cuota, meses;

            if (textBox1.Text.Trim().Length == 0)
            {
                textBox1.Focus();
                return;
            }

            if (textBox2.Text.Trim().Length == 0)
            {
                textBox2.Focus();
                return;
            }

            if (radioButton2.Checked == true)
            {
                cuota = 0;
            }else
            {
                cuota = 0.35;
            }

            precio = Convert.ToDouble(textBox1.Text);
            meses = Convert.ToDouble(textBox2.Text);

            textBox3.Text = Convert.ToString( Cuota(precio, cuota, meses));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

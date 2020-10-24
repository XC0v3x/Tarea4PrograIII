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
    public partial class Form3 : Form
    {
        public void interes()
        {
            double cantidad, plazo, interes, montomensual;
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta en blanco");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta en blanco");
                textBox2.Focus();
                return;
            }

            if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta en blanco");
                textBox3.Focus();
                return;
            }

            cantidad = Convert.ToDouble(textBox1.Text);
            plazo = Convert.ToDouble(textBox2.Text);
            interes = Convert.ToDouble(textBox3.Text);

            montomensual = (cantidad * (interes / 100)) / plazo;

            textBox4.Text = Convert.ToString(montomensual);

            MessageBox.Show(Convert.ToString(montomensual));

        }
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            interes();
        }
    }
}

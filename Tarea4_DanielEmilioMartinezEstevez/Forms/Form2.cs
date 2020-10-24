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
    public partial class Form2 : Form
    {

        public void salario()
        {
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
            if (textBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta en blanco");
                textBox4.Focus();
                return;
            }

            double SalarioB, HRSX, valorhrs, Coop, sueldoB, sueldoE;
            SalarioB = Convert.ToDouble(textBox2.Text);
            HRSX = Convert.ToDouble(textBox3.Text);
            valorhrs = Convert.ToDouble(textBox4.Text);
            Coop = SalarioB * 0.05;
            sueldoE = HRSX * valorhrs;
            sueldoB = (sueldoE + SalarioB) - Coop;

            textBox5.Text = Convert.ToString(Coop);
            textBox6.Text = Convert.ToString(sueldoE);
            textBox7.Text = Convert.ToString(sueldoB);
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            salario();
        }
    }
}

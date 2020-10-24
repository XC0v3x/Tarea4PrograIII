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
    public partial class Form6 : Form
    {
        public double ventas(double venta1, double venta2, double venta3, double venta4, double venta5)
        {
            double total;
            total = venta1 + venta2 + venta3 + venta4 + venta5;
            return total;
        }

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el Campo no puede estar vacio");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el Campo no puede estar vacio");
                textBox2.Focus();
                return;
            }
            if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el Campo no puede estar vacio");
                textBox3.Focus();
                return;
            }
            if (textBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el Campo no puede estar vacio");
                textBox4.Focus();
                return;
            }
            if (textBox5.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el Campo no puede estar vacio");
                textBox5.Focus();
                return;
            }
            if (textBox6.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el Campo no puede estar vacio");
                textBox6.Focus();
                return;
            }
            if (textBox7.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el Campo no puede estar vacio");
                textBox7.Focus();
                return;
            }

            double n1, n2, n3, n4, n5, porciento;
            n1 = Convert.ToDouble(textBox3.Text);
            n2 = Convert.ToDouble(textBox4.Text);
            n3 = Convert.ToDouble(textBox5.Text);
            n4 = Convert.ToDouble(textBox6.Text);
            n5 = Convert.ToDouble(textBox7.Text);

            textBox8.Text = Convert.ToString(ventas(n1, n2, n3, n4, n5));
            textBox9.Text = Convert.ToString( porciento = ventas(n1, n2, n3, n4, n5) * 0.05);
        }
    }
}

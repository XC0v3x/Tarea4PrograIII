﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_DanielEmilioMartinezEstevez
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tarea4_DanielEmilioMartinezEstevez.Forms.Form2 sueldo1 = new Tarea4_DanielEmilioMartinezEstevez.Forms.Form2();
                sueldo1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tarea4_DanielEmilioMartinezEstevez.Forms.Form3 cuota = new Tarea4_DanielEmilioMartinezEstevez.Forms.Form3();
            cuota.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tarea4_DanielEmilioMartinezEstevez.Forms.Form4 porcentaje = new Tarea4_DanielEmilioMartinezEstevez.Forms.Form4();
            porcentaje.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tarea4_DanielEmilioMartinezEstevez.Forms.Form5 cuota = new Tarea4_DanielEmilioMartinezEstevez.Forms.Form5();
            cuota.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tarea4_DanielEmilioMartinezEstevez.Forms.Form6 ventas = new Tarea4_DanielEmilioMartinezEstevez.Forms.Form6();
            ventas.Show();
        }
    }
}

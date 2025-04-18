﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class frmCronometro : Form
    {
        int hora = 0, min = 0, seg = 0;
        public frmCronometro()
        {
            InitializeComponent();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnInicializar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "00:00:00";
            seg = 0;
            min = 0;
            hora = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg == 60)
            {
                min++;
                seg = 0;
            }
            else if (min == 60)
            {
                hora++;
                min = 0;
            }

            /* Método String.PadLeft (Int32, Char)
               Devuelve una nueva cadena que alinea a la derecha los caracteres de la 
               instancia e inserta a la izquierda un carácter Unicode especificado
               hasta alcanzar la longitud total especificada.
            */
            label1.Text = hora.ToString().PadLeft(2, '0') + ":" +
           min.ToString().PadLeft(2, '0') + ":" + seg.ToString().PadLeft(2, '0');

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}

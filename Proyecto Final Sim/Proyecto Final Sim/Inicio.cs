﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Sim
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FormularioDatos fd = new FormularioDatos();
            fd.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formulario_Menu Menu = new Formulario_Menu();
            Menu.Show();
            this.Hide();

        }
    }
}

using System;
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
    public partial class Formulario_Menu : Form
    {
        public Formulario_Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio I = new Inicio();
            I.Show();
        }

        private void btnIMactual_Click(object sender, EventArgs e)
        {
            Formulario_IMC_MasaMuscular IM = new Formulario_IMC_MasaMuscular();
            IM.Show();
        }

        private void btnConsRE_Click(object sender, EventArgs e)
        {
            Formulario_Rutina_Ejer RE = new Formulario_Rutina_Ejer();
            RE.Show();
        }

        private void btnGenProgress_Click(object sender, EventArgs e)
        {
            Formulario_Progreso P = new Formulario_Progreso();
            P.Show();
        }

        private void btnConsEjer_Click(object sender, EventArgs e)
        {
            Formulario_consu_Dieta D = new Formulario_consu_Dieta();
            D.Show();
        }
    }
}

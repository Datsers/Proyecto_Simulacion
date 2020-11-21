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
    public partial class FormularioDatos : Form
    {
        public FormularioDatos()
        {
            InitializeComponent();
            OcultarLesiones();
        }

        public void OcultarLesiones() 
        {
            cbHombro.Visible = false;
            cbEspalda.Visible = false;
            cbBrazo.Visible = false;
            cbPierna.Visible = false;
            cbRodilla.Visible = false;
        }

        public void MostrarLesiones()
        {
            cbHombro.Visible = true;
            cbEspalda.Visible = true;
            cbBrazo.Visible = true;
            cbPierna.Visible = true;
            cbRodilla.Visible = true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio I = new Inicio();
            I.Show();
        }

        private void cbM_CheckedChanged(object sender, EventArgs e)
        {
            if (cbM.Checked==true)
            {
                cbF.Checked = false;
            }
        }

        private void cbF_CheckedChanged(object sender, EventArgs e)
        {
            if (cbF.Checked == true)
            {
                cbM.Checked = false;
            }
        }

        private void cbECsi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbECsi.Checked==true)
            {
                cbECno.Checked = false;
            }
        }

        private void cbECno_CheckedChanged(object sender, EventArgs e)
        {
            if (cbECno.Checked == true)
            {
                cbECsi.Checked = false;
            }
        }

        private void cbLPsi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLPsi.Checked == true) 
            {
                cbLPno.Checked = false;
                MostrarLesiones();
            }
        }

        private void cbLPno_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLPno.Checked == true)
            {
                cbLPsi.Checked = false;
                OcultarLesiones();
            }
        }
        ClsUser objUser;
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //try
            //{
                objUser = new ClsUser(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtPeso.Text), Convert.ToInt32(txtAltura.Text),
                Convert.ToInt32(txtEdad.Text), EnviarChar(cbM, cbF), EnviarChar(cbLPsi, cbLPno), EnviarChar(cbECsi, cbECno),
                EnviarChar(cbHombro), EnviarChar(cbPierna), EnviarChar(cbEspalda), EnviarChar(cbBrazo), EnviarChar(cbRodilla));
                objUser.Insertar_Usuario();
                MessageBox.Show(""+objUser.Id, objUser.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Formulario_Menu menu = new Formulario_Menu();
                menu.Show();
                this.Hide();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Asegurese de dar bien los datos");
            //}
        }

        private char EnviarChar(CheckBox cb1)
        {
            if (cb1.Checked)
            {
                return 'S';
            }
            else
            {
                return 'N';
            }
        }

        private string EnviarChar(CheckBox cb1, CheckBox cb2)
        {
            if (cb1.Checked&&cb2.Checked||cb1.CheckState==CheckState.Unchecked&& cb2.CheckState == CheckState.Unchecked)
            {
                return "";
            }
            else
            {
                if (cb1.Checked)
                {
                    return cb1.Text;
                }
                if (cb2.Checked)
                {
                    return cb2.Text;
                }
                return "";
            }
        }
    }
}

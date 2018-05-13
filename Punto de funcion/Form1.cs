using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_funcion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPFSA_Click(object sender, EventArgs e)
        {
            bool flag = false;
            int total_EE = 0, total_SE = 0, total_CE = 0, total_ALI = 0, total_AIE = 0;
            if (cmbComplejidad.SelectedItem != null)
            {
                flag = true;
                if (cmbComplejidad.SelectedItem == "SIMPLE")
                {
                    total_EE = Convert.ToInt32(txtEE.Text) * 3;
                    total_SE = Convert.ToInt32(txtSE.Text) * 4;
                    total_CE = Convert.ToInt32(txtCE.Text) * 3;
                    total_ALI = Convert.ToInt32(txtALI.Text) * 7;
                    total_AIE = Convert.ToInt32(txtAIE.Text) * 5;
                }
                else if (cmbComplejidad.SelectedItem == "MEDIO")
                {
                    total_EE = Convert.ToInt32(txtEE.Text) * 4;
                    total_SE = Convert.ToInt32(txtSE.Text) * 5;
                    total_CE = Convert.ToInt32(txtCE.Text) * 4;
                    total_ALI = Convert.ToInt32(txtALI.Text) * 10;
                    total_AIE = Convert.ToInt32(txtAIE.Text) * 7;
                }
                else if (cmbComplejidad.SelectedItem == "COMPLEJO")
                {
                    total_EE = Convert.ToInt32(txtEE.Text) * 6;
                    total_SE = Convert.ToInt32(txtSE.Text) * 7;
                    total_CE = Convert.ToInt32(txtCE.Text) * 6;
                    total_ALI = Convert.ToInt32(txtALI.Text) * 15;
                    total_AIE = Convert.ToInt32(txtAIE.Text) * 10;
                }
            }
            else
                MessageBox.Show("Selecciona una complejidad");
            if(flag)
            {
                txt_total_EE.Text = total_EE.ToString();
                txt_total_SE.Text = total_SE.ToString();
                txt_total_CE.Text = total_CE.ToString();
                txt_total_ALI.Text = total_ALI.ToString();
                txt_total_AIE.Text = total_AIE.ToString();
                txtPFSA.Text = (total_EE + total_SE + total_CE + total_ALI + total_AIE).ToString();
            }
        }

        private void btnCalcularFA_Click(object sender, EventArgs e)
        {
            int FA1, FA2, FA3, FA4, FA5, FA6, FA7, FA8, FA9, FA10, FA11, FA12, FA13, FA14;
            FA1 = Convert.ToInt32(txt_FA1.Text);
            FA2 = Convert.ToInt32(txt_FA2.Text);
            FA3 = Convert.ToInt32(txt_FA3.Text);
            FA4 = Convert.ToInt32(txt_FA4.Text);
            FA5 = Convert.ToInt32(txt_FA5.Text);
            FA6 = Convert.ToInt32(txt_FA6.Text);
            FA7 = Convert.ToInt32(txt_FA7.Text);
            FA8 = Convert.ToInt32(txt_FA8.Text);
            FA9 = Convert.ToInt32(txt_FA9.Text);
            FA10 = Convert.ToInt32(txt_FA10.Text);
            FA11 = Convert.ToInt32(txt_FA11.Text);
            FA12 = Convert.ToInt32(txt_FA12.Text);
            FA13 = Convert.ToInt32(txt_FA13.Text);
            FA14 = Convert.ToInt32(txt_FA14.Text);
            txtFA.Text = (FA1 + FA2 + FA3 + FA4 + FA5+ FA6 + FA7 + FA8 + FA9 + FA10 + FA11 + FA12 + FA13 + FA14).ToString();
        }

        private void btnHorasCostos_Click(object sender, EventArgs e)
        {
            double horas_hombre = 0.0, costos = 0.0, PFA = 0.0, PFSA, FA;
            PFSA = Convert.ToDouble(txtPFSA.Text);
            FA = Convert.ToDouble(txtFA.Text);
            PFA = PFSA * (0.65 + (0.01 * FA));
            PFA = Math.Round(PFA);
            txtPFA.Text = PFA.ToString();
            horas_hombre = PFA * 8;
            txtHorasHombre.Text = horas_hombre.ToString();
        }
    }
}

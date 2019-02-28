using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class frmIMC : Form
    {
        RadioButton rdbSelecionado = null;
        public frmIMC()
        {
            InitializeComponent();
        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            SetPesoIdeal();
        }

        private void SetPesoIdeal()
        {
            try
            {
                double altura = Convert.ToDouble(txtAltura.Text);
                double pesoIdeal = 0;

                if(rdbMasculino.Checked == true)
                {
                    pesoIdeal = (72.7 * altura) - 58;
                    lblResultado.Text = pesoIdeal.ToString();
                }else if(rdbFeminino.Checked == true)
                {
                    pesoIdeal = (62.1 * altura) - 44.7;
                    lblResultado.Text = pesoIdeal.ToString();
                }
                else
                {
                    lblResultado.Text = "0";
                }
            }catch(Exception e)
            {
                MessageBox.Show("Informe a altura corretamente e Selecione um sexo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rdbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            SetPesoIdeal();
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            SetPesoIdeal();
        }
    }
}

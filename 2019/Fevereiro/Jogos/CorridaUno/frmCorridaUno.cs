using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorridaUno
{
    public partial class frmCorridaUno : Form
    {
        public frmCorridaUno()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int velocidade;
            velocidade = Convert.ToInt32(txtVelocidade.Text);

            //início da verificação da velocidade
            if(velocidade > 450)
            {
                MessageBox.Show("Isso não existe");
                // essa mensagem será exibida se a condição for verdadeira, ou seja se a velocidade for maior que 450, por exemplo 480
            }
            else if(velocidade < 50)
            {
                MessageBox.Show("Acelara Rubinho....");
            }
            else
            {
                MessageBox.Show("Boa campeão!! Quem é o campeão? É você!!!");
                //essa mensagem será exibida se a condição for falsa, ou seja, caso a velocidade for abaixo de 450
            }

            if(rdbMarcha1.Checked == true)
            {
                MessageBox.Show("Marcha 1");
            }else if(rdbMarcha2.Checked == true)
            {
                MessageBox.Show("Marcha 2");
            }else if (rdbMarcha3.Checked == true)
            {
                MessageBox.Show("Marcha 3");
            }
            else
            {
                MessageBox.Show("Nenhuma marcha selecionada");
            }
        }
    }
}

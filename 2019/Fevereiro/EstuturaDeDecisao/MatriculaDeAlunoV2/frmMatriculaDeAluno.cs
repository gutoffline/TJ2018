using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaDeAlunoV2
{
    public partial class frmMatriculaDeAluno : Form
    {
        public frmMatriculaDeAluno()
        {
            InitializeComponent();
            lblDataDeHoje.Text = "Hoje: " + DateTime.Now.ToShortDateString();
        }

        private void btnIdentificarCategoria_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == String.Empty){
                MessageBox.Show("O nome não pode ser em branco.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else{
                TimeSpan tsQuantidadeDeDias = DateTime.Now.Date - dtpDataDeNascimento.Value;
                int idade = (tsQuantidadeDeDias.Days / 365);
                if (idade > 17)
                {
                    lblExibirCategoria.Text = "Adulto";
                }
                else if (idade > 13)
                {
                    lblExibirCategoria.Text = "Juvenil B";
                }
                else if (idade > 10)
                {
                    lblExibirCategoria.Text = "Juvenil A";
                }
                else if (idade > 7)
                {
                    lblExibirCategoria.Text = "Infantil B";
                }
                else if (idade >= 5)
                {
                    lblExibirCategoria.Text = "Infantil A";
                }
                else
                {
                    lblExibirCategoria.Text = "Não existe categoria";
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaDeAluno
{
    public partial class frmMatriculaAluno : Form
    {
        public frmMatriculaAluno()
        {
            InitializeComponent();
        }

        private void txtUltimoAniversario_Enter(object sender, EventArgs e)
        {
            if(txtAnoNascimento.Text.Length != 4)
            {
                MessageBox.Show("Informe o ano de nascimento corretamente.","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnoNascimento.Focus();
            }

        }

        private void txtUltimoAniversario_Validating(object sender, CancelEventArgs e)
        {
            if(txtUltimoAniversario.Text == String.Empty || Convert.ToInt32(txtAnoNascimento.Text) > Convert.ToInt32(txtUltimoAniversario.Text))
            {
                MessageBox.Show("O ano de nascimento tem que ser menor que o ano do último aniversário", "Atenção" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void btnIdentificarCategoria_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == String.Empty)
            {
                MessageBox.Show("O nome não pode ser vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }
            else
            {
                int idade = Convert.ToInt32(txtUltimoAniversario.Text) - Convert.ToInt32(txtAnoNascimento.Text);
                
                if(idade > 17){
                    lblExibirCategoria.Text = "Adulto";
                }else if(idade > 13){
                    lblExibirCategoria.Text = "Juvenil B";
                }else if(idade > 10){
                    lblExibirCategoria.Text = "Juvenil A";
                }else if(idade > 7){
                    lblExibirCategoria.Text = "Infantil B";
                }else if(idade >= 5){
                    lblExibirCategoria.Text = "Infantil A";
                }else{
                    lblExibirCategoria.Text = "Não existe categoria";
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoAdivinhacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            int valorJogador, valorComputador;
            Random dados = new Random();
            valorComputador = dados.Next(0, 11);

            valorJogador = Convert.ToInt32(txtValor.Text);

            if(valorJogador == valorComputador)
            {
                MessageBox.Show("Você Ganhou!!!\nComputador: " + valorComputador.ToString(), "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GravarPlacar(" GANHOU");
                Limpar();
            }
            else
            {
                MessageBox.Show("Você perdeu...\nComputador: " + valorComputador.ToString(), "Que pena", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                lblTentativas.Text = (Convert.ToInt32(lblTentativas.Text) + 1).ToString();
            }

            if(lblTentativas.Text == "3")
            {
                MessageBox.Show("Fim de Jogo", "Acabou", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GravarPlacar(" PERDEU");
                Limpar();
            }
        }

        private void Limpar()
        {
            txtNome.Text = "";
            txtValor.Text = "";
            lblTentativas.Text = "0";
        }

        private void GravarPlacar(string resultado)
        {
            StreamWriter arquivo;
            string caminho = "C:\\teste\\placar.txt";
            arquivo = File.AppendText(caminho);

            arquivo.Write(txtNome.Text);
            arquivo.WriteLine(resultado);
            arquivo.WriteLine();

            arquivo.Close();
        }

        private void btnPlacar_Click(object sender, EventArgs e)
        {
            string caminho = "C:\\teste\\placar.txt";
            System.Diagnostics.Process.Start("notepad", caminho);
        }
    }
}

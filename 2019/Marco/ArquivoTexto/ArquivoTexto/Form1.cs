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

namespace ArquivoTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            StreamWriter arquivo;
            string CaminhoNome = "C:\\teste\\registros.txt";

            //utilizando o metodo para criar um arquivo texto e associando o caminho e nome ao metodo
            arquivo = File.AppendText(CaminhoNome);

            //aqui, exemplo de escrever no arquivo texto escrevendo o titulo
            arquivo.Write("Nome: ");
            arquivo.Write(txtNome.Text);
            //pulando linha sem escrita
            arquivo.WriteLine();
            //fechando o arquivo texto com o método .Close()
            arquivo.Close();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //Colocando o endereço físico (caminho do arquivo texto) 
            string Caminho = "C:\\teste\\registros.txt";
            //Abrindo o arquivo texto em um leitor de texto, no caso, o bloco de notas(notepad)
            System.Diagnostics.Process.Start("notepad", Caminho);
            //feito isso, será aperto o bloco de notas com o conteúdo do registros.txt
        }
    }
}

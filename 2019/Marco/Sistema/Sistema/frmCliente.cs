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

namespace Cadastros
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string vegano, lactose, diabetico, estadoCivil, vegetariano;
            if(ckbDiabetico.Checked == true)
            {
                vegano = "Sim";
            }
            else
            {
                vegano = "Não";
            }

            if(ckbDiabetico.Checked == true)
            {
                diabetico = "Sim";
            }
            else
            {
                diabetico = "Não";
            }

            if(ckbLactose.Checked == true)
            {
                lactose = "sim";
            }
            else
            {
                lactose = "não";
            }

            if (ckbVegetariano.Checked == true)
            {
                vegetariano = "Sim";
            }
            else
            {
                vegetariano = "Não";
            }

            if(rdbCasado.Checked == true)
            {
                estadoCivil = "Casado";
            }else if(rdbSolteiro.Checked == true)
            {
                estadoCivil = "Solteiro";
            }
            else
            {
                estadoCivil = "";
            }

            GravarCliente(txtNome.Text, txtEmail.Text, mkdTelefone.Text, mkdCelular.Text, cmbCidade.Items[cmbCidade.SelectedIndex].ToString(), cmbEstado.Items[cmbEstado.SelectedIndex].ToString(), estadoCivil, vegetariano, vegano, lactose, diabetico);

            MessageBox.Show("Cliente gravado com sucesso!" , "Sucesso!" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GravarCliente(string nome, string email, string telefone, string celular, string cidade, string estado, string estadoCivil, string vegetariano, string vegano, string lactose, string diabetico)
        {
            StreamWriter arquivo;
            string caminho = "C:\\teste\\clientes.txt";

            arquivo = File.AppendText(caminho);
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("E-mail: " + email);
            arquivo.WriteLine("Telefone(s): " + telefone + "  " + celular);
            arquivo.WriteLine("Local: " + cidade + " (" + estado + ")");
            arquivo.WriteLine("Estado Civil: " + estadoCivil);
            arquivo.WriteLine("Vegetariano? " + vegetariano);
            arquivo.WriteLine("Vegano? " + vegano);
            arquivo.WriteLine("Intolerante à lactose? " + lactose);
            arquivo.WriteLine("Diabético? " + diabetico);
            arquivo.WriteLine("====================================================");
            arquivo.WriteLine("");
            arquivo.WriteLine("");
            arquivo.Close();
        }

    }
}

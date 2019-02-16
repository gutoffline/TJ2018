using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntecessorSucessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtSucessor.Text = (Convert.ToInt32(txtNumero.Text) + 1).ToString();
            txtAntecessor.Text = (Convert.ToInt32(txtNumero.Text) - 1).ToString();

            MessageBox.Show("O ANTECESSOR do número " + txtNumero.Text + " é " + txtAntecessor.Text + " e o SUCESSOR é " + txtSucessor.Text);
        }
    }
}

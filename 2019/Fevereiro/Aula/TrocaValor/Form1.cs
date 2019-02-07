using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaValor
{
    public partial class frmTrocaValor : Form
    {
        public frmTrocaValor()
        {
            InitializeComponent();
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            string auxiliar;
            auxiliar = txtValor1.Text;
            txtValor1.Text = txtValor2.Text;
            txtValor2.Text = auxiliar;
            MessageBox.Show("Troca efetuada com sucesso", "TROUCOU!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

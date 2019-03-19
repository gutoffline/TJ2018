using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAbrirForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            frmCalculadora fCalculadora = new frmCalculadora();
            fCalculadora.Show();
        }

        private void btnAcrescimo_Click(object sender, EventArgs e)
        {
            frmAcrescimo fAcrescimo = new frmAcrescimo();
            fAcrescimo.Show();
        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            frmDesconto fDesconto = new frmDesconto();
            fDesconto.Show();
        }
    }
}

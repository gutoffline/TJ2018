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
    public partial class frmAcrescimo : Form
    {
        public frmAcrescimo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtTotal.Text = (Acrescimo(Convert.ToDouble(txtValor.Text), Convert.ToDouble(txtAcrescimo.Text))).ToString();
        }

        private double Acrescimo(double valor, double taxa)
        {
            double total;
            total = valor + valor * (taxa / 100);
            return total;
        }
    }
}

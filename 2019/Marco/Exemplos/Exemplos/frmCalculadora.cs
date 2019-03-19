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
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (Soma(Convert.ToDouble(txtNumero1.Text) , Convert.ToDouble(txtNumero2.Text))).ToString();
        }

        private double Soma(double num1, double num2)
        {
            double total;
            total = num1 + num2;
            return total;
        }

        private double Subtracao(double num1, double num2)
        {
            double total;
            total = num1 - num2;
            return total;
        }
        private double Multiplicacao(double num1 , double num2)
        {
            double total;
            total = num1 * num2;
            return total;
        }

        private double Divisao(double num1 , double num2)
        {
            double total;
            total = num1 / num2;
            return total;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (Subtracao(Convert.ToDouble(txtNumero1.Text), Convert.ToDouble(txtNumero2.Text))).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (Divisao(Convert.ToDouble(txtNumero1.Text), Convert.ToDouble(txtNumero2.Text))).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (Multiplicacao(Convert.ToDouble(txtNumero1.Text), Convert.ToDouble(txtNumero2.Text))).ToString();
        }
    }
}

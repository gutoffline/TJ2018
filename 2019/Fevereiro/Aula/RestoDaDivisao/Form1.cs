using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoDaDivisao
{
    public partial class frmRestoDaDivisao : Form
    {
        public frmRestoDaDivisao()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResto.Text = (Convert.ToDouble(txtDividendo.Text) % Convert.ToDouble(txtDivisor.Text)).ToString();
        }
    }}

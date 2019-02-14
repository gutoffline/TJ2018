using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortaDosDesesperados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPorta1_Click(object sender, EventArgs e)
        {
            imgPorta2.Visible = false;
            btnPorta2.Visible = false;
            imgPorta3.Visible = false;
            btnPorta3.Visible = false;
            imgPorta1.Image = PortaDosDesesperados.Properties.Resources.macaco;
        }

        private void btnPorta2_Click(object sender, EventArgs e)
        {
            btnPorta1.Visible = false;
            imgPorta1.Visible = false;
            imgPorta3.Visible = false;
            btnPorta3.Visible = false;
            imgPorta2.Image = PortaDosDesesperados.Properties.Resources.bicicleta;
        }

        private void btnPorta3_Click(object sender, EventArgs e)
        {
            imgPorta1.Visible = false;
            btnPorta1.Visible = false;
            imgPorta2.Visible = false;
            btnPorta2.Visible = false;
            imgPorta3.Image = PortaDosDesesperados.Properties.Resources.monstro;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            imgPorta1.Image = PortaDosDesesperados.Properties.Resources.iconfinder_10_61474;
            imgPorta2.Image = PortaDosDesesperados.Properties.Resources.iconfinder_10_61474;
            imgPorta3.Image = PortaDosDesesperados.Properties.Resources.iconfinder_10_61474;

            imgPorta1.Visible = true;
            imgPorta2.Visible = true;
            imgPorta3.Visible = true;

            btnPorta1.Visible = true;
            btnPorta2.Visible = true;
            btnPorta3.Visible = true;
        }
    }
}

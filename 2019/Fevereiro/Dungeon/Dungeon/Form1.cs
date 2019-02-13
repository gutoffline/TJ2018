using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            string monstro1 = "Frank", monstro2 = "Jason", monstro3 = "Dracula";

            int aleatorio = 0;
            Random dado = new Random();
            aleatorio = dado.Next(1, 3);
            if(aleatorio == 1)
            {
                imgDrac.Visible = false;
                imgJason.Visible = false;
                imgFrank.Visible = true;
            }
            if (aleatorio == 2)
            {
                imgDrac.Visible = false;
                imgJason.Visible = true;
                imgFrank.Visible = false;
            }
            if (aleatorio == 3)
            {
                imgDrac.Visible = true;
                imgJason.Visible = false;
                imgFrank.Visible = false;
            }
        }
    }
}

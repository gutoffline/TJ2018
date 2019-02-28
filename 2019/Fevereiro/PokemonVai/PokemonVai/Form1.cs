using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonVai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPokemon_Click(object sender, EventArgs e)
        {
            Pokemon poke1 = new Pokemon();
            Pokemon poke2 = new Pokemon();

            poke1.nome = "pikachu";
            poke1.tipo = "elétrico";
            poke1.peso = 100;
            poke1.altura = 1.5;

            poke2.nome = "raichu";
            poke2.tipo = "elétrico";
            poke2.peso = 120;
            poke2.altura = 1.9;
            
        }
    }
}

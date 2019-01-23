using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalaboucosEDragoes
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome="", classe="", raca = "";
            int vida = 100;

            Console.WriteLine("Informe seu nome aventureiro.");
            nome = Console.ReadLine();

            Console.WriteLine("Informe sua raça.");
            raca = Console.ReadLine();

            Console.WriteLine("Informe sua classe.");
            classe = Console.ReadLine();

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Ficha: ");
            Console.WriteLine(nome);
            Console.WriteLine(classe);
            Console.WriteLine(raca);
            Console.WriteLine("---------------------------------");

            string resposta = "";
            Console.WriteLine("Deseja entrar na porta a sua direita?");
            resposta = Console.ReadLine();

            if(resposta == "sim")
            {


            }
        }
    }
}

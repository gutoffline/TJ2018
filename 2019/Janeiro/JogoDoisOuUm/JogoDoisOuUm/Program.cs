using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDoisOuUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================ JOGO DE DOIS OU UM ================ ");
            Console.WriteLine("||                                                ||");
            Console.WriteLine("||    ___________                  ___________    ||");
            Console.WriteLine("||   |           |                |           |   ||");
            Console.WriteLine("||   |     _     |                |     _     |   ||");
            Console.WriteLine("||   |    |_|    |                |    |_|    |   ||");
            Console.WriteLine("||   |     _     |      /\\        |     _     |   ||");
            Console.WriteLine("||   |    |_|    |     /  \\       |    |_|    |   ||");
            Console.WriteLine("||   |    ___    |    /    \\      |    ___    |   ||");
            Console.WriteLine("||   |   |   |   |    |  _ |      |   |   |   |   ||");
            Console.WriteLine("||   |   |   |   |    | | ||      |   |   |   |   ||");
            Console.WriteLine("____________________________________________________");
            Console.ReadLine();

            int numeroJogador1, numeroJogador2, numeroComputador;
            Console.WriteLine("Jogador 1");
            numeroJogador1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jogador 2");
            numeroJogador2 = Convert.ToInt32(Console.ReadLine());

            Random aleatorio = new Random();
            numeroComputador = aleatorio.Next(1, 2);

            if( numeroComputador == numeroJogador2 && numeroJogador1 == numeroJogador2)
            {
                Console.WriteLine("Todos perderam");
            }
            else if(numeroJogador1 == numeroJogador2) {
                Console.WriteLine("Computador Ganhou");
            }else if(numeroJogador1 == numeroComputador)
            {
                Console.WriteLine("Jogador 2 Ganhou");
            }
            else
            {
                Console.WriteLine("Jogador 1 Ganhou");
            }
            Console.ReadKey();

        }
    }
}

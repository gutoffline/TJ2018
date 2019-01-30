using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAdivinhar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUsuario, numeroAleatorio;

            Random aleatorio = new Random();
            numeroAleatorio = aleatorio.Next(0, 10);

            Console.WriteLine("Informe um número de 0 à 10");
            numeroUsuario = Convert.ToInt32(Console.ReadLine());

            if(numeroUsuario == numeroAleatorio)
            {
                Console.WriteLine("Parabéns, você ganhou o jogo!");
            }
            else
            {
                Console.WriteLine("Que pena! Você perdeu.");
            }

            Console.WriteLine("Número sorteado " + numeroAleatorio);

            Console.ReadKey();
        }
    }
}

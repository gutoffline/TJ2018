using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroAleatorio, numeroUsuario, total;
            string opcao, resultado;

            Random aleatorio = new Random();
            numeroAleatorio = aleatorio.Next(0, 10);

            Console.WriteLine("Escolha (P)AR ou (I)MPAR");
            opcao = Console.ReadLine();

            Console.WriteLine("Informe um número de 0 à 10");
            numeroUsuario = Convert.ToInt32(Console.ReadLine());

            total = numeroAleatorio + numeroUsuario;

            if( total % 2 == 0)
            {
                Console.WriteLine("O número é par");
                resultado = "P";
            }
            else
            {
                Console.WriteLine("O número é ímpar");
                resultado = "I";
            }

            Console.WriteLine("A soma dos números é: " + total);

            if (resultado == opcao)
            {
                Console.WriteLine("Você ganhou!");
            }
            else
            {
                Console.WriteLine("Você perdeu!");
            }

            Console.ReadKey();
        }
    }
}

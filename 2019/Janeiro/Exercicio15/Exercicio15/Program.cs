using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use a estrutura de repetição enquanto condição faz para mostrar uma contagem de números pares na tela.Essa contagem deve iniciar em 0 e terminar com um número previamente informado pelo usuário.

            int numero = 0;
            int contador = 0;
            Console.WriteLine("Informe um número")
            numero = Int32(Console.ReadLine());
            if(numero % 2 == 0)
            {
                Console.WritLine("O número que você digitou é par. Vamos usar ele.");
            }
            else
            {
                numero++;
                Consloe.WriteLine("O número que você digitou é par. Vamos usar ele esse " +numero + ".");
            }
            for(contador = 0; contdor <= numreo ; contador = contador + 2)
            {
                Console.WriteLine(contador);
            }
            Console.ReadKey();
        }
    }
}

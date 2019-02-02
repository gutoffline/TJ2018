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
            string nome="", classe="", raca = "", idade="";
            int vida = 100;

            Console.WriteLine("Informe seu nome aventureiro.");
            nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade.");
            idade = Console.ReadLine();

            Console.WriteLine("Informe sua raça.");
            raca = Console.ReadLine();

            Console.WriteLine("Informe sua classe.");
            classe = Console.ReadLine();

            Ficha(nome , raca, classe , vida , idade);

            string resposta = "";
            Console.WriteLine("Deseja entrar na porta a sua direita?");
            resposta = Console.ReadLine();

            if(resposta == "sim")
            {
                Console.WriteLine("Tem um monstrão aqui!!!");
                Console.WriteLine("Ele mordeu sua orelha, o monstro chama MYKE TYSON!!!! \nPerca 50 de vida...");
                vida = vida - 50;
            }

            Ficha(nome , raca, classe, vida , idade);

            Console.WriteLine("Deseja entrar na porta a sua direita?");
            resposta = Console.ReadLine();

            if (resposta == "sim")
            {
                Console.WriteLine("MAIS VIDA");
                Console.WriteLine("GANHE 30 de vida...");
                vida = vida + 30;
            }

            Console.WriteLine("Deseja entrar na porta a sua direita?");
            resposta = Console.ReadLine();

            if (resposta == "sim")
            {
                Console.WriteLine("Tem outro monstrão aqui!!!");
                Console.WriteLine("Você tomou um cruzado!!!! \nPerca 50 de vida...");
                vida = vida - 50;
            }


            if(vida <= 0)
            {
                Console.WriteLine("Morrrrreeeeeuuuuu!!!!");
            }
            else
            {
                Console.WriteLine("Deseja entrar na porta a sua direita?");
                resposta = Console.ReadLine();

                if (resposta == "sim")
                {
                    Console.WriteLine("AQUI TEM UM TESOURO aqui!!!");
                    Console.WriteLine("VOCÊ ESTÁ MILIONÁRIO");
                    vida = vida - 50;
                }
            }

            Console.WriteLine("Fim de Jogo...até a próxima!");
            Console.ReadKey();
        }

        static void Ficha(string nome , string classe, string raca, int vida, string idade)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Ficha: ");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Classe: " + classe);
            Console.WriteLine("Raça: " + raca);
            Console.WriteLine("Vida: " + vida);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("===================================");
        }
    }
}

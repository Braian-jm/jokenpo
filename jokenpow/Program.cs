using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedra_papel_tesoura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("JOKENPO"); 
            Console.WriteLine("Pressione [1] para singleplayer - [2] para multplayer");
            string modo = Console.ReadLine(); 

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("digite seu nome");
            string status = "1";
            string nome = Console.ReadLine();
            if (modo == "1")
            {
                status = "11";
            }
            else
            {
                status = "12"; 
            };
            Console.ReadKey();
            Console.WriteLine("Hello world " + nome);
            int vitorias = 0;
            int empates = 0;
            int derrotas = 0;
            while (status == "11") 
            {
                Console.Clear();
                Console.WriteLine("jogador: " + nome + "      Vitorias:" + vitorias + "   derrotas: " + derrotas + "   empates: " + empates);
                Random numero = new Random();
                int jogadaPc = numero.Next(1, 4);


                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("1 para papel, 2 para tesoura, 3 para pedra");
                int player = int.Parse(Console.ReadLine());
                if (player == jogadaPc)
                {
                    Console.WriteLine("empate");
                    empates++;
                    Console.ReadKey();
                }
                else if ((jogadaPc == 1 && player == 2) ||
                       (jogadaPc == 2 && player == 3) ||
                       (jogadaPc == 3 && player == 1))
                {
                    Console.WriteLine("voce venceu");
                    vitorias++;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("voce perdeu");
                    derrotas++;
                    Console.ReadKey();
                }
                Console.Clear();
                Console.WriteLine("quer jogar novamente? ");
                Console.WriteLine("[1] sim, [2] não");
                string decisão = Console.ReadLine();
                if (decisão == "1")
                {
                    status = "11";
                }
                else
                {
                    status = "0";
                }



            } 
            while(status == "12")
            {
            Console.Clear(); 
            Console.WriteLine("jogador 1: 1 para papel, 2 para tesoura, 3 para pedra");
            
            

            }

        } 
    }
}

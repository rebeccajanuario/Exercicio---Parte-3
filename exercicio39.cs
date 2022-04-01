using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio39
    {
        static void Main39(string[] args)
        {
            int numero;
            bool parar = false;
            string opcao;


            do
            {
                Console.Write("Digite um número inteiro: ");
                numero = Convert.ToInt32(Console.ReadLine());



                if (numero % 2 == 0)
                {
                    Console.Write("O número é par.\n");
                }
                else
                {
                    Console.Write("O número é ímpar\n");
                }
                if (numero < 0)
                {
                    Console.Write("O número é negativo\n");
                }
                else
                {
                    Console.Write("O número é positivo\n");
                }


                Console.WriteLine("\n\nDeseja sair? (s/N)? ");
                opcao = Convert.ToString(Console.ReadLine());
                if (opcao == "S" || opcao == "s")
                {
                    parar = true;
                }


            } while (parar == false);
            Console.ReadKey();



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio37
    {
        static void Main37(string[] args)
        {
            int opcao;
            int numero1;
            int numero2;
            string cont;
            bool encerrar = false;
            Console.WriteLine("Programa para realizar operações matemáticas");
            while (encerrar == false)
            {


                Console.WriteLine("Digite uma das opções para as operações:\n1 – Adição\n2 – Subtração\n3 – Multiplicação\n4 – Divisão");
                opcao = Convert.ToInt32(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Entre com o primeiro número: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entre com o segundo número: ");
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Resultado de " + numero1 + " + " + numero2 + " = " + (numero1 + numero2));
                        break;
                    case 2:
                        Console.WriteLine("Entre com o primeiro número: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entre com o segundo número: ");
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Resultado de " + numero1 + " - " + numero2 + " = " + (numero1 - numero2));
                        break;
                    case 3:
                        Console.WriteLine("Entre com o primeiro número: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entre com o segundo número: ");
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Resultado de " + numero1 + " x " + numero2 + " = " + (numero1 * numero2));
                        break;
                    case 4:
                        Console.WriteLine("Entre com o primeiro número: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entre com o segundo número: ");
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Resultado de " + numero1 + " / " + numero2 + " = " + (numero1 / numero2));
                        break;
                    default:
                        Console.WriteLine("Opção inválida, digite novamente a opção: ");
                        opcao = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                Console.WriteLine("\n\nDeseja continuar?(s/n)");
                cont = Console.ReadLine();
                if (cont == "N" || cont == "n")
                {
                    encerrar = true;
                }
            }
            Console.ReadKey();
        }
    }
}

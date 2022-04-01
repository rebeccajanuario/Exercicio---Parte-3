using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio34
    {
        static void Main34(string[] args)
        {
            int numero;
            int maior;
            int menor;


            Console.Write("Entre com um número (Negativo para sair!): ");
            numero = Convert.ToInt32(Console.ReadLine());


            if (numero >= 0)
            {
                menor = numero;
                maior = numero;
                while (numero >= 0)
                {
                    Console.Write("Entre com outro número: ");
                    numero = Convert.ToInt16(Console.ReadLine());
                    if (numero > maior)
                    {
                        maior = numero;
                    }
                    if (numero < menor && numero >= 0)
                    {
                        menor = numero;
                    }
                }
                Console.WriteLine("\nO maior número foi: " + maior + " e o menor foi: " + menor);
            }
        }
    }
}
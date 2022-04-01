using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio32
    {
        static void Main32(string[] args)
        {
            int numero = 0;
            int quad = 0;
            do
            {
                Console.WriteLine("\nEntre com um número positivo menor que 10:");
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero > 0 && numero < 10);
            for (int i = numero; i < 40 + numero; i++)
            {
                if (i % 2 == 1)
                {
                    quad += i * i;
                }
            }
            Console.WriteLine("A soma é igual a: " + quad);
        }
    }
}

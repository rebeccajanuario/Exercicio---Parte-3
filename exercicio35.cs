using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio35
    {
        static void Main35(string[] args)
        {
            int numero;


            for (numero = 1; numero <= 100; numero++)
            {
                if (numero % 10 == 0)
                {
                    Console.WriteLine(numero + ": Multiplo de 10");
                }
                else
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio43
    {
        static void Main43(string[] args)
        {
            double graosCasa = 1;
            double casasTabuleiro = 64;
            int graos = 1;

            for (int x = 1; x < casasTabuleiro; x++)
            {
                graosCasa = graosCasa * 2;
                graos += (int)graosCasa;
            }

            Console.WriteLine("\nO quantidade de grãos é: " + graos);
        }
    }
}

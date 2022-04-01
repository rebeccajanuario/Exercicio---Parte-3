using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio31
    {
        static void Main31(string[] args)
        {
            int numero = 0;
            int par = 0;
            int impar = 0;


            while (numero >= 0)
            {


                Console.Write("\nDigite um número: \nLembrando que ao digitar um número negativo o programa é finalizado! \n");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero >= 0)
                {
                    if (numero % 2 == 0)
                    {
                        par = par + numero;
                    }
                    else
                    {
                        impar = impar + numero;
                    }
                }


            }
            Console.WriteLine("\n\nA quantidade de números pares é: " + par + " e a quantidade de números impares é: " + impar);
        }
    }
}

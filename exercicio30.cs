using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio30
    {
        static void Main30(string[] args)
        {
            int numero;
            Console.WriteLine("Programa para fazer a tabuada");
            Console.WriteLine("\n\nDigite um número para fazermos uma tabuada:");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");



            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("\n" + numero + " x " + i + " = " + (numero * i));
            }



        }
    }
}
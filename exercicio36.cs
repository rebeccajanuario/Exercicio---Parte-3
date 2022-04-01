using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio36
    {
        static void Main36(string[] args)
        {
            double media = 0;
            int numero = 0;
            int soma = 0;
            int maior = numero;
            int menor = 0;


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "° número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero < menor)
                {
                    numero = menor;
                }
                else if (numero > maior)
                {
                    maior = numero;
                }
                soma = soma + numero;
            }
            media = soma / 10;



            Console.WriteLine("\nO menor número é: " + menor);
            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("A média dos números é: " + media);




        }
    }
}

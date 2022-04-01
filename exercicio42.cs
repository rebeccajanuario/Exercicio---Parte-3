using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio42
    {
        static void Main42(string[] args)
        {
			int numero;
			int maior;
			int menor;

			Console.Write("Digite um número: ");
			numero = entrada.nextInt();
			menor = numero;
			maior = numero;

			do
			{
				Console.Write("Digite outro número: ");
				numero = entrada.nextInt();

				if (numero > maior)
				{
					maior = numero;
				}
				if (numero < menor && numero != 0)
				{
					menor = numero;
				}

			} while (numero != 0);

			Console.WriteLine("\nO menor número é " + menor + " e o maior número é " + maior + ".");
		}
    }
}

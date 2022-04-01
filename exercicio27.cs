using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nivel4
{
    class Exercicio27
    {
        static void Main27(string[] args)
        {
			int quantidade;
			Console.Write("Digite a qtde de números: ");
			quantidade = entrada.nextInt();

			long[] numeros = new long[quantidade];
			for (int x = 0; x < numeros.Length; x++)
			{
				Console.Write("Digite um número: ");
				numeros[x] = entrada.nextInt();
			}
			for (int x = 0; x < numeros.Length; x++)
			{
				long resultado = 1;
				for (long y = numeros[x]; y > 0; y--)
				{
					resultado = y * resultado;
				}
				Console.WriteLine("O fatorial de " + numeros[x] + " é: " + resultado);
			}


		}
	}
}

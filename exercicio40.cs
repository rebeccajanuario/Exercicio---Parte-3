using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
	class Exercicio40
	{
		static void Main40(string[] args)
		{
			double numero;
			bool parar = false;
			char letra;

			do
			{
				do
				{
					Console.Write("Digite o índice de poluição: ");
					numero = entrada.nextDouble();
					if (numero < 0)
					{
						Console.Write("Número inválido digite um número positivo.");
					}
				} while (numero < 0);

				Console.WriteLine();

				if (numero >= 0 && numero <= 0.25)
				{
					Console.WriteLine("Índice de poluição aceitável.");
				}


				if (numero >= 0.3)
				{
					Console.WriteLine("Suspender atividades das indústrias do 1° Grupo!");
				}

				if (numero >= 0.4)
				{
					Console.WriteLine("Suspender atividades das indústrias do 2° Grupo!");
				}

				if (numero >= 0.5)
				{
					Console.WriteLine("Suspender atividades das indústrias do 3° grupo!");
				}

				Console.WriteLine("\nDeseja encerrar o programa? (s/N) ");
				letra = entrada.next().charAt(0);
				if (letra == 's' || letra == 'S')
				{
					parar = true;
				}

			} while (parar == false);
		}
	}
}

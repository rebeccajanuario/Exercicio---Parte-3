using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio44
    {
        static void Main44(string[] args)
        {
			bool continuar = true;
			char letra;
			int opcao;

			do
			{
				do
				{
					Console.Write("Digite uma das opções:\n\t1 – Conversão de Graus Celsius em Graus Fahrenheit\n\t2 – Conversão de Graus Fahrenheit em Graus Celsius\n\t3 – Peso ideal do homem\n\t4 – Peso ideal da mulher\n\n");
					opcao = entrada.nextInt();
					if (opcao < 1 || opcao > 4)
					{
						Console.Write("Opção Errada.\n");
					}
				} while (opcao < 1 || opcao > 4);
				double Celsius, Fahrenheit;
				double Altura, PesoIdeal;
				switch (opcao)
				{
					case 1:
						Console.Write("Digite a temperatura em °C: ");
						Celsius = entrada.nextDouble();
						Fahrenheit = (Celsius * 1.8) + 32;
						Console.Write("A temperatura convertida é: " + Fahrenheit + "°F.\n");
						break;
					case 2:
						Console.Write("Digite a temperatura em °F: ");
						Fahrenheit = entrada.nextDouble();
						Celsius = (Fahrenheit - 32) / 1.8;
						Console.Write("A temperatura convertida é: " + Celsius + "°C.\n");
						break;
					case 3:
						Console.Write("Digite a altura: ");
						Altura = entrada.nextDouble();
						PesoIdeal = (72.7 * Altura) - 58;
						Console.Write("Seu peso ideal é: " + PesoIdeal + "kg");
						break;
					case 4:
						Console.Write("Digite a altura: ");
						Altura = entrada.nextDouble();
						PesoIdeal = (62.1 * Altura) - 44.7;
						Console.Write("Seu peso ideal é: " + PesoIdeal + "kg");
						break;
					default:
						Console.Write("Opção Errada.\n");
						break;
				}

				Console.WriteLine("\nDeseja encerrar o programa? (s/N) ");
				letra = entrada.next().charAt(0);
				if (letra == 's' || letra == 'S')
				{
					continuar = false;
				}
			} while (continuar);
		}
    }
}
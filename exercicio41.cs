using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio41
    {
        static void Main41(string[] args)
        {
			double idade;
			bool parar = false;
			char letra;
			string categoria;

			do
			{
				do
				{
					Console.Write("Digite a idade do nadador: ");
					idade = entrada.nextDouble();
					if (idade < 5)
					{
						Console.WriteLine("Idade inválida.");
					}
				} while (idade < 5);

				Console.WriteLine();

				if (idade >= 5 && idade < 8)
				{
					categoria = "Infantil A";
				}
				else if (idade >= 8 && idade < 12)
				{
					categoria = "Infantil B";
				}
				else if (idade >= 12 && idade < 14)
				{
					categoria = "Juvenil A";
				}
				else if (idade >= 14 && idade < 18)
				{
					categoria = "Juvenil B";
				}
				else
				{
					categoria = "Adultos";
				}


				Console.WriteLine("A categoria é: " + categoria);

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

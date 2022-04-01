using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio33
    {
        static void Main33(string[] args)
        {
            int quantAluno = 0;
            int matricula = 0;
            double mediaAlunos = 0;


            Console.Write("Digite um a quantidade de alunos: ");
            quantAluno = Convert.ToInt32(Console.ReadLine());


            for (int x = 0; x < quantAluno; x++)
            {
                Console.Write("\nDigite o número da matrícula do aluno: ");
                matricula = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a nota do aluno: ");
                double nota = Convert.ToInt16(Console.ReadLine());
                mediaAlunos += nota;
            }
            mediaAlunos = mediaAlunos / quantAluno;
            Console.WriteLine("\nA média da turma foi de " + mediaAlunos);
        }
    }
}

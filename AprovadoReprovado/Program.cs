using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovadoReprovado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a porcentagem de presença do aluno: ");
            double presenca = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a média do aluno: ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 7 && presenca >= 75)
            {
                Console.WriteLine("Aluno Aprovado!");
            }
            else if (nota >= 4 && presenca <= 75 || nota <= 7 && presenca >= 75)
            {
                Console.WriteLine("O Aluno está em recuperação");
            }
            else
            {
                Console.WriteLine("O aluno está retido");
            }
            Console.ReadKey();
        }
    }
}

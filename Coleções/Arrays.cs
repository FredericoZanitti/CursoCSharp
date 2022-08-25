using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Coleções
{
    class Arrays
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "João";
            alunos[1] = "Maria";
            alunos[2] = "Joaquim";
            alunos[3] = "José";
            alunos[4] = "Marcos";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0.0;
            double[] notas = { 9.7, 2.8, 5.5, 3.9, 9.9 };
            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            Console.WriteLine("Média das notas {0}", (somatorio/notas.Length));
        }
    }
}

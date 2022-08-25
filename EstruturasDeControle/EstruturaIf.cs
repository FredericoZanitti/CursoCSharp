using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui um bom comportamento? ");
            entrada = Console.ReadLine();

            bomComportamento = entrada.ToLower() == "s";


            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de Honra");
            }
        }
    }
}

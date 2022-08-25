using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Opa!";
            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            var time = new string[] { "Fabio", "Samuel Xavier", "Nino", "Manoel", "Caio Paulista", "Andre", "Martinelli", "Ganso", "Matheus Martins", "Arias", "Cano" };
            int posicao = 1;
            foreach (var jogadores in time)
            {             
                Console.WriteLine("{0} - {1}", posicao, jogadores);
                posicao++;
            }
        }
    }
}

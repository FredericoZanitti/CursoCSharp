using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class FilhoReconhecido : Subcelebridades
    {
        public new void MeusAcessos()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>> Filho Reconhecido...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
        }
    }
}

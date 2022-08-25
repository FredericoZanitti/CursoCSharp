using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;

namespace CursoCSharp.OO
{
    class Encapsulamento
    {
        public class FilhoNaoReconhecido : Subcelebridades
        {
            public new void MeusAcessos()
            {
                Console.WriteLine(">>>>>>>>>>>>>>>> Filho não reconhecido...");
                Console.WriteLine(InfoPublica);
                Console.WriteLine(CorOlhos);
                Console.WriteLine(JeitoDeFalar);
            }
        }

        public class AmigoDistante
        {
            public readonly Subcelebridades amiga = new Subcelebridades();

            public void MeusAcessos()
            {
                Console.WriteLine(">>>>>>>>>>>>>>>> Amiga distante...");
                Console.WriteLine(amiga.InfoPublica);
            }
        }
        
        public static void Executar()
        {
            Subcelebridades sub = new Subcelebridades();
            sub.MeusAcessos();
            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();
            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}

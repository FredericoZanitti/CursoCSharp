using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class AmigoProximo
    {
        // como não é herança, precisa instanciar a classe para poder usar algumas classes
        public readonly Subcelebridades amiga = new Subcelebridades();

        public void MeusAcessos()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>> Amiga próximo");
            Console.WriteLine(amiga.InfoPublica);
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
        }
        

    }
}

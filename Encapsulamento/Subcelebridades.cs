using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Subcelebridades
    {
        // Todos
        public string InfoPublica = "Tenho um Instagram";

        // Hernaça
        protected string CorOlhos = "Verde";

        // Mesmo projeto (assembly)
        internal ulong NumeroCelular = 5531999999999;

        // Herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        // Mesma classe ou herança ou no mesmo projeto (C# >= 7.2)
        private protected string SegredoDeFamilia = "Bla bla";

        // Private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>> Subcelebridade...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}

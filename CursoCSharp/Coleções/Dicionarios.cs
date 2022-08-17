using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Coleções
{
    class Dicionarios
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();
            filmes.Add(2002, "Homem Aranha 1");
            filmes.Add(2004, "Homem Aranha 2");
            filmes.Add(2005, "Homem Aranha 3");
            filmes.Add(2009, "Batman Vs Superman");

            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004: " + filmes[2004]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
            }
        }
    }
}

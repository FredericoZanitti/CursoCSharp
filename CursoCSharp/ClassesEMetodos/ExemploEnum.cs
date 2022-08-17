using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ExemploEnum
    {
        public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

        public class Filme
        {
            public string Titulo;
            public Genero GeneroDoFilme;
        }

        public static void Executar()
        {
            var filmeFamilia = new Filme();
            filmeFamilia.Titulo = "UP, altas aventuras!";
            filmeFamilia.GeneroDoFilme = Genero.Animacao;

            Console.WriteLine("O filme {0} é {1}", filmeFamilia.Titulo, filmeFamilia.GeneroDoFilme);
        }
    }
}

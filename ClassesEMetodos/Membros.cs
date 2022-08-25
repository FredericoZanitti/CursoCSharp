using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Frederico Zanitti";
            pessoa.Idade = 45;
            pessoa.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Joaquim Caetano";
            fulano.Idade = 18;
            fulano.ApresentarNoConsole();
        }
    }
}

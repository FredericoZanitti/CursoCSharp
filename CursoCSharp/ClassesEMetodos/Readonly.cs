using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Readonly
    {
        public class Cliente
        {
            public string Nome;
            readonly DateTime Nascimento;

            public Cliente (string nome, DateTime nascimento)
            {
                Nome = nome;
                Nascimento = nascimento;
            }

            public Cliente()
            {

            }

            public string GetDataNascimento()
            {
                return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
            }
        }

        public static void Executar()
        {
            var novoCliente = new Cliente("Frederico Zanitti", new DateTime(1976, 12, 19));
            Console.WriteLine(novoCliente.GetDataNascimento());
        }
    }
}

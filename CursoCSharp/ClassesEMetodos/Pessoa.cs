﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string? Nome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format("Olá, meu nome é {0} e eu tenho {1} anos.", Nome, Idade);
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
    }
}

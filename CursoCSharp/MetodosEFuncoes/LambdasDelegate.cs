using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    delegate double Operacao(double x, double y);

    class LambdasDelegate
    {
        public static void Executar()
        {
            Operacao soma = (x, y) => x + y;
            Operacao subt = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine(soma(3, 4));
            Console.WriteLine(subt(9, 4));
            Console.WriteLine(mult(10, 4));
        }
    }
}

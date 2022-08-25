using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        public static int Somar(this int num, int outroNumero)
        {
            return num + outroNumero;
        }

        public static int Subtrair(this int num, int outroNumero)
        {
            return num - outroNumero;
        }
    }
    
    class MetodosDeExtensao
    {
        public static void Executar()
        {
            int numero = 5;
            Console.WriteLine(numero.Somar(5));
            Console.WriteLine(numero.Subtrair(3));

            Console.WriteLine(38.Somar(2));
            Console.WriteLine(55.Subtrair(43));
        }
    }
}

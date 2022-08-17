using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComun
    {
        public int Somar (int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Subtrair(int a)
        {
            memoria -= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }
    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComun = new CalculadoraComun();
            var resultado = calculadoraComun.Somar(5, 6);
            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComun.Subtrair(5,2));
            Console.WriteLine(calculadoraComun.Multiplicar(8,2));
            Console.WriteLine("Calculadora cadeia");
            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(4).Multiplicar(10).Subtrair(11).Imprimir().Limpar().Imprimir();            
        }
    }
}

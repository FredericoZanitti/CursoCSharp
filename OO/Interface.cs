using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    class Interface
    {
        interface OperacoesBinarias
        {
            int Operacao(int a, int b);
        }

        class Somar : OperacoesBinarias
        {
            public int Operacao(int a, int b)
            {
                return a + b;
            }
        }

        class Subtrair : OperacoesBinarias
        {
            public int Operacao(int a, int b)
            {
                return a - b;
            }
        }

        class Multiplicar : OperacoesBinarias
        {
            public int Operacao(int a, int b)
            {
                return a * b;
            }
        }

        class Calculadora
        {
            List<OperacoesBinarias> operacoes = new List<OperacoesBinarias>
            {
                new Somar(),
                new Subtrair(),
                new Multiplicar()
            };

            public string ExecutarOperacoes(int a, int b)
            {
                string resultado = $"Valores passados no parâmetro: {a} e {b}\n";
                foreach (var op in operacoes)
                {
                    resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
                }
                return resultado;
            }
        }

        public static void Executar()
        {
            Calculadora calculadora = new Calculadora();
            Console.Write("Digite o primeiro valor: ");
            string numero1 = Console.ReadLine();
            int.TryParse(numero1, out int num1);
            Console.Write("Digite o segundo valor: "); 
            string numero2 = Console.ReadLine();
            Console.WriteLine("=================================================================");
            int.TryParse(numero2, out int num2);
            var resultado = calculadora.ExecutarOperacoes(num1, num2);
            Console.WriteLine(resultado);
        }
    }
}

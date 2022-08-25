using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    class PrimeiraExcecao
    {
        public class Conta
        {
            double Saldo;

            public Conta(double saldo)
            {
                Saldo = saldo;
            }

            public void Sacar(double valor)
            {
                if (valor > Saldo)
                {
                    throw new ArgumentException("Saldo Insuficiente!");
                }
            }
        }
        
        public static void Executar()
        {
            var conta = new Conta(1_245.33);
            try
            {
                Console.Write("Digite o valor a ser sacado: ");
                int valor = int.Parse(Console.ReadLine());
                conta.Sacar(valor);
                Console.WriteLine("Retirada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Obrigado!");
            }

        }
    }
}

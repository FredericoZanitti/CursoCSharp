using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto (string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto()
        {

        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }

        public override bool Equals(object obj)
        {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;  
            return mesmoNome && mesmoPreco;
        }
    }
    
    class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 100.0);
            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 100.0,
            };

            Produto.Desconto = 0.1;
            Console.WriteLine("Preço com desconto: R$ {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: R$ {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.05;
            Console.WriteLine("Preço com desconto: R$ {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: R$ {0}", produto2.CalcularDesconto());

        }
    }
}

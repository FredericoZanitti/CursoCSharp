using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Coleções
{
    class Listas
    {
        public class Produto
        {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }
        }
        
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>()
            {
                new Produto("Camisa polo", 39.9),
                new Produto("8ª Temporada Game of Thrones", 55.9),
                new Produto("Poster Winter is coming", 10)
            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
        }
    }
}

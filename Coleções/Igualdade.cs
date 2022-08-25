using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp.Coleções
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            
            //serão diferentes pois aqui está se comparando endereço de memória (referencia)
            Console.WriteLine(p1 == p2);
            
            var p3 = p2;

            //ainda assim serão diferentes, pois continua comaprando memória
            Console.WriteLine(p3 == p2);

            //agora serão iguais pois o método Equals foi sobrescrito para comparar nome e preço e 
            //retornar true caso esses atributos sejam de fatos iguais
            Console.WriteLine(p1.Equals(p2));

        }
    }
}

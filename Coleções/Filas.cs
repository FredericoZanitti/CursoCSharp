using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Coleções
{
    class Filas
    {
        public static void Executar()
        {
            var fila = new Queue<string>();
            //Enqueue = enfileirar
            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count());
            
            //desenfileirar
            fila.Dequeue();
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count());

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("Item"));
            foreach(var item in salada)
            {
                Console.WriteLine(item);
            }
        }
         
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    class Polimorfismo
    {
        public class Comida
        {
            public double Peso;

            public Comida(double peso)
            {
                Peso = peso;
            }   

            public Comida() { }
        }
        
        public class Feijao : Comida
        {

        }
        public class Arroz : Comida
        {

        }
        public class Carne : Comida
        {

        }

        public class Pessoa
        {
            public double Peso;

            public void Comer(Comida comida)
            {
                Peso += comida.Peso;
            }
        }

        public static void Executar()
        {
            Feijao ingrediente1 = new Feijao();
            ingrediente1.Peso = 0.3;
            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.25;
            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.4;

            Pessoa pessoa = new Pessoa();
            pessoa.Peso = 80.2;
            pessoa.Comer(ingrediente1);
            pessoa.Comer(ingrediente2);
            pessoa.Comer(ingrediente3);
            Console.WriteLine("Agora o peso do cliente é de {0}", pessoa.Peso);
        }
    }
}

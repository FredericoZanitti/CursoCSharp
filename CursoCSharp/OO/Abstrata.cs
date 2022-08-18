using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    class Abstrata
    {
        public abstract class Celular
        {
            public abstract string Assistente();

            public string Tocar()
            {
                return "Trim... trim... trim";
            }
        }

        public class Samsung : Celular
        {
            public override string Assistente()
            {
                return "Olá, sou o modelo S10";
            }
        }

        public class iPhone : Celular
        {
            public override string Assistente()
            {
                return "Olá, sou o modelo XR";
            }
        }

        public static void Executar()
        {
            var celulares = new List<Celular> {
                new Samsung(),
                new iPhone()
            };
            foreach(var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}

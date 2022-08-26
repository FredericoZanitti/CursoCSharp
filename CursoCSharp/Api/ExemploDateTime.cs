using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6);
            // data sem hora
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);
            
            //hoje mais hora atual
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine("AMANHÃ: " + amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine("ONTEM: " + ontem);

            //MOSTRAR HORA & MINUTO
            Console.WriteLine(diaAtual.ToString("g"));

            //MOSTRAR HORA & MINUTO & SEGUNDO
            Console.WriteLine(diaAtual.ToString("G"));

            Console.WriteLine(diaAtual.ToString("dddd, dd MMMM yyyy"));

        }
    }
}

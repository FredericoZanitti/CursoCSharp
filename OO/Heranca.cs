using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima = 160;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            velocidadeMaxima = VelocidadeMaxima;
        }

        public Carro() { }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;
            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else 
            { 
                VelocidadeAtual = novaVelocidade; 
            }

            return VelocidadeAtual;
        }

        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350) { }
        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }
    }

    class Heranca
    {
        public static void Executar()
        {
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
        }
    }
}

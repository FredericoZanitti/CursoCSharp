using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    public class Moto
    {
        private string Marca;
        private string Modelo;
        private int Cilindradas;

        public Moto(string marca, string modelo, int cilindradas)
        {
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindradas(cilindradas);
        }

        public Moto()
        {

        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public void SetCilindradas(int cilindradas)
        {
            if (cilindradas > 0)
                Cilindradas = cilindradas;
            else
                Cilindradas = 0;
        }

        public int GetCilindradas()
        {
            return Cilindradas; 
        }

        public void ApresentaDados()
        {
            Console.WriteLine("Moto {0}, modelo {1} e cilindradas {2}", Marca, Modelo, Cilindradas);
        }
    }

    class GettersESetters
    {
        public static void Executar()
        {
            var moto1 = new Moto();
            moto1.SetMarca("Honda");
            moto1.SetModelo("CBR-500");
            moto1.SetCilindradas(500);
            moto1.ApresentaDados();

        }
    }
}

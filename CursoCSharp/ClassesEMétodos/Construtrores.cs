using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMétodos
{

    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro()
        {

        }
    }
    class Construtrores
    {
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Modelo = "BMW";
            carro1.Fabricante = "325i";
            carro1.Ano = 2017;

            Console.WriteLine(carro1.Modelo, carro1.Fabricante, carro1.Ano);

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"{carro2.Modelo}, {carro2.Fabricante}, {carro2.Ano}");

            var carro3 = new Carro()
            {
                Modelo = "Uno",
                Fabricante = "Fiat",
                Ano = 2019

            };

            Console.WriteLine($"{carro3.Modelo}, {carro3.Fabricante}, {carro3.Ano}");






        }
    }
}

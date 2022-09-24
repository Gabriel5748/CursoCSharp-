using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Interpolação
    {
        public static void Executar()
        {

            string nome = "Notebook gamer";
            string marca = "Acer";
            double preco = 5800.00;

            Console.WriteLine("O notebook" + " da marca " + marca + " é de " + preco + " reais");
            Console.WriteLine("O nome{0} da marca {1} custa {2}", nome, marca, preco);
            Console.WriteLine($"A marca {marca} é legal");
            Console.WriteLine($"1 + 1 = {1 + 1}!");

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {

            var preco = 1000;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalcomdesconto = total * (1 - desconto);

            Console.WriteLine("O preço final é de:{0} reais", totalcomdesconto);

            //IMC

            double peso = 91.2;
            double altura = 1.82;

            //Potência , altura ao quadrado

            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {imc}");

            //Número par e ímpar

            int par = 24;
            int impar = 15;

            Console.WriteLine($"{par}/2 tem resto { par % 2}");
            Console.WriteLine($"{impar}/2 tem resto { impar % 2}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMétodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        class MetodoComRetorno
        {
            public static void Executar()
            {
                var calculadoracomum = new CalculadoraComum();
                var resultado = calculadoracomum.Somar(5, 5);

                Console.WriteLine(resultado);
                Console.WriteLine(calculadoracomum.Subtrair(10, 8));
                Console.WriteLine(calculadoracomum.Multiplicar(5, 8));


            }
        }
    }
}

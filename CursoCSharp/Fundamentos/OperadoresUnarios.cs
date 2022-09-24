using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
     class OperadoresUnarios
    {
        public static void Executar()
        {
            var valornegativo = -5;
            var num1 = 2;
            var num2 = 3;
            var booleano = true;

            Console.WriteLine(-valornegativo);
            Console.WriteLine(!booleano);

            //prefixado tem preferência
            Console.WriteLine(num1++ == --num2);
        }
    }
}

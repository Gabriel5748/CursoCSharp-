using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
     class Operadoreslogicos
    {  
        public static void Executar()
        {
            var executoutrabalho1 = true;
            var executoutrabalho2 = false;

            var comproutv50 = executoutrabalho1 && executoutrabalho2;

            var comprousorvete = executoutrabalho1 || executoutrabalho2;

            var comproutv32 = executoutrabalho1 ^ executoutrabalho2;

            Console.WriteLine($"Comrpou tv de 50 ? {comproutv50}");
            Console.WriteLine($"Comrpou o sorvete ? {comprousorvete}");
            Console.WriteLine($"Comrpou tv de 32 ? {comproutv32}");

        }
    }
}

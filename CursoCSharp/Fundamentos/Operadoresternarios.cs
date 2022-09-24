using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
     class Operadoresternarios
    {
        public static void Executar()
        {
            var nota = 7;
            bool bomcorpomento = true;
            string resultado = nota >= 7 && bomcorpomento ? "Aprovado" : "Reprovado";

            Console.WriteLine(resultado);

        }
    }
}

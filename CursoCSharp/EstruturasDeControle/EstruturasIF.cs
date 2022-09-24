using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
     class EstruturasIF
    {
        public static void Executar()
        {
            bool bomcomportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno:");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento ? (S/N)");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //bomcomportamento = true;

            bomcomportamento = entrada == "S" || entrada == "s";
            bomcomportamento = entrada.ToLower() == "s";

            if (nota >= 9 && bomcomportamento) 
                Console.WriteLine("Quadro de honra!");

        }
    }
}

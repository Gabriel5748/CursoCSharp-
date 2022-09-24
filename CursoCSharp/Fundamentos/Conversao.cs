using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
     class Conversao
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;

            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notatruncada = (int) nota;

            Console.WriteLine("Nota truncada:{0}", notatruncada);

            Console.WriteLine("Digite sua idade:");
            string idadestring = Console.ReadLine();
            int idadeinteiro = int.Parse(idadestring);

            Console.WriteLine("Idade insserida:{0}", idadeinteiro);

            idadeinteiro = Convert.ToInt32(idadestring);

            Console.WriteLine(idadeinteiro);

            Console.Write("Digite o primeiro número:");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado:{0}", numero1);
            
            
            Console.Write("Digite o segundo número:");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado2:{0}", numero2);



        }
    }
}


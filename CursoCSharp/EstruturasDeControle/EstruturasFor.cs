using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
     class EstruturasFor
    {
        public static void Executar() {

            //for(int i = 0; i <= 10; i++)
            //{
            //Console.Writeline("O valor de i é de {0}",i);
            //}

            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma:");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoturma);

            for (int i = 1;i<= tamanhoturma; i++)
            {
                Console.WriteLine("Informe a nota do aluno {0}", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaatual);

                somatorio += notaatual;


            }

            double media = tamanhoturma > 0 ? somatorio / tamanhoturma : 0;
            Console.WriteLine("Média da turma é de {0}", media);

            }
        
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Var_e_Consts
    {
        public static void Executar()
        {
            //Double é o tipo da variável
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 35;

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("A área é " + area + " metros quadrados");

            //Tipos internos

            bool estachovendo = true;
            Console.WriteLine("Está chovendo ?" + estachovendo);

            //Só aceita valores positivos
            byte idade = 45;
            Console.WriteLine("idade:" + idade);

            //Byte com negativo
            sbyte prejuizo = -128;
            Console.WriteLine("Prejuízo:" + prejuizo);

            short salario = short.MaxValue;
            Console.WriteLine("Salário" + salario);

            //Para valores numéricos , mais usado para os inteiros
            int menorvalorint = int.MinValue;
            Console.WriteLine("Menor int" + menorvalorint);

            //Inteiro sem sinal
            uint populacao = 207_600_000;
            Console.WriteLine("População" + populacao);

            long menorvalorlong = long.MinValue;
            Console.WriteLine("Menor long" + menorvalorlong);

            //long sem sinal
            ulong populacaomundial = 7_000_000_000;
            Console.WriteLine("Menor long" + populacaomundial);

            float preco = 215.50f;
            Console.WriteLine("Preço do produto" + preco);

            //Mais usados dos números reais
            double valor = 12282389.89;
            Console.WriteLine("Valor do produto" + valor);

            //Valores enormes
            decimal distanciaentreplanetas = decimal.MaxValue;
            Console.WriteLine("Distância" + distanciaentreplanetas);

            //Armazenar letra
            char letra = 'b';
            Console.WriteLine("Letra" + letra);

            //Armazenar texto
            string texto = "Bem vindo ao curso de C#";
            Console.WriteLine(texto);

               }
    }
}

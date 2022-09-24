using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturasWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numerosecreto = random.Next(1, 16);
            bool numeroencontrado = false;
            int tentativasrestantes = 5;
            int tentativas = 0;

            while (tentativasrestantes > 0 && !numeroencontrado)
            {
                Console.WriteLine("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasrestantes--;

                if (numerosecreto == palpite)
                {
                    numeroencontrado = true;
                    var coranterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Número encontrado em {tentativas} tentativas");
                    Console.BackgroundColor = coranterior;
                }

                else if (palpite > numerosecreto)
                {
                    Console.WriteLine("Menor....Tente novamente!");
                    Console.WriteLine($"Tentativas restantes:{tentativasrestantes}");
                }


                }
            }
        }
    }

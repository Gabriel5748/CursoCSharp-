using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMétodos
{
     class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            Console.WriteLine($"{sicrano.Nome} têm {sicrano.Idade} anos");

            sicrano.ApresentarConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var fulanoapresentacao = fulano.Apresentar();
            Console.WriteLine(fulanoapresentacao);

        }
    }
}

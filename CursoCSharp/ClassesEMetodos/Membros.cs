using System;

namespace CursoCSharp.ClassesEMetodos //mesmo namespace que pessoa
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa(); //inferencia, o tipo vira de pessoa
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var apresentacaoDoFulano = fulano.Apresentar();

            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}

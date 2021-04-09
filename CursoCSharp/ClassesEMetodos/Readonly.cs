using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class Cliente {
        public string Nome;
        readonly DateTime Nascimento; //diferente do const que PRECISA receber o valor no código para que nao mude mais, no readonly ela pode receber o valor no tempo de execução e depois ai sim nao muda mais
        const int x = 1; //assim é a inicialização de um const

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }

    class Readonly {
        public static void Executar() { //static nao é necessario criar um objeto para executar
            var novoCliente = new Cliente("Ana Silvar", new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}

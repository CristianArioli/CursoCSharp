using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public class Animal {
        public string Nome { get; set; }

        public Animal(string nome) {
            Nome = nome;
        }
    }

    public class Cachorro : Animal {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome) { //o base chama o construtor base da classe pai
            Console.WriteLine($"Cachorro {nome} inicializado");
        } 

        public Cachorro(string nome, double altura) : this(nome) { //o this chama o construtor da classe, no caso a gente nao seta o nome do cachorro pq ele chama o construtor de cima e o decima chama o base da classe animal
            Altura = altura;
        }

        public override string ToString() {
            return $"{Nome} tem {Altura}cm de altura!";
        }
    }

    class ConstrutorThis {
        public static void Executar() {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40.0);

            Console.WriteLine(spike);
            Console.WriteLine(max.ToString());

            //o objeto precisa ser transformado em uma string e então automaticamente ele chama o ToString()
        }
    }
}

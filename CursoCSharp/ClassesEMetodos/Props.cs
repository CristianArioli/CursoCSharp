using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class CarroOpcional {
        double desconto = 0.1;

        //dessa primeira forma é como se declarasse a variavel e so depois fizesse as props do get e set

        string nome;
        public string Nome {
            get {
                return "Opcional: " + nome;
            }
            set {
                nome = value;
            }
        }

        //Propriedade autoimplementada, ou seja, declaração e props 
        public double Preco { get; set; }

        //Somente leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco); //Lambda
            //get {
            //    return Preco - (desconto * Preco);
            //}
        }

        public CarroOpcional() {

        }

        public CarroOpcional(string nome, double preco) {
            this.nome = nome;
            Preco = preco;
        }
    }
    class Props {
        public static void Executar() {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.PrecoComDesconto); //ele ja entende q é o get e assim o chama

            //op1.PrecoComDesconto = 3000; //só tem o get nessa props do precocomdesconto

            var op2 = new CarroOpcional();

            op2.Nome = "Direção Elétrica";
            op2.Preco = 2000;

            Console.WriteLine(op1.Nome);
        }
    }
}

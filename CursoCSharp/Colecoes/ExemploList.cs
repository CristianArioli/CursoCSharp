using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    
    //ctrl + . quando clicado em cima do nome da classe e então gerar...
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj) {
            //como isso é um método do objeto, ele é chamado e portanto tem os valores da propria classe para serem comparados ao que esta sendo passado por parametro(obj)
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        //o gethashcode vem antes do equals para filtrar a busca/comparação e agilizar a mesma
        //quanto mais items com o mesmo hashcode, mais lenta sera a pesquisa
        //dessa forma o set não tera dois elementos iguais, pois o hash foi implementado
        public override int GetHashCode() {
            return HashCode.Combine(Nome, Preco);
        }
    }
    class ExemploList {
        public static void Executar() {
            var livro = new Produto("Game of thrones", 49.9);

            var carrinho = new List<Produto>(); // lista de tipo produto

            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8 temporada game of thrones", 99.9),
                new Produto("Poster",10),
            };

            carrinho.AddRange(combo); //varios elementos de uma so vez

            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
                Console.Write(carrinho.IndexOf(item)); //index do item iterado em relação ao carrinho
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            //list aceita repetição de elementos
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro)); //ultimo indice de livro dentro da lista do carrinho
        }
    }
}

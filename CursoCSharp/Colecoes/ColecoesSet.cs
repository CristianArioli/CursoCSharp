using System;
using System.Collections.Generic;
using System.Text;

//O hashset nao é indexavel assim como o list
//Set nao aceita repetição como o list

namespace CursoCSharp.Colecoes {

    class ColecoesSet {
        public static void Executar() {
            var livro = new Produto("Game of thrones", 49.9);

            var carrinho = new HashSet<Produto>(); // lista de tipo produto

            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8 temporada game of thrones", 99.9),
                new Produto("Poster",10),
            };

            carrinho.UnionWith(combo); // é a uniao com os elementos anteriores + o novo conjunto

            Console.WriteLine(carrinho.Count);

            foreach (var item in carrinho) {
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            //list aceita repetição de elementos
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
        }
    }
}

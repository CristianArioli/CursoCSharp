using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

// Queue é uma estrutura dinamica, aumentando conforme a necessida
// Queue aceita repetição de elementos

namespace CursoCSharp.Colecoes {
    class ColecoesQueue {
        public static void Executar() {
            var fila = new Queue<string>(); //todos elementos da fila são strings

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek()); //pega o primeiro da fila, mas não exclui da fila
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue()); //remove o primeiro da fila
            Console.WriteLine(fila.Count);


            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue(); //esse queue precisa do collections e não do generics... essa no caso pode ter varios tipos de variaveis
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}

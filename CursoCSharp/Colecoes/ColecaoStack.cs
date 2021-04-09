using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecaoStack {
        public static void Executar() {
            var pilha = new Stack();

            pilha.Push(3); //push adicionada a pilha
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha) {
                Console.Write($"{item}");
            }

            Console.WriteLine($"\nPop:{pilha.Pop()}"); //pop pega e depois remove da pilha

            foreach(var item in pilha) {
                Console.Write($"{item}");
            }

            Console.WriteLine($"\nPeek:{pilha.Peek()}"); //peek só pega, mas não remove da pilha
            Console.WriteLine(pilha.Count);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

//os códigos do equals e do gethashcode estão dentro de ExemploList.cs

namespace CursoCSharp.Colecoes {
    class Igualdade {
        public static void Executar() {
            var p1 = new Produto("A", 1);
            var p2 = new Produto("A", 1);
            var p3 = p2;

            //com numeros comuns e strings a comparação funciona provavelmente pois são estruturas simples já nativas e não um object

            Console.WriteLine(p1 == p2); //não são iguais, ambas apontam pra lugares diferentes de memória
            Console.WriteLine(p2 == p3); //agora é igual, pois ambas apontam para os mesmos endereços de memória

            Console.WriteLine(p1.Equals(p2)); //com equals normal não é verdadeiro pois o equals faz o mesmo q o ==, compara endereços de memória
            //mas dando um override no equals voce pode trocar o que vai ser comparado, neste caso o nome e o preco ao inves do endereço de memória
        }
    }
}

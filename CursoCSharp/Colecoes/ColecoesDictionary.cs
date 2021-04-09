using System;
using System.Collections.Generic;
using System.Text;

//dictionary aceita repetição no valor, mas não na chave

namespace CursoCSharp.Colecoes {
    class ColecoesDictionary {
        public static void Executar() {
            var filmes = new Dictionary<int, string>(); //dictionary é um conjunto de chave e valor

            filmes.Add(200, "Gladiador");
            filmes.Add(2002, "Gladiador");
            filmes.Add(2004, "Gladiador");
            filmes.Add(2006, "Gladiador");

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004" + filmes[2004]);
                Console.WriteLine("2004" + filmes.GetValueOrDefault(2009)); //traz o valor ou traz null
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia"));
            Console.WriteLine(filmes.Remove(2004)); //retorna true ou false pra remoção

            filmes.TryGetValue(2006, out string filme2006); //joga o valor da chave 2006 na variavel filme2006 pelo out, se nao existir nao gera problema, mas sim um false
            Console.WriteLine(filme2006);

            foreach (var chave in filmes.Keys) {
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes.Values) {
                Console.WriteLine(valor);
            }

            foreach ( KeyValuePair<int,string> filme in filmes) { //aqui é explicito com o keyvalue
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

            foreach (var filme in filmes) { //aqui o proprio compilador interpreta q é necessario o código acima, fica mais facil
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

        }
    }
}

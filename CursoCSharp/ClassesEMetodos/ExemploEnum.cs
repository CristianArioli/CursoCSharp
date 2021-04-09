using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme; //de tipo genero, relacionado a classe enum criada acima

    }

    class ExemploEnum {
        public static void Executar() {
            int id = (int)Genero.Animacao; //com o cast vc tem acesso ao indice do valor da variavel relacionado a classe genero criada la em cima
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknado 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia; //so pode ser atribuido valores fechado declarados na classe enum

            Console.WriteLine("{0} é {1}!", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class DesafioAtributo {
        int a = 10;

        public static void Executar() { //o metodo quando static pertence a classe, de tal forma ele nao consegue acessar um atributo de instancia (a)
            var desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }
    }
}

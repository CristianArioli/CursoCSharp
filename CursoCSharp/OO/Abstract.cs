using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    //abstract nao pode instanciar
    // é usada geralmente pra conceitos abstratos, como celular
    //classe inacabada, quem herdar precisa implementar
    //uma classe abstrata pode herdar outra, mas sempre uma classe concreta precisa herdar e implementar

    public abstract class Celular {
        //metodo abstrato
        public abstract string Assistente();

        //metodo concreto
        public string Tocar() {
            return "Trim trim trim...";
        }
    }

    public class Samsung : Celular {
        public override string Assistente() {
            return "Olá! Meu nome é Bixby!";
        }
    }

    public class Iphone : Celular {
        public override string Assistente() {
            return "Olá! Meu nome é Siri!";
        }
    }

    class Abstract {

        //já que vai chamar só um método, pode só chamar o new
        public static void Executar() {
            var celulares = new List<Celular> {
                new Iphone(),
                new Samsung()
            };

            foreach (var celular in celulares) {
                Console.WriteLine(celular.Assistente());
            };
        }
    }
}

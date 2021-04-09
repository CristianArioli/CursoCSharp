using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosNomeados {
        public static void Formatar(int dia, int mes, int ano) {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano); //D2 adiciona zeros a esquerda, ate terminar o numero de casa especificado, no caso 2
        }
        public static void Executar() {
            Formatar(mes: 1, dia: 6, ano: 1996);
        }
    }
}

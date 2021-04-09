using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {

    public static class ExtensoesInteiro {

        //com o this você deixa claro qual é o tipo que você quer extender no primeiro parametro da função
        public static int Soma(this int num, int outroNumero) {
            return num + outroNumero;
        }

        public static double Subtracao(this double num, double outroNumero) {
            return num - outroNumero;
        }
    }

    class MetodosDeExtensao {
        public static void Executar() {
            //essas variaveis se tornam quase que um objeto com uma função usando dessa forma

            int numero = 5;
            double numeroReal = 2.5;

            Console.Write(numero.Soma(3));
            Console.Write(numeroReal.Subtracao(10));

            Console.WriteLine(2.Soma(3));
            Console.WriteLine(2.9.Subtracao(4));
        }
    }
}

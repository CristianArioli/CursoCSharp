using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class DelegatesComoParametros {

        public delegate int Operacao(int x, int y);

        public static int Soma(int x, int y) {
            return x + y;
        }

        //dessa forma vc torna obrigatório que a função passada tenha a mesma assinatura de Operacao
        public static string Calculadora(Operacao op, int x, int y) {
            var resultado = op(x, y);
            return "Resultado: " + resultado;
        }

        public static void Executar() {
            Operacao Subtracao = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(Subtracao, 3, 2));
            Console.WriteLine(Calculadora(Soma, 3, 2));
        }
    }
}

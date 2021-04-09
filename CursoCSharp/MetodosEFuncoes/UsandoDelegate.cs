using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {

    //pode se atribuir uma função que tenha o mesmo tipo de assinatura(parametros, retornos e etc) para uma variavel do tipo delegate

    class UsandoDelegate {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double a, double b) {
            return a + b;
        }

        static void MeuImprimirSoma(double a, double b) {
            Console.WriteLine(a + b);
        }

        public static void Executar() {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 3.9));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(5.4, 8);

            // com o func acontece o mesmo do delegate, precisa das mesma assinatura

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2, 3));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(7.7, 23.4);
        }
    }
}

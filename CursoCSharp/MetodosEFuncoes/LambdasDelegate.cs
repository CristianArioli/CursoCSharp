using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {

    //delegate é como uma assinatura do método... no caso ele demonstra quais serão os tipos dos parametros e o retorno pra quem utilizar uma variavel a partide sse tipo Operacao
    //bem utilizado para reuso de código
    //pode ser criado dentro ou fora da classe

    delegate double Operacao(double x, double y);

    class LambdasDelegate {
        public static void Executar() {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao multi = (x, y) => x * y;

            Console.WriteLine(sum(2, 3));
            Console.WriteLine(sub(2, 3));
            Console.WriteLine(multi(2, 3));
        }
    }
}

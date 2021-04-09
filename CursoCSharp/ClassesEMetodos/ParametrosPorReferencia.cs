using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosPorReferencia {
        public static void AlterarRef(ref int numero) { //com o ref se tem uma referencia da variavel passada, sendo assim se o valor for mudado dentro da função ele é mudado na variavel passada tbm
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero) { //com  out vc recebe como parametro uma variavel que não tem valor, que é usada dentro do método e então é "cuspida" pra fora ai sim com um valor
            numero = 0;
            numero = numero + 15;
        }

        public static void Executar() {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            //int b;
            AlterarOut(out int b); //é simplesmente uma saída
            Console.WriteLine(b);
        }
    }
}

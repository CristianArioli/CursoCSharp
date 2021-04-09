using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {

    //Lambda é uma função anonima
    //action é uma  função sem retorno, retorna void
    //func retorna alguma coisa
    class ExemploLambda {
        public static void Executar() {
            Action algoNoConsole = () => {
                Console.WriteLine("Lambda com c#!");
            };

            Action<string> algoNoConsole2 = (a) => {
                Console.WriteLine("Lambda com c#!" + a);
            };

            algoNoConsole();
            algoNoConsole2("!!!!");

            Func<int> jogarDado = () => {
                Random random = new Random(); //cria um objeto random
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            //o ToString("X") retorna um hexadecimal, por causa do X
            Func<int, string> conversorHex = numero => numero.ToString("X"); //int é o parametro e string é o retorno... o ultimo parametro no func é sempre o retorno e o restante são os parametros

            Console.WriteLine(conversorHex(23213));

            Func<int, int, int, string> formatarData = (dia, mes, ano) => String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano); //formatarData é do tipo func q recebe 3 parametros e retorna uma string

            Console.WriteLine(formatarData(1,2,2019));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class DelegateFuncAnonima {

        delegate string StringOperacao(string a);

        //está atribuindo um delegate anonimo par uma variavel de tipo delegate

        public static void Executar() {
            StringOperacao inverter = delegate (string s) {
                char[] charArray = s.ToCharArray(); // passa a string em char para o array 
                Array.Reverse(charArray); //com o metodo do array, inverte as posições do array
                return new string(charArray);
            };

            Console.WriteLine(inverter("C# é show!!"));
        }
    }
}

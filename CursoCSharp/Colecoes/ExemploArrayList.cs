using System;
using System.Collections;
using System.Text;

//arraylist nao esta dentro de generics, mas sim de collections

namespace CursoCSharp.Colecoes {
    class ExemploArrayList {
        public static void Executar() {
            var arraylist = new ArrayList {
                "Palavra",
                3,
                true
            };

            arraylist.Add(3.14);
            //arraylist.Count;

            foreach ( var item in arraylist) {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}

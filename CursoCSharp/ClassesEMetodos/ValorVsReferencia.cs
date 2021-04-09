using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public struct dependente {
        public string Nome; //string é uma classe, passagem por referencia
        public int Idade; //int é uma struct, passagem por valor
    }
    class ValorVsReferencia {
        public static void Executar() {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            string texto = "oi";
            string copiatexto = texto;

            copiatexto = "teste";

            Console.WriteLine($"{texto} {copiatexto}");


            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            dependente dep = new dependente {
                Nome = "Beto",
                Idade = 20,
            };

            dependente copiaDep = dep;
            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            dep.Idade = 21;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");


        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class CalculadoraEstatica {

        public static int Somar(int a, int b) { //com o static pode ser acessado diretamente pela classe, vide exemplo classe metodosestaticos
            return a + b;
        }

        public int Multiplicar(int a, int b) { //sem o static so pode ser acessado por uma instancia(objeto) da classe
            return a * b;
        }
    }

    class MetodosEstaticos {

        public static void Executar() {
            var calculadora = new CalculadoraEstatica();
            var resultado = calculadora.Multiplicar(2, 2);
            Console.WriteLine(resultado);
            Console.WriteLine(CalculadoraEstatica.Somar(2,2));
        }
    }
}

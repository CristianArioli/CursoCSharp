using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }

        public int Somar(int c, int d, int e) {
            return c + d;
        }
    }

    class CalculadoraCadeia {
        int memoria;
        
        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }
    }

    class MetodosComRetorno {
        public static void Executar() {
            var CalculadoraCadeia = new CalculadoraCadeia();

            CalculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

            int resultado;

            resultado = CalculadoraCadeia.Somar(3).Multiplicar(3).Resultado();
            Console.WriteLine(resultado);
        }
    }
}

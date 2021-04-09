using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes {

    public class Conta {
        double Saldo;

        public Conta(double saldo) {
            Saldo = saldo;
        }

        public void Sacar(double valor) {
            if(valor > Saldo) {
                //para de forma abrupta o método e retorna ao método que chamou
                //precisa do throw pra jogar a exception pro catch
                throw new ArgumentException("Saldo insuficiente");
            }

            Saldo -= valor;
        }
    }

    class PrimeiraExcecao {
        public static void Executar() {
            var conta = new Conta(1_223.45);

            try {
                conta.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!");
            } catch (ArgumentException ex) { //pode ser Execption, mas vc pode especificar o tipo de exception com o ArgumentException
                Console.WriteLine(ex.Message); //Message já é padrao das Exceptions
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.GetType().Name);
            } finally {
                //finally sempre vai ser executado
                Console.WriteLine("Obrigado!");
            }
        }
    }
}

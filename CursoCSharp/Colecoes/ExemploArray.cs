using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ExemploArray {
        public static void Executar() {
            string[] alunos = new string[5]; //um array de strings de 5 posições.. sempre tera 5 posições, não cresce dinamicamente
            alunos[0] = "Anderson";
            alunos[1] = "Anderson";
            alunos[2] = "Anderson";
            alunos[3] = "Anderson";
            alunos[4] = "Anderson";

            foreach(var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach(var nota in notas) {
                somatorio += nota;
            }

            //for(int i = 0; i < notas.Length; i++) {
            //    somatorio += notas[i];
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras); //varre o array de chars e joga para uma variavel string
            Console.WriteLine(palavra);
        }
    }
}

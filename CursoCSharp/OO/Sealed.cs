using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    //sealed nao permite herança

    sealed class SemFilho {
        public double ValorDaFortuna() {
            return 1_406_033.65;
        }
    }

    //exemplo de herança onde o avo permite a sobrescreita, mas o pai nao, tornando impossivel com o que o filho sobescreva o método honrarnomefamilia

    class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;
        }
    }

    class Pai : Avo {
        //o sealed faz que seja impossível sobreescrever o método
        public sealed override bool HonrarNomeFamilia() {
            return true;
        }
    }

    class FilhoRebelde : Pai {
        //Ocultando com o new é permitido sobreescrever, mas não com o override
        //public new bool HonrarNomeFamilia() {
        //    return false;
        //}
    }

    class Sealed {
        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}

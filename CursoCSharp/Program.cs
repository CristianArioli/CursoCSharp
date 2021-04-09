using System;
using System.Collections.Generic;

using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;

namespace CursoCSharp {
    class Program {
       public static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Classes e Métodos
                {"Membros - Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Metodos com Retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Metodos Estáticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributos Estáticos - Classes e Metodos", DesafioAtributo.Executar},
                {"Params - Classes e Metodos", Params.Executar},
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},
                {"Get e Set - Classes e Metodos", GetSet.Executar},
                {"Props - Classes e Metodos", Props.Executar},
                {"ReadOnly - Classes e Metodos", Readonly.Executar},
                {"Enum - Classes e Metodos", ExemploEnum.Executar},
                {"Struct - Classes e Metodos", Struct.Executar},
                {"Struct Vs Classe - Classes e Metodos", StructVsClasse.Executar},
                {"Valor vs Referencia - Classes e Metodos", ValorVsReferencia.Executar},
                {"Parametros por Referencia - Classes e Metodos", ParametrosPorReferencia.Executar},
                {"Parametros com valor Padrão - Classes e Metodos", ParametrosPadrao.Executar},

                //Coleções
                {"Arrays - Coleções", ExemploArray.Executar},
                {"Lists - Coleções", ExemploList.Executar},
                {"Exemplo Array List - Coleções", ExemploArrayList.Executar},
                {"Exemplo Set - Coleções", ColecoesSet.Executar},
                {"Exemplo Queue - Coleções", ColecoesQueue.Executar},
                {"Exemplo Igualdade - Coleções", Igualdade.Executar},
                {"Exemplo Stack - Coleções", ColecaoStack.Executar},
                {"Exemplo Dictionary - Coleções", ColecoesDictionary.Executar},

                //OO
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                //Metodos e Funções
                { "Exemplo Lambda - Metodos E Funções", ExemploLambda.Executar},
                { "Lambdas Delegate - Metodos E Funções", LambdasDelegate.Executar},
                { "Usando Delegate - Metodos E Funções", UsandoDelegate.Executar},
                { "Delegates com funções Anonimas - Metodos E Funções", DelegateFuncAnonima.Executar},
                { "Delegates como Parametros - Metodos E Funções", DelegatesComoParametros.Executar},
                { "Metodos De Extensao - Metodos E Funções", MetodosDeExtensao.Executar},

                //Exececoes
                { "Primeira Excecao - Metodos E Funções", PrimeiraExcecao.Executar},
                { "Excecções Customizadas - Metodos E Funções", ExcecoesCustomizadas.Executar},

                //Api
                { "Primeiro Arquivo - Usando Api", PrimeiroArquivo.Executar},
                { "Lendo Arquivo - Usando Api", LendoArquivos.Executar},
                { "Exemplo File Info- Usando Api", ExemploFileInfo.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
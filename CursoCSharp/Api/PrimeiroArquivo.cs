using System;
using System.IO;

namespace CursoCSharp.Api {

    public static class ExtensaoString {
        public static string ParseHome(this string path) {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix) || (Environment.OSVersion.Platform == PlatformID.MacOSX) ? Environment.GetEnvironmentVariable("HOME") : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }

    class PrimeiroArquivo {
        public static void Executar() {
            //arroba é para não interpretar com tab as /
            //~ = pasta home
            //como o parametro é uma string, tendo a string mesmo que literal voce consegue chamar a função de extensão
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path)) {
                //using usa e fecha todos os recursos usados durante esse bloco de código, isso por causa da interface que esta sendo aplicada no StreamWriter por exemplo: IDISPOSABLE
                //using: uma vez que o stream foi criado, ele vai ser liberado/desalocado de forma automatica, sem precisa chamar o método dispose
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }
            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!");
            }
        }
    }
}

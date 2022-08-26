using System;
using System.IO;

namespace CursoCSharp.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home); 
        }
    }

    class PrimeiroArquivo
    {
        public static void Executar()
        {
            // para não gerar problemas com os paths devemos colocar um @ antes da string para que o C# não interprete os caracteres especiais
            // '\n' quebra delinha
            // '\t' tab
            // etc

            var path = @"~/primeiro_arquivo.txt".ParseHome();
            
            if (!File.Exists(path))
            {
                // criar um arquivo
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }

            //abrir e inserir mais texto no arquivo
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("");
                    sw.WriteLine("é possível");
                    sw.WriteLine("adicionar");
                    sw.WriteLine("mais texto!");
                }
            }
        }
    }
}

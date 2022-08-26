using System;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dirProejto = @"~/source/repos/CursoCSharp/CursoCSharp".ParseHome();
            var dirInfo = new DirectoryInfo(dirProejto);
            
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            Console.WriteLine("==== ARQUIVOS =============================");
            var arquivos = dirInfo.GetFiles();
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);    
            }

            Console.WriteLine("\n\n==== DIRETORIOS =============================");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n==== INFORMAÇÕES =============================");
            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);
            Console.WriteLine(dirInfo.Parent.Parent);
        }
    }
}

using System;
using Projeto_02.Model;

namespace Projeto_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var arquivo = new Documento();
            var arquivo = new Xml();

            arquivo.AbrirArquivo();
            arquivo.GravarConteudo("Testando se irá gravar");
            arquivo.FecharArquivo();

            Console.WriteLine("Dados gravados com Sucesso!");
            Console.ReadKey();
        }
    }
}

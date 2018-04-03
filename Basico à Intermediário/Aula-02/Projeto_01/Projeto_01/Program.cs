using System;
using Projeto_01.Input;
using Projeto_01.Model;
using Projeto_01.Persistence;

namespace Projeto_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            var produto = new Produto();

            var leituraProduto = new LeituraProduto();

            produto.Codigo = leituraProduto.LerCodigo();
            produto.Nome = leituraProduto.LerNomeProduto();
            produto.Preco = leituraProduto.LerPrecoProduto();

            Console.WriteLine("\nDados do Produto");
            Console.WriteLine("Código..............: " + produto.Codigo);
            Console.WriteLine("Nome................: " + produto.Nome);
            Console.WriteLine("Preço...............: " + produto.Preco);

            var arquivo = new Arquivo();
            arquivo.GravarExcel(produto);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_01.Input;
using Projeto_01.Model;

namespace Projeto_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            var p = new Produto();

            var lp = new LeituraProduto();

            p.Codigo = lp.LerCodigo();
            p.Nome = lp.LerNomeProduto();
            p.Preco = lp.LerPrecoProduto();

            Console.WriteLine("\nDados do Produto");
            Console.WriteLine("Código..............: " + p.Codigo);
            Console.WriteLine("Nome................: " + p.Nome);
            Console.WriteLine("Preço...............: " + p.Preco);

            Console.ReadLine();
        }
    }
}

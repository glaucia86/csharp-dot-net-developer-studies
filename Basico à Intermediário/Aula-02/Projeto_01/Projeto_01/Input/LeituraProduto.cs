using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_01.Input
{
    public class LeituraProduto
    {
        public int LerCodigo()
        {
            Console.WriteLine("Informe o Código do Produto: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            return codigo;
        }

        public string LerNomeProduto()
        {
            Console.WriteLine("Informe o nome do Produto: ");
            string nome = Console.ReadLine();

            return nome;
        }

        public decimal LerPrecoProduto()
        {
            Console.WriteLine("Informe o Preço do Produto: R$ ");
            decimal preco = Convert.ToDecimal(Console.ReadLine());

            return preco;
        }
    }
}

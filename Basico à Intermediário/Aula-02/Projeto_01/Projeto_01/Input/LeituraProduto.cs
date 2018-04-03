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
            try
            {
                Console.Write("Informe o Código do Produto: ");
                int codigo = Convert.ToInt32(Console.ReadLine());

                return codigo;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
                return LerCodigo();
            }
        }

        public string LerNomeProduto()
        {
            try
            {
                Console.Write("Informe o nome do Produto: ");
                string nome = Console.ReadLine();

                return nome;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
                return LerNomeProduto();
            }
        }

        public decimal LerPrecoProduto()
        {
            try
            {
                Console.Write("Informe o Preço do Produto: R$ ");
                decimal preco = Convert.ToDecimal(Console.ReadLine());

                return preco;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return LerPrecoProduto();
            }
        }
    }
}

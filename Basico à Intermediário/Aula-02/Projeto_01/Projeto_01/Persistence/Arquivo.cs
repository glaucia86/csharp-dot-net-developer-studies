using System;
using System.IO;
using Projeto_01.Model;

namespace Projeto_01.Persistence
{
    public class Arquivo
    {
        public void GravarExcel(Produto produto)
        {
            try
            {
                var sw = new StreamWriter("C:\\Users\\Glaucia\\Downloads\\Labs\\csharp-dot-net-developer-studies\\Basico à Intermediário\\Aula-02\\Projeto_01\\estoque.csv", true);
                sw.WriteLine(produto.Codigo + ";" + produto.Nome + ";" + produto.Preco);
                sw.Close();

                Console.WriteLine("\nDados gravados com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }
    }
}

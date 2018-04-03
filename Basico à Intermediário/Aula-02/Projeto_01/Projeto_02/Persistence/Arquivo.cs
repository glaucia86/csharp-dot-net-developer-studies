using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_02.Model;

namespace Projeto_02.Persistence
{
    public class Arquivo
    {
        public void GravarExcel(Funcionario funcionario)
        {
            try
            {
                var sw = new StreamWriter("C:\\Users\\Glaucia\\Downloads\\Labs\\csharp-dot-net-developer-studies\\Basico à Intermediário\\Aula-02\\Projeto_01\\funcionario.csv", true);

                sw.WriteLine(funcionario.IdFuncionario + ";" 
                    + funcionario.Nome 
                    + ";" + funcionario.Idade 
                    + ";" + funcionario.Funcao 
                    + ";" + funcionario.TempoEmpresa);

                sw.Close();

                Console.WriteLine("\nDados Gravados com Sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}

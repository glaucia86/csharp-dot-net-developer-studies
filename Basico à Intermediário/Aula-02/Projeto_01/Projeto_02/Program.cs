using System;
using Projeto_02.Input;
using Projeto_02.Model;
using Projeto_02.Persistence;

namespace Projeto_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario();
            var leituraFuncionario = new LeituraFuncionario();

            funcionario.IdFuncionario = leituraFuncionario.LerCodigoFuncionario();
            funcionario.Nome = leituraFuncionario.LerNomeFuncionario();
            funcionario.Idade = leituraFuncionario.LerIdadeFuncionario();
            funcionario.TempoEmpresa = leituraFuncionario.LerTempoEmpresaFuncionario();

            Console.WriteLine("\n ------> Dados dos Funcionários <------");
            Console.WriteLine("Id......: " + funcionario.IdFuncionario);
            Console.WriteLine("Nome....: " + funcionario.Nome);
            Console.WriteLine("Idade...: " + funcionario.Idade);
            Console.WriteLine("Tempo de Empresa.....: " + funcionario.TempoEmpresa);
            Console.WriteLine("\n----------------------------------");

            var arquivo = new Arquivo();
            arquivo.GravarExcel(funcionario);

            Console.ReadLine();
        }
    }
}

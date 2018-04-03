using System;
using System.Text.RegularExpressions;

namespace Projeto_02.Input
{
    public class LeituraFuncionario
    {
        public int LerCodigoFuncionario()
        {
            try
            {
                Console.Write("Informe o Id do Funcionário....: ");
                int codigoFuncionario = Convert.ToInt32(Console.ReadLine());

                return codigoFuncionario;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
                return LerCodigoFuncionario();
            }
        }

        public string LerNomeFuncionario()
        {
            try
            {
                Console.Write("Informe o nome do Funcionário....: ");
                string nomeFuncionario = Console.ReadLine();

                var regex = new Regex("^[A-Za-zÀ-Üà-ü0-9\\s]{3,30}$");

                if (regex.IsMatch(nomeFuncionario))
                {
                    return nomeFuncionario;
                }

                throw new Exception("Nome inválido!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return LerNomeFuncionario();
            }
        }

        public int LerIdadeFuncionario()
        {
            try
            {
                Console.Write("Informe a Idade do Funcionário....: ");
                int idadeFuncionario = Convert.ToInt32(Console.ReadLine());

                return idadeFuncionario;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return LerIdadeFuncionario();
            }
        }

        public string LerFuncaoFuncionario()
        {
            try
            {
                Console.Write("Informa a Função do Funcionário....: ");
                string funcaoFuncionario = Console.ReadLine();

                var regex = new Regex("^[A-Za-zÀ-Üà-ü0-9\\s]{3,30}$");

                if (regex.IsMatch(funcaoFuncionario))
                {
                    return funcaoFuncionario;
                }

                throw new Exception("Função inválido!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
                return LerFuncaoFuncionario();
            }
        }

        public int LerTempoEmpresaFuncionario()
        {
            try
            {
                Console.Write("Informe o Tempo de Empresa do Funcionário....: ");
                int tempoEmpresa = Convert.ToInt32(Console.ReadLine());

                return tempoEmpresa;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return LerTempoEmpresaFuncionario();
            }
        }
    }
}

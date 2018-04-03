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

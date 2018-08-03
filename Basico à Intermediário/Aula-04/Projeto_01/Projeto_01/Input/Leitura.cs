using System;

namespace Projeto_01.Input
{
    public class Leitura
    {
        // Método responsável por Retornar o Id de 'Pessoa':
        public int RetornarIdPessoa()
        {
            Console.Write("Por favor, informe o seu Id....: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public string RetornarNome()
        {
            Console.Write("Por favor, informe o seu nome.....: ");
            return Console.ReadLine();
        }

        public string RetornarEmail()
        {
            Console.Write("Por favor, informe o seu e-mail.....: ");
            return Console.ReadLine();
        }
    }
}

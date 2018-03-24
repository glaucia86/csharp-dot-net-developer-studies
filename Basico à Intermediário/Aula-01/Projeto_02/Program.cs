using System;
using Projeto_02.Model;

namespace Projeto_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pessoaFisica = new PessoaFisica()
            {
                IdCliente = 1,
                Nome = "José Lemos",
                Cpf = "000.000.000-00",

               Endereco = new Endereco()
               {
                 Estado  = "Jorge Yunes 0000, Recreio dos Bandeirantes",
                 Logradouro = "Rio de Janeiro"
               },
            };

            Console.WriteLine("Pessoa Física....................: " + pessoaFisica.Nome);
            Console.WriteLine("CPF..............................: " + pessoaFisica.Cpf);
            Console.WriteLine("Logradouro.......................: " + pessoaFisica.Endereco.Logradouro);
            Console.WriteLine("Estado...........................: " + pessoaFisica.Endereco.Estado);

            Console.ReadKey();
        }
    }
}

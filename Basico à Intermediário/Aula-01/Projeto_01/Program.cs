using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_01.Model;

namespace Projeto_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            var p = new Pessoa
            {
                //Entrada de Dados:
                IdPessoa = 1,
                Email = "skinclear86@gmail.com",
                Nome = "Glaucia Lemos"               
            };

            //Saída de Dados:
            Console.WriteLine("Id Pessoa....................: " + p.IdPessoa);
            Console.WriteLine("Nome.........................: " + p.Nome);
            Console.WriteLine("Email........................: " + p.Email);

            Console.ReadKey();
        }
    }
}

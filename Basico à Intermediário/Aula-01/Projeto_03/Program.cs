using System;
using Projeto_03.Model;

namespace Projeto_03
{
    public class Program
    {
        static void Main(string[] args)
        {
            var estagiario = new Estagiario()
            {
                IdFuncionario = 1,
                Nome = "José Lemos",
                Salario = 4500.00,
                Tipo = "CLT"               
            };

            var terceirizado = new Terceirizado()
            {
                IdFuncionario = 2,
                Nome = "Jake Lemos",
                Salario = 5500.00,
                Categoria = "Administração",               
            };

            Console.WriteLine("===== Dados Estagiário =====");
            Console.WriteLine("Id.............................: " + estagiario.IdFuncionario);
            Console.WriteLine("Nome.............................: " + estagiario.Nome);
            Console.WriteLine("Salário..........................: R$ " + estagiario.Salario);
            Console.WriteLine("Tipo.............................: " + estagiario.Tipo);

            Console.WriteLine("\n\n===== Dados Terceirizado =====");
            Console.WriteLine("Id.............................: " + terceirizado.IdFuncionario);
            Console.WriteLine("Nome.............................: " + terceirizado.Nome);
            Console.WriteLine("Salário..........................: R$ " + terceirizado.Salario);
            Console.WriteLine("Tipo.............................: " + terceirizado.Categoria);

            Console.ReadKey();
        }
    }
}

using System;

namespace Projeto_01.Model
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }

        public string Nome { get; set; }

        public decimal Salario { get; set; }

        // Construtor:
        public Funcionario()
        {
            //default
        }

        // Sobrecarga de Construtores: (Overloading):
        public Funcionario(int idFuncionario, string nome, decimal salario)
        {
            this.IdFuncionario = idFuncionario;
            this.Nome = nome;
            this.Salario = salario;
        }

        // Sobescrita dos métodos da Classe Object:
        public override string ToString()
        {
            return String.Format("{0}, {1}, {2:c}", IdFuncionario, Nome , Salario);
        }
    }
}

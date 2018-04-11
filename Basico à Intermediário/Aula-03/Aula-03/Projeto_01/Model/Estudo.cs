using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_01.Model
{
    public class Estudo
    {
        public void Teste_01()
        {
            var vetor = new int[3]; // vetor de 3 posições

            vetor[0] = 10;
            vetor[1] = 20;
            vetor[2] = 30;

            var contador = 0;

            while (contador < vetor.Length)
            {
                Console.WriteLine(vetor[contador]);
                contador++;
            }

            // Exemplo de vetor de Objetos:
            var equipe = new Funcionario[3];

            equipe[0] = new Funcionario(1, "Glaucia Lemos", 9000);
            equipe[1] = new Funcionario(2, "Jose Lemos", 3000);
            equipe[2] = new Funcionario(3, "Jurema Lemos", 4000);

            foreach (var funcionario in equipe)
            {
                Console.WriteLine(funcionario.ToString());
            }
        }

        public void Teste_02()
        {
            var lista = new List<Funcionario>
            {
                new Funcionario(1, "Rafael Almeida", 5000),
                new Funcionario(1, "Ray Carneiro", 7000),
                new Funcionario(1, "Daniel Passos", 3000)
            };

            Console.WriteLine("Quantidade de Funcionários.....: " + lista.Count);

            // Saída das infos da lista:
            foreach (var funcionario in lista)
            {
                Console.WriteLine(funcionario.ToString());
            }
        }
    }
}

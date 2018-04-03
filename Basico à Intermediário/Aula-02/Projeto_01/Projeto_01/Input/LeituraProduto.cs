﻿using System;

namespace Projeto_01.Input
{
    public class LeituraProduto
    {
        public int LerCodigo()
        {
            try
            {
                Console.Write("Informe o Código do Produto: ");
                int codigo = Convert.ToInt32(Console.ReadLine());

                if (codigo > 0)
                {
                    return codigo;
                }

                throw new Exception("Código inválido!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
                return LerCodigo();
            }
        }

        public string LerNomeProduto()
        {
            try
            {
                Console.Write("Informe o nome do Produto: ");
                string nome = Console.ReadLine();

                return nome;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
                return LerNomeProduto();
            }
        }

        public decimal LerPrecoProduto()
        {
            try
            {
                Console.Write("Informe o Preço do Produto: R$ ");
                decimal preco = Convert.ToDecimal(Console.ReadLine());

                if (preco > 0 && preco <= 1000)
                {
                    return preco;
                }

                throw new Exception("Preço inválido!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return LerPrecoProduto();
            }
        }
    }
}

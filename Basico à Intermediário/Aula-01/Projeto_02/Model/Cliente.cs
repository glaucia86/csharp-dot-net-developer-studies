namespace Projeto_02.Model
{
    public class Cliente
    {
        private int idCliente;

        private string nome;

        //Relacionamento 1 -> n Cliente possui Endereços
        private Endereco endereco;

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

    }
}

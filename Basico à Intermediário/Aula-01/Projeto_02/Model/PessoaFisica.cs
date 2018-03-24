namespace Projeto_02.Model
{
    public class PessoaFisica : Cliente
    {
        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
    }
}

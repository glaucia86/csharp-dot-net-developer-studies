namespace Projeto_02.Model
{
    public class PessoaJuridica : Cliente
    {
        private string cnpj;

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
    }
}

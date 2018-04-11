namespace Projeto_02.Model
{
    public interface IArquivo
    {
        void AbrirArquivo();

        void GravarConteudo(string texto);

        void FecharArquivo();
    }
}

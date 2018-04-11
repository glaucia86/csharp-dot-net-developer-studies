using System.IO;
using System.Runtime.CompilerServices;

namespace Projeto_02.Model
{
    public class Documento : IArquivo
    {
        private StreamWriter sw;

        public void AbrirArquivo()
        {
            sw = new StreamWriter("C:\\Users\\Glaucia\\Downloads\\Labs\\csharp-dot-net-developer-studies\\Basico à Intermediário\\Aula-03\\Aula-03\\documento.doc", true);    
        }

        public void GravarConteudo(string texto)
        {
            sw.WriteLine(texto);
        }

        public void FecharArquivo()
        {
            sw.Close();
        }
    }
}

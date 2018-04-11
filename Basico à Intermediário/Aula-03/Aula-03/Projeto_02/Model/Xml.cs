using System.IO;
using System.Text;

namespace Projeto_02.Model
{
    public class Xml : IArquivo
    {
        private StreamWriter sw;

        public void AbrirArquivo()
        {
            sw = new StreamWriter("C:\\Users\\Glaucia\\Downloads\\Labs\\csharp-dot-net-developer-studies\\Basico à Intermediário\\Aula-03\\Aula-03\\aula.xml");
        }

        public void GravarConteudo(string texto)
        {
            var sb = new StringBuilder();

            sb.Append("<?xml version='1.0' ?>");
            sb.Append("<dados>");
                sb.AppendFormat("<texto>{0}</texto>");
            sb.Append("</dados>");
            sw.WriteLine(sb.ToString());
        }

        public void FecharArquivo()
        {
            sw.Close();
        }
    }
}

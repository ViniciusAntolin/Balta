namespace Balta.ContextoConteudo
{
    public abstract class Conteudo : BaseConteudo // Classe Base
    {
        public Conteudo(string titulo, string url)
        {
            Titulo = titulo;
            Url = url;
        }

        public string Titulo { get; set; }
        public string Url { get; set; }
    }
}

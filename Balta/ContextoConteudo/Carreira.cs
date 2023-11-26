namespace Balta.ContextoConteudo
{
    public class Carreira : Conteudo
    {
        public Carreira(string titulo, string url)
            : base(titulo, url)
        {
            Items = new List<ItemCarreira>();
        }
        public IList<ItemCarreira> Items { get; set; }
        public int TotalCursos => Items.Count; //Expression Body - Arrow function
    }
}

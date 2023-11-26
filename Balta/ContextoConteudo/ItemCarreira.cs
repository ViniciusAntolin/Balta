namespace Balta.ContextoConteudo
{
    public class ItemCarreira : BaseConteudo
    {
        public ItemCarreira(int ordem, string titulo, string descricao, Curso cursos)
        {
            Ordem = ordem;
            Titulo = titulo;
            Descricao = descricao;
            Cursos = cursos ?? throw new Exception("O Curso não pode ser nulo");
        }

        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Curso Cursos { get; set; }
    }
}

using Balta.ContextoCompartilhado;
using Balta.ContextoNotificacao;

namespace Balta.ContextoConteudo
{
    public class ItemCarreira : Base
    {
        public ItemCarreira(int ordem, string titulo, string descricao, Curso cursos)
        {
            Ordem = ordem;
            Titulo = titulo;
            Descricao = descricao;
            Cursos = cursos;
            ValidarSeCursoEhVazio();
        }

        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Curso Cursos { get; set; }

        private void ValidarSeCursoEhVazio()
        {
            if(Cursos == null)
                AddNotificacao(new Notificaocao("ItemCarreira", "Curso é nulo"));
        }
    }
}

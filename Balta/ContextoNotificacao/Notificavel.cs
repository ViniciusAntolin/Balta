namespace Balta.ContextoNotificacao
{
    public abstract class Notificavel
    {
        public List<Notificaocao> Notificaocoes { get; set; }

        public Notificavel()
        {
            Notificaocoes = new List<Notificaocao>();
        }

        public void AddNotificacao(Notificaocao notificaocao)
        {
            Notificaocoes.Add(notificaocao);
        }
        public void AddNoticacoes(IEnumerable<Notificaocao> notificaocao)
        {
            Notificaocoes.AddRange(notificaocao);
        }

        public bool EhInvalido => Notificaocoes.Any();
    }
}

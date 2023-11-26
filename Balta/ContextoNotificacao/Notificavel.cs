namespace Balta.ContextoNotificacao
{
    public abstract class Notificavel
    {
        public List<Notificaocao> Notificaocaos { get; set; }

        public void Add(Notificaocao notificaocao)
        {
            Notificaocaos.Add(notificaocao);
        }
        public void AddRange(IEnumerable<Notificaocao> notificaocao)
        {
            Notificaocaos.AddRange(notificaocao);
        }
    }
}

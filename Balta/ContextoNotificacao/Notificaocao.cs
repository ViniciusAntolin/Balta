namespace Balta.ContextoNotificacao
{
    public sealed class Notificaocao
    {
        public Notificaocao()
        {
            
        }

        public Notificaocao(string propriedade, string mensagem)
        {
            Propriedade = propriedade;
            Mensagem = mensagem;
        }

        public string Propriedade { get; set; }
        public string Mensagem { get; set; }
    }
}
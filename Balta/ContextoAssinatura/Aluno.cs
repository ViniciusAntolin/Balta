using Balta.ContextoCompartilhado;
using Balta.ContextoNotificacao;

namespace Balta.ContextoAssinatura
{
    public class Aluno : Base
    {
        public Aluno()
        {
            Assinaturas = new List<Assinatura>();
        }
        public Usuario Usuario { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public IList<Assinatura> Assinaturas { get; private set; }
        public bool EhPremium => Assinaturas.Any(x => !x.EhInvalido);
        public void CriarAssintaura(Assinatura assinatura)
        {
            if (EhPremium)
            {
                AddNotificacao(new Notificaocao("Premium", "O aluno já tem uma assinatura Premium ativa"));
                return;
            }

            Assinaturas.Add(assinatura);
        }
    }
}

using Balta.ContextoNotificacao;

namespace Balta.ContextoCompartilhado
{
    public class Base : Notificavel
    {
        public Base()
        {
            Codigo = Guid.NewGuid(); //Indica o ponto unico de falha, pois todos ids estão sendo gerados nessa classe e neste momento.;
        }

        public Guid Codigo { get; private set; }
    }
}

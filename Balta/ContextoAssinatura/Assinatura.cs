using Balta.ContextoCompartilhado;

namespace Balta.ContextoAssinatura
{
    public class Assinatura : Base
    {
        public Plano Plano { get; set; }
        private DateTime? _dataFinal { get; set; }
        public bool EstaInativo => _dataFinal <= DateTime.Now;
    }
}

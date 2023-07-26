using Commerce.Models;
using Commerce.Notifications.Interfaces;

namespace Commerce.Notifications
{
    public class Notificador : INotificador
    {

        private List<Notificacao> _notificacoes;
        public void Handle(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        public List<Notificacao> ObterNotificacoes()
        {
            return _notificacoes;
        }

        public bool TemNotificacao()
        {
            return _notificacoes.Any();
        }
    }
}

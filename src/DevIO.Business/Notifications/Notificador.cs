using DevIO.Business.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DevIO.Business.Notifications
{
    public class Notificador : INotificador
    {
        private List<Notificacao> _notificacoes;

        public Notificador()
        {
            _notificacoes = new List<Notificacao>();
        }

        public void Handle(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        public List<Notificacao> ObterNotificacoe()
        {
            return _notificacoes;
        }

        public bool TemNOtificacao()
        {
            return _notificacoes.Any();
        }
    }
}

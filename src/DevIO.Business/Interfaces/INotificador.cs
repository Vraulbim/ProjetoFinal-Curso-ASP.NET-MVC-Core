using DevIO.Business.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Interfaces
{
    public interface INotificador
    {

        bool TemNOtificacao();

        List<Notificacao> ObterNotificacoe();

        void Handle(Notificacao notificacao);

    }
}

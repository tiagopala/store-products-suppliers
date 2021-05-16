using Store.Business.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}

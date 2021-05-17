using System;
using System.Collections.Generic;
using System.Text;
﻿using Store.Business.Notificacoes;

namespace Store.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacao();
        void Handle(Notificacao notificacao);
    }
}

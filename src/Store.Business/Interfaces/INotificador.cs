﻿using Store.Business.Notificacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacao();
        void Handle(Notificacao notificacao);
    }
}

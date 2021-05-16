<<<<<<< HEAD
﻿using Store.Business.Notifications;
=======
﻿using Store.Business.Notificacoes;
>>>>>>> 3610b6123b1ebaefc4318a63d6c8daa35f9a1fae
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
<<<<<<< HEAD
        List<Notificacao> ObterNotificacoes();
=======
        List<Notificacao> ObterNotificacao();
>>>>>>> 3610b6123b1ebaefc4318a63d6c8daa35f9a1fae
        void Handle(Notificacao notificacao);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Notifications
{
    public class Notificacao
    {

        public Notificacao(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }
}

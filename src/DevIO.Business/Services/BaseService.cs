using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Business.Notifications;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Services
{
    public abstract class BaseService
    {
        private readonly INotificador _notificador;

        public BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }


        protected void Notificar(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }

        protected void Notificar(ValidationResult validation)
        {
            foreach (var erro in validation.Errors)
            {
                Notificar(erro.ErrorMessage);
            }
        }

        protected bool ExecValidation<TV, TE>(TV validation, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validacao = validation.Validate(entidade);

            if (validacao.IsValid) return true;

            Notificar(validacao);
            return false;
        }

    }
}

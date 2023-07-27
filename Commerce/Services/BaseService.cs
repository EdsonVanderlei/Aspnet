using Commerce.Data.Entities;
using Commerce.Models;
using Commerce.Notifications;
using Commerce.Notifications.Interfaces;
using FluentValidation;
using FluentValidation.Results;
using System.Runtime.CompilerServices;

namespace Commerce.Services
{
    public abstract class BaseServico
    {

        private readonly INotificador _notificador;

        protected BaseServico(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(string MensagemErro)
        {
            _notificador.Handle(new Notificacao(MensagemErro));
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var item in validationResult.Errors)
            {
                Notificar(item.ErrorMessage);
            }
        }

        protected bool TemNotificacao()
        {
            return _notificador.ObterNotificacoes().Any();
        }
        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : Entidade
        {
            var validate = validacao.Validate(entidade);
            if (validate.IsValid) return true;
            Notificar(validate);
            return false;
        }
    }
}

using Commerce.Notifications.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Commerce.Models;

namespace Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class MainController : ControllerBase
    {

        private readonly INotificador _notificador;

        protected MainController(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected bool CustomRespomse(ModelStateDictionary modelState)
        {
            if (ModelState.IsValid)
            {
                return true;
            }
            var erros = modelState.SelectMany(p => p.Value.Errors).ToList();
            foreach( var erro in erros)
            {
                string message = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message;
                _notificador.Handle(new Notificacao(message));
            }
            return false;
        }

        protected ActionResult CustomResponse(object obj = null)
        {
            if (OperacaoValida())
            {
                return Ok(new {
                    sucesso = true,
                    result = obj
                });
            }
            return BadRequest(new
            {
                sucesso = false,
                erros = _notificador.ObterNotificacoes().Select(p => p.Mensagem)
            });
        }

        protected bool OperacaoValida()
        {
            return !_notificador.TemNotificacao();
        }
    }
}

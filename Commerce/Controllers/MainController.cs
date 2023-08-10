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

        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
       
            var erros = modelState.SelectMany(p => p.Value.Errors).ToList();

            return BadRequest(new
            {
                sucesso = false,
                erros = erros
            });
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

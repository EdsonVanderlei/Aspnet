using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        protected ActionResult CustomResponse(ModelStateDictionary modelState){} 
        protected void NotificarErroModelInvalida(ModelStateDictionary modelState) {
            var erros = modelState.SelectMany(p => p.Value.Errors);
            foreach( var erro in erros)
            {
                 var erroMsg = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message; 
            }
        }
    }
}

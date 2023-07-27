using AutoMapper;
using Commerce.Data.Entities;
using Commerce.Data.Interfaces;
using Commerce.Models;
using Commerce.Notifications.Interfaces;
using Commerce.Services;
using Commerce.Services.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Commerce.Controllers
{
    public class UsuarioController : MainController
    {
        private readonly IUsuarioServico _userService;
    
     
        public UsuarioController(IUsuarioServico userService, INotificador notificador) : base(notificador)
        {
            _userService = userService;
        }

        [HttpPost("Adicionar")]
        async public Task<ActionResult> AdicionarUsuario(CadastroUsuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.SelectMany(p => p.Value.Errors).ToList());
            }
            await _userService.Cadastrar(usuario);
            return CustomResponse(usuario);
        }
    }
}

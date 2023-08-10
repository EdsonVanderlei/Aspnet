using AutoMapper;
using Commerce.Data.Entities;
using Commerce.Data.Interfaces;
using Commerce.Models;
using Commerce.Notifications.Interfaces;
using Commerce.Services;
using Commerce.Services.Interface;
using Commerce.Services.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Commerce.Controllers
{
    public class UsuarioController : MainController
    {
        private readonly IUsuarioServico _userService;
        private readonly IAutenticacaoServico _autenticacaoServico;
    
     
        public UsuarioController(IUsuarioServico userService, INotificador notificador, IAutenticacaoServico autenticacaoServico) : base(notificador)
        {
            _userService = userService;
            _autenticacaoServico = autenticacaoServico;
        }

        [HttpPost("Adicionar")]
        async public Task<ActionResult> AdicionarUsuario(CadastroUsuario usuario)
        {
            await _userService.Cadastrar(usuario);
            return CustomResponse(usuario);
        }

        [HttpPost("Login")]
        async public Task<ActionResult<string>> ObterToken(Login credenciais)
        {
            if(!ModelState.IsValid)
            {
                return CustomResponse(ModelState);
            }
            var token = await _autenticacaoServico.Logar(credenciais);

            return CustomResponse(new { Token = token});
        }

        [Authorize]
        [HttpGet("TesteJWT")]
        async public Task<ActionResult> Lista()
        {
            return CustomResponse();
        }
    }
}

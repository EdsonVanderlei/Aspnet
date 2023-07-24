using AutoMapper;
using Commerce.Data.Entities;
using Commerce.Data.Interfaces;
using Commerce.Models;
using Commerce.Services;
using Commerce.Services.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Commerce.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioServico _userService;
        public UsuarioController(IUsuarioServico userService)
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
            var user = await _userService.Cadastrar(usuario);
            return Ok(user);
        }
    }
}

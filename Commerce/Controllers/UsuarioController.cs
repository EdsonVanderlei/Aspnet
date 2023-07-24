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

        private readonly IRepositoryUsuario _repositoryUsuario;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        public UsuarioController(IRepositoryUsuario repositoryUsuario, IMapper mapper, IUserService userService)
        {
            _repositoryUsuario = repositoryUsuario;
            _mapper = mapper;
            _userService = userService;
        }

        [HttpPost("Adicionar")]
        async public Task<ActionResult> AddUsuario(RegisterUsuario usuario)
        {
            if (ModelState.IsValid)
            {
               var user =  await _userService.Cadastrar(usuario);
           
                return Ok(user);
            }
            return BadRequest(ModelState.Select(p => p.Value.Errors).ToList().ToString());
        }
    }
}

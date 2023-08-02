using Commerce.Identity;
using Commerce.Models;
using Commerce.Notifications.Interfaces;
using Commerce.Services.Interface;
using Microsoft.AspNetCore.Identity;

namespace Commerce.Services
{
    public class AutenticacaoServico : BaseServico, IAutenticacaoServico
    {

        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        public AutenticacaoServico(INotificador notificador, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager) : base(notificador)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        async public Task<bool> Registrar(Registro registro)
        {

            IdentityUser usuario = new IdentityUser
            {
                UserName = registro.CPF,
                Email = registro.Email,
                EmailConfirmed = true,
            };

            var result = await _userManager.CreateAsync(usuario);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    Notificar(item.Description);
                }
                return false;
            }

            await _signInManager.SignInAsync(usuario, false);

            return true;

        }
        async public Task<bool> Logar(Login login)
        {

            var result = await _signInManager.PasswordSignInAsync(login.CPF, login.Senha, false, true);
            if (result.IsNotAllowed)
            {
                Notificar("Usuário ou Senha inválida !");
                return false;
            }
            else if (result.IsLockedOut)
            {
                Notificar("Usuário temporariamente bloqueado por diversas tentativas !");
                return false;
            }
            return true;

        }
    }
}

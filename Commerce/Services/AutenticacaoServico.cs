using Commerce.Identity;
using Commerce.Models;
using Commerce.Notifications.Interfaces;
using Commerce.Services.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Commerce.Services
{
    public class AutenticacaoServico : BaseServico, IAutenticacaoServico
    {

        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly AppSettings _appSettings;
        public AutenticacaoServico(INotificador notificador, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IOptions<AppSettings> appSettings) : base(notificador)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _appSettings = appSettings.Value;
        }

        async public Task<string> Registrar(Registro registro)
        {

            if (registro.Senha != registro.ConfirmaSenha)
            {
                Notificar("As duas senhas não conferem !");
                return null;
            }

            IdentityUser usuario = new IdentityUser
            {
                UserName = registro.CPF,
                Email = registro.Email,
                EmailConfirmed = true,

            };

            var result = await _userManager.CreateAsync(usuario, registro.Senha);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    Notificar(item.Description);
                }
                return null;
            }

            await _signInManager.SignInAsync(usuario, false);

            return GerarToken();
        }

        async public Task<string> Logar(Login login)
        {

            var result = await _signInManager.PasswordSignInAsync(login.CPF, login.Senha, false, true);
            if (result.IsNotAllowed)
            {
                Notificar("Usuário ou Senha inválida !");
                return null;
            }
            else if (result.IsLockedOut)
            {
                Notificar("Usuário temporariamente bloqueado por diversas tentativas !");
                return null;
            }
            return GerarToken();

        }

        private string GerarToken()
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var token = tokenHandler.CreateToken(
                new SecurityTokenDescriptor
                {
                    Audience = _appSettings.ValidoEm,
                    Issuer = _appSettings.Emissor,
                    Expires = DateTime.UtcNow.AddHours(_appSettings.ExpiracaoHoras),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                }
                );
            return tokenHandler.WriteToken(token);

        }
    }
}

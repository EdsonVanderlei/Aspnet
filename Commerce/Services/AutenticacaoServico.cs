using Commerce.Identity;
using Commerce.Notifications.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Commerce.Services
{
    public class AutenticacaoServico : BaseServico
    {

        private readonly SignInManager<UserIdentity> _signInManager;
        private readonly UserManager<UserIdentity> _userManager;
        public AutenticacaoServico(INotificador notificador, UserManager<UserIdentity> userManager, SignInManager<UserIdentity> signInManager) : base(notificador)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        
    }
}

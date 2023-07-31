using Microsoft.AspNetCore.Identity;


namespace Commerce.Identity
{
    public class UserIdentity : IdentityUser
    {
        public string CPF { get; set; }
        public string Senha { get; set; }
    }
}

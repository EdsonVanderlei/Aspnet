using Commerce.Models;

namespace Commerce.Services.Interface
{
    public interface IAutenticacaoServico
    {
        Task<string> Logar(Login login);
        Task<string> Registrar(Registro registro);
    }
}
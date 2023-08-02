using Commerce.Models;

namespace Commerce.Services
{
    public interface IAutenticacaoServico
    {
        Task<bool> Logar(Login registro);
        Task<bool> Registrar(Registro registro);
    }
}
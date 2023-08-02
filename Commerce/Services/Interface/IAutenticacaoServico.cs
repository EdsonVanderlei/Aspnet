 using Commerce.Models;

namespace Commerce.Services.Interface
{
    public interface IAutenticacaoServico
    {
        Task<bool> Logar(Login registro);
        Task<bool> Registrar(Registro registro);
    }
}
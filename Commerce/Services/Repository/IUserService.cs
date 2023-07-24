using Commerce.Data.Entities;
using Commerce.Models;

namespace Commerce.Services.Repository
{
    public interface IUserService
    {
        Task<Usuario> Cadastrar(RegisterUsuario usuario);
        Task<List<Telefone>> AtualizarTelefone(Guid id, Telefone telefone);
        Task<Endereco> AtualizarEndereco(Guid id,Endereco endereco);

    }
}

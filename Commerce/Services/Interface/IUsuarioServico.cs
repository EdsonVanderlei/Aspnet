using Commerce.Data.Entities;
using Commerce.Models;

namespace Commerce.Services.Repository
{
    public interface IUsuarioServico
    {
        Task<Usuario> Cadastrar(CadastroUsuario usuario);
        Task<Endereco> AtualizarEndereco(Guid id,Endereco endereco);

    }
}

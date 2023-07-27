using Commerce.Data.Entities;
using Commerce.Models;

namespace Commerce.Services.Repository
{
    public interface IUsuarioServico : IDisposable
    {
        Task Cadastrar(CadastroUsuario usuario);
        Task AtualizarEndereco(Guid id,EnderecoDTO endereco);
        Task DeletarUsuario(Guid id);
        Task Atualizar(UsuarioDTO usuario);
    }
}

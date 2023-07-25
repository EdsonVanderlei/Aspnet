using AutoMapper;
using Commerce.Data.Entities;
using Commerce.Data.Interfaces;
using Commerce.Models;
using Commerce.Services.Repository;

namespace Commerce.Services
{
    public class UsuarioServico : BaseServico, IUsuarioServico
    {

        private readonly IRepositoryUsuario _repositoryUsuario;
        private readonly IMapper _mapper;

        public UsuarioServico(IRepositoryUsuario repositoryUsuario, IMapper mapper)
        {
            _repositoryUsuario = repositoryUsuario;
            _mapper = mapper;
        }

        public Task Atualizar(UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }

        public Task<Endereco> AtualizarEndereco(Guid id, EnderecoDTO endereco)
        {
            throw new NotImplementedException();
        }

        async public Task<Usuario> Cadastrar(CadastroUsuario usuario)
        {
            if (usuario != null)
            {
                
                Endereco endereco = _mapper.Map<Endereco>(usuario.Endereco);
                Usuario User = _mapper.Map<Usuario>(usuario);
                User.Endereco = endereco;
                await _repositoryUsuario.Adicionar(User);
                return User;
            }
            return null;
        }

        public Task<Usuario> DeletarUsuario(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

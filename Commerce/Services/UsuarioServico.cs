using AutoMapper;
using Commerce.Data.Entities;
using Commerce.Data.Interfaces;
using Commerce.Models;
using Commerce.Services.Repository;

namespace Commerce.Services
{
    public class UsuarioServico : IUsuarioServico
    {

        private readonly IRepositoryUsuario _repositoryUsuario;
        private readonly IMapper _mapper;

        public UsuarioServico(IRepositoryUsuario repositoryUsuario, IMapper mapper)
        {
            _repositoryUsuario = repositoryUsuario;
            _mapper = mapper;
        }
        async public Task<Endereco> AtualizarEndereco(Guid id, Endereco endereco)
        {
            var user = await _repositoryUsuario.ObterPorId(id);
            user.Endereco = endereco;
            await _repositoryUsuario.Atualizar(user);
            return user.Endereco;
        }
        async public Task<Usuario> Cadastrar(CadastroUsuario usuario)
        {
            if (usuario != null)
            {
                if(!_repositoryUsuario.ExisteCpf(usuario.Cpf).Result){
                    return null;
                } if(!_repositoryUsuario.ExisteEmail(usuario.Email).Result){
                    return null;
                } if(!_repositoryUsuario.ExisteRg(usuario.Rg).Result){
                    return null;
                }
                Endereco endereco = _mapper.Map<Endereco>(usuario.Endereco);
                Usuario User = _mapper.Map<Usuario>(usuario);
                User.Endereco = endereco;
                await _repositoryUsuario.Adicionar(User);
                return User;
            }
            return null;
        }
    }
}

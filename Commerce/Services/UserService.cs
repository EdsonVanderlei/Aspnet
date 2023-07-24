using AutoMapper;
using Commerce.Data.Entities;
using Commerce.Data.Interfaces;
using Commerce.Models;
using Commerce.Services.Repository;

namespace Commerce.Services
{
    public class UserService : IUserService
    {

        private readonly IRepositoryUsuario _repositoryUsuario;
        private readonly IMapper _mapper;

        public UserService(IRepositoryUsuario repositoryUsuario, IMapper mapper)
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


        async public Task<List<Telefone>> AtualizarTelefone(Guid id, Telefone telefone)
        {
            var user = await _repositoryUsuario.ObterPorId(id);
            var tel = user.Telefones.FirstOrDefault(p => p.Id == telefone.Id);
            if (tel != null)
            {
                tel = telefone;
                await _repositoryUsuario.Atualizar(user);
                return user.Telefones;
            }
            return null;
        }


        async public Task<Usuario> Cadastrar(RegisterUsuario usuario)
        {

            if (usuario != null)
            {
                List<Telefone> telefones = new List<Telefone>();
                Endereco endereco = _mapper.Map<Endereco>(usuario.Endereco);
                Usuario User = _mapper.Map<Usuario>(usuario);
                foreach (var item in usuario.Telefone)
                {
                    var tel = _mapper.Map<Telefone>(item);
                    telefones.Add(tel);
                }
                User.Telefones = telefones;
                User.Endereco = endereco;
                await _repositoryUsuario.Adicionar(User);
                return User;
            }
            return null;

        }
    }
}

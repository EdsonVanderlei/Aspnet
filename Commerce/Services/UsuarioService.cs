using AutoMapper;
using Commerce.Data.Entities;
using Commerce.Data.Interfaces;
using Commerce.Data.Validations;
using Commerce.Models;
using Commerce.Services.Repository;

namespace Commerce.Services
{
    public class UsuarioService : BaseServico, IUsuarioServico
    {

        private readonly IMapper _mapper;
        private readonly IRepositoryUsuario _repositoryUsuario;

        public UsuarioService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task Atualizar(UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }

        async public Task AtualizarEndereco(Guid id, EnderecoDTO endereco)
        {
            throw new NotImplementedException();
        }

        async public Task Cadastrar(CadastroUsuario usuario)
        {
            var Usuario = _mapper.Map<Usuario>(usuario);   
            var validator = new UsuarioValidation();
            if (!ExecutarValidacao(new UsuarioValidation(), Usuario)) return;

            if(_repositoryUsuario.Buscar(p => p.Email  == Usuario.Email) != null)
            {
                Notificar("Já possui um E-mail Cadastrado !");
                return;
            }
            if (_repositoryUsuario.Buscar(p => p.Cpf == Usuario.Cpf) != null)
            {
                Notificar("Já possui um Cpf Cadastrado !");
                return;
            }
            if (_repositoryUsuario.Buscar(p => p.Rg == Usuario.Rg) != null)
            {
                Notificar("RG já existente !");
                return;
            }
        }

        public Task DeletarUsuario(Guid id)
        {
            throw new NotImplementedException();
        }
    }



}

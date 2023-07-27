using AutoMapper;
using BCrypt.Net;
using Commerce.Data.Entities;
using Commerce.Data.Interfaces;
using Commerce.Data.Validations;
using Commerce.Models;
using Commerce.Notifications.Interfaces;
using Commerce.Services.Repository;
using System.Text.RegularExpressions;

namespace Commerce.Services
{
    public class UsuarioService : BaseServico, IUsuarioServico
    {

        private readonly IMapper _mapper;
        private readonly IRepositoryUsuario _repositoryUsuario;

        public UsuarioService(IMapper mapper, INotificador notificador, IRepositoryUsuario repositoryUsuario) : base(notificador)
        {
            _mapper = mapper;
            _repositoryUsuario = repositoryUsuario;
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
            var Endereco = _mapper.Map<Endereco>(usuario.Endereco);
            var validator = new UsuarioValidation();
            ExecutarValidacao(new UsuarioValidation(), Usuario);
            ExecutarValidacao(new EnderecoValidation(), Endereco);
            if (TemNotificacao()) return;

            if (await _repositoryUsuario.Buscar(p => p.Email == Usuario.Email) != null)
            {
                Notificar("Já possui um E-mail Cadastrado !");
                return;
            }
            if (await _repositoryUsuario.Buscar(p => p.Cpf == Usuario.Cpf) != null)
            {
                Notificar("Já possui um Cpf Cadastrado !");
                return;
            }
            if (await _repositoryUsuario.Buscar(p => p.Rg == Usuario.Rg) != null)
            {
                Notificar("RG já existente !");
                return;
            }
            if (await _repositoryUsuario.Buscar(p => p.Telefone == Usuario.Telefone) != null)
            {
                Notificar("Telefone já existente !");
                return;
            }
            Usuario.Cpf = Regex.Replace(Usuario.Cpf, "[^0-9]", "");
            Usuario.Rg = Regex.Replace(Usuario.Rg, "[^0-9]", "");
            Usuario.Telefone = Regex.Replace(Usuario.Telefone, "[^0-9]", "");
            Usuario.Endereco = Endereco;
            Usuario.Endereco.Cep = Regex.Replace(Endereco.Cep, "[^0-9]", "");
            Usuario.Senha =  BCrypt.Net.BCrypt.HashPassword(Usuario.Senha, 10);
            await _repositoryUsuario.Adicionar(Usuario);

            Dispose();
        }

        public Task DeletarUsuario(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _repositoryUsuario.Dispose();
        }
    }
}

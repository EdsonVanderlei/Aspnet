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
            var usuario = await _repositoryUsuario.ObterPorId(id);
            if (usuario == null)
            {
                Notificar("Usuário não encontrado !");
                return;
            }
            var Endereco = _mapper.Map<Endereco>(endereco);
            if (!ExecutarValidacao(new EnderecoValidation(), Endereco)) return;

            usuario.Endereco = Endereco;
            await _repositoryUsuario.Atualizar(usuario);
            Dispose();
        }

        async public Task Cadastrar(CadastroUsuario usuario)
        {
            var Usuario = _mapper.Map<Usuario>(usuario);
            var Endereco = _mapper.Map<Endereco>(usuario.Endereco);
            var validator = new UsuarioValidation();
            if(!ExecutarValidacao(new UsuarioValidation(), Usuario))return;
            if(!ExecutarValidacao(new EnderecoValidation(), Endereco)) return ;
            var result = await _repositoryUsuario.BuscarTodos(p => p.Email == Usuario.Email || p.Cpf == Usuario.Cpf || p.Telefone == Usuario.Telefone);
            if (result.Any())
            {
                Notificar("Dados já cadastrados !");
                return;
            }
           
            Usuario.Cpf = Regex.Replace(Usuario.Cpf, "[^0-9]", "");
            Usuario.Telefone = Regex.Replace(Usuario.Telefone, "[^0-9]", "");
            Usuario.Endereco = Endereco;
            Usuario.Endereco.Cep = Regex.Replace(Endereco.Cep, "[^0-9]", "");
            Usuario.Senha = BCrypt.Net.BCrypt.HashPassword(Usuario.Senha, 10);
            await _repositoryUsuario.Adicionar(Usuario);

            Dispose();
        }

        public async Task DeletarUsuario(Guid id)
        {
            var usuario = await _repositoryUsuario.ObterPorId(id);
            if (usuario == null)
            {
                Notificar("Usuário não existe !");
                return;
            }
            await _repositoryUsuario.Remover(id);
            Dispose();
        }

        public void Dispose()
        {
            _repositoryUsuario.Dispose();
        }
    }
}

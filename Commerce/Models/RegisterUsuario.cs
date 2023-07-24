namespace Commerce.Models
{
    public class RegisterUsuario : UsuarioDTO
    {
        public EnderecoDTO Endereco { get; set; }
        public List<TelefoneDTO> Telefone { get; set; }

    }
}

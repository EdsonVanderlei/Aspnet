﻿using AutoMapper;
using Commerce.Data.Entities;
using Commerce.Models;

namespace Commerce.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<TelefoneDTO, Telefone>().ReverseMap();
            CreateMap<EnderecoDTO, Endereco>().ReverseMap();
            CreateMap<Usuario,UsuarioDTO>().ReverseMap();
        }
    }
}

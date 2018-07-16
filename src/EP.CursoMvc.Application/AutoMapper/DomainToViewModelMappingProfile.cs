using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EP.CursoMvc.Application.ViewModels;
using EP.CursoMvc.Domain.Entities;

namespace EP.CursoMvc.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile: Profile
        {
            public override string ProfileName
            {
                get { return "DomainToViewMappings"; }
            }

            protected override void Configure()
            {
                Mapper.CreateMap<Cliente, ClienteViewModel>();
                Mapper.CreateMap<Cliente, ClienteEnderecoViewModel>();
                Mapper.CreateMap<Endereco, EnderecoViewModel>();
                Mapper.CreateMap<Endereco,ClienteEnderecoViewModel>();
            }
        }
}
using System;
using AutoMapper;
using Dev.Training.DDD.Domain.Entities;
using Dev.Training.DDD.Web.ViewModels;

namespace Dev.Training.DDD.Web.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto>();
            //Mapper.CreateMap<ClienteViewModel, Cliente>();
            //Mapper.CreateMap<ProdutoViewModel, Produto>();
        }
    }
}
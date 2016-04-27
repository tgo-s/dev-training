using System;
using AutoMapper;
using Dev.Training.DDD.Domain.Entities;
using Dev.Training.DDD.Web.ViewModels;

namespace Dev.Training.DDD.Web.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
        }
    }
}
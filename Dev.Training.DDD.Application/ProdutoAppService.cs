using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dev.Training.DDD.Application.Interfaces;
using Dev.Training.DDD.Domain.Entities;
using Dev.Training.DDD.Domain.Interfaces.Services;

namespace Dev.Training.DDD.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService) : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> SearchByName(string name)
        {
            return _produtoService.SearchByName(name);
        }
    }
}

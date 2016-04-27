using System.Collections.Generic;
using Dev.Training.DDD.Domain.Entities;
using Dev.Training.DDD.Domain.Interfaces.Repositories;
using Dev.Training.DDD.Domain.Interfaces.Services;

namespace Dev.Training.DDD.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> SearchByName(string name)
        {
            return _produtoRepository.SearchByName(name);
        }
    }
}

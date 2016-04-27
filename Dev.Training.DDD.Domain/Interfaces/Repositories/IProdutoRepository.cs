using System.Collections.Generic;
using Dev.Training.DDD.Domain.Entities;

namespace Dev.Training.DDD.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> SearchByName(string name);
    }
}

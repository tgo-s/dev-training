using System.Collections.Generic;
using Dev.Training.DDD.Domain.Entities;

namespace Dev.Training.DDD.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> SearchByName(string name);
    }
}

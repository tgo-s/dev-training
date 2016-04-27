using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dev.Training.DDD.Domain.Entities;
using Dev.Training.DDD.Domain.Interfaces.Repositories;
using Dev.Training.DDD.Infrastructure.Data.Context;

namespace Dev.Training.DDD.Infrastructure.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        protected DevTrainingContext Db = new DevTrainingContext();

        public IEnumerable<Produto> SearchByName(string name)
        {
            return Db.Set<Produto>().Where(p => p.Nome.Equals(name));
        }
    }
}

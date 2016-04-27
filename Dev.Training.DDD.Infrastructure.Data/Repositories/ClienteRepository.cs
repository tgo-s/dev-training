using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dev.Training.DDD.Domain.Entities;
using Dev.Training.DDD.Domain.Interfaces.Repositories;

namespace Dev.Training.DDD.Infrastructure.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        //public IEnumerable<Cliente> GetSpecialClients()
        //{
        //    return Db.Set<Cliente>().Where(c => c.IsSpecialClient());
        //}
    }
}

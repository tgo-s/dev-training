using System.Collections.Generic;
using Dev.Training.DDD.Domain.Entities;

namespace Dev.Training.DDD.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> GetSpecialClients(IEnumerable<Cliente> clients);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Dev.Training.DDD.Domain.Entities;
using Dev.Training.DDD.Domain.Interfaces.Repositories;
using Dev.Training.DDD.Domain.Interfaces.Services;

namespace Dev.Training.DDD.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        /* Dúvida:
         * Aqui eu tenho meu método especializado de serviço. Nele eu vou tratar uma lista qualquer vinda do ClienteRepository 
         * Poderia eu ter um metodo especializado de domínio, definido na Interface IClienteRepository
         * definindo assim que na minha classe ClienteRepository deveria ser impelmentado um método
         * buscando os clientes especiais direto do DbSet ?
         */
        public IEnumerable<Cliente> GetSpecialClients(IEnumerable<Cliente> clients)
        {
            return clients.Where(c => c.IsSpecialClient());
        }
    }
}

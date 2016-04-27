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
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clientService;

        public ClienteAppService(IClienteService clientAppService) : base(clientAppService)
        {
            _clientService = clientAppService;
        }

        public IEnumerable<Cliente> GetSpecialClients()
        {
            return _clientService.GetSpecialClients(_clientService.GetAll());
        }
    }
}

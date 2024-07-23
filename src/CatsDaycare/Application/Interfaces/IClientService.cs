using Application.Models.Requests;
using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IClientService
    {
        public ClientDto CreateClient(ClientCreateRequest request);
        public ClientDto UpdateClient(ClientUpdateRequest request);
        public void DeleteClient(int id);
        public ClientDto GetClientById(int id);
        public IList<ClientDto> GetAllClients();
        public void SaveChanges();
    }
}

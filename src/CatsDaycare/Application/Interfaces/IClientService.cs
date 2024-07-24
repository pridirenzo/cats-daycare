using Application.Models.Requests;
using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatsDaycare.Domain.Entites;

namespace Application.Interfaces
{
    public interface IClientService
    {
        public ClientDto CreateClient(ClientCreateRequest request);
        public void UpdateClient(int id, ClientUpdateRequest request);
        public void DeleteClient(int id);
        public ClientDto GetClientById(int id);
        public Client? GetClientByUsername(string username);
        public IList<ClientDto> GetAllClients();
        public void SaveChanges();
    }
}

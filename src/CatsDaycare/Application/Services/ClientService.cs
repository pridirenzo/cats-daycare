using Application.Interfaces;
using Application.Models;
using Application.Models.Requests;
using CatsDaycare.Domain.Entites;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _repository;

        public ClientService(IClientRepository repository)
        {
            _repository = repository;
        };

        public ClientDto CreateClient(ClientCreateRequest clientCreateRequest)
        {
            var client = new Client();

            client.Username = clientCreateRequest.Username;
            client.Password = clientCreateRequest.Password;
            client.Email = clientCreateRequest.Email;
            client.PhoneNumber = clientCreateRequest.PhoneNumber;
            client.Surname = clientCreateRequest.Surname;

            return ClientDto.Create(_repository.Create(client));

        }

        public void DeleteClient(int id)
        {
            _repository.Delete(id);
            _repository.SaveChanges();
  
        }
        

        public void UpdateClient(int id, ClientUpdateRequest request)
        {
            _repository.Update(id);
            _repository.SaveChanges();

        }

        public Client? GetClientByUsername(string username)
        {
            var client = _repository.GetByUsername(username);

            return client;
          

        }

        public ClientDto GetClientById(int id)
        {
            var client = _repository.GetById(id);

            return ClientDto.Create(client);


        }

        public void SaveChanges()
        {
            SaveChanges();
        }

        public IList<ClientDto> GetAllClients()
        {
            return _repository.GetAll();
        }


    }
}

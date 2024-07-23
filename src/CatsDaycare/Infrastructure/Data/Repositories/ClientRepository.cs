using Application.Models;
using Application.Models.Requests;
using CatsDaycare.Domain.Entites;
using Domain.Entities.User;
using Domain.Interfaces;
using Microsoft.Extensions.DependencyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly ApplicationContext _context;

        public ClientRepository(ApplicationContext context) 
        {
            _context = context;
        }


        public Client? GetById(int id)
        {
            var client = _context.Users.OfType<Client>().FirstOrDefault(u => u.Id == id);
            return client;
        }

        public IList<Client> GetAll()
        {
            return _context.Users.OfType<Client>().ToList();
        }


        public void Delete(int id)
        {
            var client = _context.Users.OfType<Client>().FirstOrDefault(u => u.Id == id);
            _context.Users.Remove(client);
            _context.SaveChanges();
        }

        public Client Create(Client client)
        {
            var newClient = new Client();
            newClient.Name = client.Name;
            newClient.Surname = client.Surname;
            newClient.PhoneNumber = client.PhoneNumber;
            newClient.Email = client.Email;
            newClient.Password = client.Password;
            newClient.Username = client.Username;
            
            _context.Users.Add(client);
            _context.SaveChanges();
            return newClient;

        }

        public void Update(int id)
        {
            var client = _context.Users.OfType<Client>().FirstOrDefault(c => c.Id == id);
            _context.Users.Update(client);
            _context.SaveChanges();
        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }






    }
}

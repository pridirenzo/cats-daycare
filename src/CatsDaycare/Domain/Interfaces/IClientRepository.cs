using CatsDaycare.Domain.Entites;
using Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    // segun criterio del arquitecto - interfaces de repos o en DOMAIN o en APPLICATION
    public interface IClientRepository
    {
        public Client? GetById(int id);
        public Client? GetByUsername(string username);
        public IList<Client?> GetAll();
        public void Delete(int id);
        public Client Create(Client client);
        public void Update(int id);
        public void SaveChanges();
  
    }
}

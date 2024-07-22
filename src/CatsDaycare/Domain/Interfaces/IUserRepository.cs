using Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        public User GetById(int id);
        public List<User> GetAll();
        public void Delete(int id);
        public User Create(User user);
        public void Update(int id);

        public void SaveChanges();
  
    }
}

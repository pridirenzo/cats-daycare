using Application.Models.Requests;
using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAdminService
    {
        public AdminDto CreateAdmin(AdminCreateRequest request);
        public void UpdateAdmin(AdminUpdateRequest request);
        public void DeleteAdmin(int id);
        public AdminDto GetAdminById(int id);
        public IList<AdminDto> GetAllAdmins();
        public void SaveChanges();
    }
}

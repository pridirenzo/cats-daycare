using Application.Models.Requests;
using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICatService
    {
        public CatDto CreateCat(CatCreateRequest request);
        public CatDto UpdateCat(CatUpdateRequest request);
        public void DeleteCat(int id);
        public CatDto GetCatById(int id);
        public IList<CatDto> GetAllCats();
        public void SaveChanges();
    }
}

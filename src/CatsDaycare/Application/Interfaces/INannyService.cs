using Application.Models.Requests;
using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface INannyService
    {

        public NannyDto CreateNanny(NannyCreateRequest request);
        public void UpdateNanny(NannyUpdateRequest request);
        public void DeleteNanny(int id);
        public NannyDto GetNannyById(int id);
        public IList<NannyDto> GetAllNannies();
        public void SaveChanges();
    }
}

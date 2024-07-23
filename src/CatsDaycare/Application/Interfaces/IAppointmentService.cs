using Application.Models.Requests;
using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAppointmentService
    {
        public AppointmentDto CreateAppointment(AppointmentCreateRequest request);
        public AppointmentDto UpdateAppointment(AppointmentUpdateRequest request);
        public void DeleteAppointment(int id);
        public AppointmentDto GetAppointmentById(int id);
        public IList<AppointmentDto> GetAllAppointments();
        public void SaveChanges();
    }
}

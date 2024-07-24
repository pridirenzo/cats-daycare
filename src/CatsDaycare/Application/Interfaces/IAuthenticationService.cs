using Application.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAuthenticationService
    {

        public string Authenticate(AuthenticationRequest request); // devuelve string pq el token sale en forma de string

    }
}

using Application.Interfaces;
using Application.Models.Requests;
using CatsDaycare.Domain.Entites;
using Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        // inyectar repositorio de la entidad a autenticar. puede ser user, en este caso

        private readonly IClientRepository _clientRepository;
        private readonly IConfiguration _configuration;
        // permite acceder al app settings json a traves d navegacion tipo diccionario
        public AuthenticationService(IClientRepository clientRepository, IConfiguration configuration)
        {
            _clientRepository = clientRepository;
            _configuration = configuration;
        }

        // creamos metodo para validar credenciales

        public Client? ValidateClient(AuthenticationRequest authenticationRequest)
        {
            if (string.IsNullOrEmpty(authenticationRequest.Username) || string.IsNullOrEmpty(authenticationRequest.Password){
                return null;
            }
            // si el username pasado es vacio o nulo, al igual q la contraseña, retorna null


            // llama al repositorio. busca por username. 
            var client = _clientRepository.GetByUsername(authenticationRequest.Username);

            if (client == null)
            {
                return null;
            }

            // si contraseña del cliente encontrado en repo coincide con la ingresada, valido
            if(client.Password == authenticationRequest.Password)
            {
                return client;
            }

            return null;

        }


        public string Authenticate(AuthenticationRequest authenticationRequest)
        {
            // llamar a funcion q valida, creada anteriormente, con parametros ingresados en request (caso d uso)

            var client = ValidateClient(authenticationRequest);


            if (client == null)
            {
                throw new Exception("Cliente inexistente, fallo la autenticacion");
            }

            // traemos secret key del json
            var securityPassword = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["Authentication:SecretForKey"]));

            var credentials = new SigningCredentials(securityPassword, SecurityAlgorithms.HmacSha256);

            var claimsForToken = new List<Claim>();

            claimsForToken.Add(new Claim("sub", client.Id.ToString()));
            claimsForToken.Add(new Claim("given_name", client.Name));
            claimsForToken.Add(new Claim("user_role", client.UserRole.ToString());

            // creo token
            var jwtSecurityToken = new JwtSecurityToken(
                _configuration["Authentication:Issuer"],
                _configuration["Authentication:Audience"],
                claimsForToken,
                DateTime.UtcNow,
                DateTime.UtcNow.AddHours(1),
                credentials);

            var tokenToReturn = new JwtSecurityTokenHandler() // pasar token a string
                .WriteToken(jwtSecurityToken);

            return tokenToReturn;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHR.Application.Dtos
{
    public class UserDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }   
        public string Password { get; set; }
        public string NomeCompleto { get; set; }
        public string Funcao { get; set; }
        public string Visao { get; set; }
    }
}
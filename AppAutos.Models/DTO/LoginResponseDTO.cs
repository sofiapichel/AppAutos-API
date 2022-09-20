using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM.AppAutos.BE.Models.DTO
{
    public class LoginResponseDTO
    {
        public string UserName { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public List<string> Grupos { get; set; } = new List<string>();
    }
}

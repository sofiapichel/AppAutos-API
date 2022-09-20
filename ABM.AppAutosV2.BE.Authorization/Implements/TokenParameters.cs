using ABM.AppAutosV2.BE.Authorization.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM.AppAutosV2.BE.Authorization.Implements
{
    public class TokenParameters : ITokenParameters
    {
        public string Token { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Id { get; set; }
    }
}

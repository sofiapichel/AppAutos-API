using ABM.AppAutos.BE.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM.AppAutosV2.BE.Authorization.Interfaces
{
    public interface ITokenService
    {
        LoginResponseDTO GenerateJwtToken(LoginResponseDTO response);
    }
}

using ABM.AppAutos.BE.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM.AppAutos.BE.Services.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponseDTO> Login(LoginRequestDTO model);
        Task<LoginResponseDTO> ActiveDirectoryAuthenticate(LoginRequestDTO model);
    }
}

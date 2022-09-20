using ABM.AppAutos.BE.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ABM.AppAutos.BE.Services.Interfaces
{
    public interface ICombustibleService
    {
        Task<CombustibleDTO> Insert(CombustibleDTO model);
        Task<CombustibleDTO> Update(CombustibleDTO model);
        Task Delete(int id);
        Task<IEnumerable<CombustibleDTO>> GetAll();
        Task<CombustibleDTO> GetById(int id);
    }
}

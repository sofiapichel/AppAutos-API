using ABM.AppAutos.BE.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ABM.AppAutos.BE.Services.Interfaces
{
    public interface ITipoService
    {
        Task<TipoDTO> Insert(TipoDTO model);
        Task<TipoDTO> Update(TipoDTO model);
        Task Delete(int id);
        Task<IEnumerable<TipoDTO>> GetAll();
        Task<TipoDTO> GetById(int id);
    }
}

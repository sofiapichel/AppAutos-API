using ABM.AppAutos.BE.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ABM.AppAutos.BE.Services.Interfaces
{
    public interface IEstadoService
    {
        Task<EstadoDTO> Insert(EstadoDTO model);
        Task<EstadoDTO> Update(EstadoDTO model);
        Task Delete(int id);
        Task<IEnumerable<EstadoDTO>> GetAll();
        Task<EstadoDTO> GetById(int id);
    }
}

using ABM.AppAutos.BE.Models.DTO;
using ABM.AppAutos.BE.Repositories.Interfaces;
using ABM.AppAutos.BE.Services.Interfaces;
using AppAutos.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ABM.AppAutos.BE.Services.Implements
{
    public class EstadoService : IEstadoService
    {

        private readonly IMapper _mapper;
        private readonly IEstadoRepository _EstadoRepository;
        public EstadoService(IMapper mapper, IEstadoRepository EstadoRepository)
        {
            _mapper = mapper;
            _EstadoRepository = EstadoRepository;
        }

        public async Task Delete(int id)
        {
            await _EstadoRepository.Delete(id);
        }

        public async Task<IEnumerable<EstadoDTO>> GetAll()
        {
            var resultado = await _EstadoRepository.GetAll();
            return _mapper.Map<IEnumerable<EstadoDTO>>(resultado);
        }

        public async Task<EstadoDTO> GetById(int id)
        {
            var resultado = await _EstadoRepository.GetById(id);
            return _mapper.Map<EstadoDTO>(resultado);
        }

        public async Task<EstadoDTO> Insert(EstadoDTO model)
        {
            var entity = _mapper.Map<Estado>(model);
            var resultado = await _EstadoRepository.Insert(entity);
            return _mapper.Map<EstadoDTO>(resultado);
        }

        public async Task<EstadoDTO> Update(EstadoDTO model)
        {
            var entity = _mapper.Map<Estado>(model);
            var resultado = await _EstadoRepository.Update(entity);
            return _mapper.Map<EstadoDTO>(resultado);
        }
    }
}

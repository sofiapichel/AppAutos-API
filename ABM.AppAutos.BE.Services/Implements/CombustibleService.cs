using ABM.AppAutos.BE.Models.DTO;
using ABM.AppAutos.BE.Repositories.Interfaces;
using ABM.AppAutos.BE.Services.Interfaces;
using AppAutos.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ABM.AppAutos.BE.Services.Implements
{
    public class CombustibleService : ICombustibleService
    {
        private readonly IMapper _mapper;
        private readonly ICombustibleRepository _CombustibleRepository;
        public CombustibleService(IMapper mapper, ICombustibleRepository CombustibleRepository)
        {
            _mapper = mapper;
            _CombustibleRepository = CombustibleRepository;
        }

        public async Task Delete(int id)
        {
            await _CombustibleRepository.Delete(id);
        }

        public async Task<IEnumerable<CombustibleDTO>> GetAll()
        {
            var resultado = await _CombustibleRepository.GetAll();
            return _mapper.Map<IEnumerable<CombustibleDTO>>(resultado);
        }

        public async Task<CombustibleDTO> GetById(int id)
        {
            var resultado = await _CombustibleRepository.GetById(id);
            return _mapper.Map<CombustibleDTO>(resultado);
        }

        public async Task<CombustibleDTO> Insert(CombustibleDTO model)
        {
            var entity = _mapper.Map<Combustible>(model);
            var resultado = await _CombustibleRepository.Insert(entity);
            return _mapper.Map<CombustibleDTO>(resultado);
        }

        public async Task<CombustibleDTO> Update(CombustibleDTO model)
        {
            var entity = _mapper.Map<Combustible>(model);
            var resultado = await _CombustibleRepository.Update(entity);
            return _mapper.Map<CombustibleDTO>(resultado);
        }
    }
}

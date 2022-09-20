using ABM.AppAutos.BE.Models.DTO;
using ABM.AppAutos.BE.Repositories.Interfaces;
using ABM.AppAutos.BE.Services.Interfaces;
using AppAutos.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ABM.AppAutos.BE.Services.Implements
{
    public class TipoService : ITipoService
    {
        private readonly IMapper _mapper;
        private readonly ITipoRepository _TipoRepository;
        public TipoService(IMapper mapper, ITipoRepository TipoRepository)
        {
            _mapper = mapper;
            _TipoRepository = TipoRepository;
        }

        public async Task Delete(int id)
        {
            await _TipoRepository.Delete(id);
        }

        public async Task<IEnumerable<TipoDTO>> GetAll()
        {
            var resultado = await _TipoRepository.GetAll();
            return _mapper.Map<IEnumerable<TipoDTO>>(resultado);
        }

        public async Task<TipoDTO> GetById(int id)
        {
            var resultado = await _TipoRepository.GetById(id);
            return _mapper.Map<TipoDTO>(resultado);
        }

        public async Task<TipoDTO> Insert(TipoDTO model)
        {
            var entity = _mapper.Map<Tipo>(model);
            var resultado = await _TipoRepository.Insert(entity);
            return _mapper.Map<TipoDTO>(resultado);
        }

        public async Task<TipoDTO> Update(TipoDTO model)
        {
            var entity = _mapper.Map<Tipo>(model);
            var resultado = await _TipoRepository.Update(entity);
            return _mapper.Map<TipoDTO>(resultado);
        }
    }
}

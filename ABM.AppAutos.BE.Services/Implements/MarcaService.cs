﻿using ABM.AppAutos.BE.Models.DTO;
using ABM.AppAutos.BE.Repositories.Interfaces;
using ABM.AppAutos.BE.Services.Interfaces;
using AppAutos.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ABM.AppAutos.BE.Services.Implements
{
    public class MarcaService : IMarcaService
    {
        private readonly IMapper _mapper;
        private readonly IMarcaRepository _MarcaRepository;
        public MarcaService(IMapper mapper, IMarcaRepository MarcaRepository)
        {
            _mapper = mapper;
            _MarcaRepository = MarcaRepository;
        }

        public async Task Delete(int id)
        {
            await _MarcaRepository.Delete(id);
        }

        public async Task<IEnumerable<MarcaDTO>> GetAll()
        {
            var resultado = await _MarcaRepository.GetAll();
            return _mapper.Map<IEnumerable<MarcaDTO>>(resultado);
        }

        public async Task<MarcaDTO> GetById(int id)
        {
            var resultado = await _MarcaRepository.GetById(id);
            return _mapper.Map<MarcaDTO>(resultado);
        }

        public async Task<MarcaDTO> Insert(MarcaDTO model)
        {
            var entity = _mapper.Map<Marca>(model);
            var resultado = await _MarcaRepository.Insert(entity);
            return _mapper.Map<MarcaDTO>(resultado);
        }

        public async Task<MarcaDTO> Update(MarcaDTO model)
        {
            var entity = _mapper.Map<Marca>(model);
            var resultado = await _MarcaRepository.Update(entity);
            return _mapper.Map<MarcaDTO>(resultado);
        }
    }
}

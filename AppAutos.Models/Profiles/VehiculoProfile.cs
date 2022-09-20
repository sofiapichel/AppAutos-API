using ABM.AppAutos.BE.Models.DTO;
using AppAutos.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM.AppAutos.BE.Models.Profiles
{
    public class VehiculoProfile : Profile
    {
        public VehiculoProfile() 
        {
            CreateMap<Vehiculo, VehiculoDTO>()
               .ForMember(destino => destino.Id, option => option.MapFrom(origen => origen.Id))
               .ForMember(destino => destino.Modelo, option => option.MapFrom(origen => origen.Modelo))
               .ForMember(destino => destino.Precio, option => option.MapFrom(origen => origen.Precio))
               .ForMember(destino => destino.Anio, option => option.MapFrom(origen => origen.Anio))
               .ForMember(destino => destino.Puertas, option => option.MapFrom(origen => origen.Puertas))
               .ForMember(destino => destino.Potencia, option => option.MapFrom(origen => origen.Potencia))
               .ForMember(destino => destino.Kilometros, option => option.MapFrom(origen => origen.Kilometros))
               .ForMember(destino => destino.MarcaId, option => option.MapFrom(origen => origen.MarcaId))
               .ForMember(destino => destino.TipoId, option => option.MapFrom(origen => origen.TipoId))
               .ForMember(destino => destino.ColorId, option => option.MapFrom(origen => origen.ColorId))
               .ForMember(destino => destino.CombustibleId, option => option.MapFrom(origen => origen.CombustibleId))
               .ForMember(destino => destino.PaisId, option => option.MapFrom(origen => origen.PaisId))
               .ForMember(destino => destino.SeguroId, option => option.MapFrom(origen => origen.SeguroId))
               .ForMember(destino => destino.EstadoId, option => option.MapFrom(origen => origen.EstadoId))          
               .ReverseMap();
        }
    }
}

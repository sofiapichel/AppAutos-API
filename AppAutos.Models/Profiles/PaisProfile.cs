using AutoMapper;
using ABM.AppAutos.BE.Models.DTO;
using AppAutos.Models;

namespace ABM.AppAutos.BE.Models.Profiles
{
    public class PaisProfile : Profile
    {
        public PaisProfile()
        {
            CreateMap<Pais, PaisDTO>()
                .ForMember(destino => destino.Id, option => option.MapFrom(origen => origen.Id))
                .ForMember(destino => destino.Nombre, option => option.MapFrom(origen => origen.Nombre))
                .ReverseMap();
        }
    }
}

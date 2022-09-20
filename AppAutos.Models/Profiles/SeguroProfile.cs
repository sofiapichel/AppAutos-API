using ABM.AppAutos.BE.Models.DTO;
using AppAutos.Models;
using AutoMapper;


namespace ABM.AppAutos.BE.Models.Profiles
{
    public class SeguroProfile : Profile
    {
        public SeguroProfile()
        {
            CreateMap<Seguro, SeguroDTO>()
                .ForMember(destino => destino.Id, option => option.MapFrom(origen => origen.Id))
                .ForMember(destino => destino.Nombre, option => option.MapFrom(origen => origen.Nombre))
                .ReverseMap();
        }
    }
}

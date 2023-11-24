using AutoMapper;
using Project.DTOLayer.ApiDTO.AboutDtos;
using Project.EntityLayer.Models;

namespace Project.WebApi.Mapping
{
    public class MapConfig : Profile
    {
        public MapConfig()
        {
            CreateMap<CreateAboutDTO, About>().ReverseMap();
        }
    }
}

using AutoMapper;
using FilmoSearch.Entities.Models;
using FilmoSearch.Shared.DataTranferObjects;

namespace FilmoSearch.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Film, FilmDto>()
                .ForMember(f => f.Id, opt => opt.MapFrom(s => s.FilmId));
        }
    }
}

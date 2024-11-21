using AutoMapper;
using FilmoSearch.Contracts;
using FilmoSearch.Serivce.Contracts;
using FilmoSearch.Shared.DataTranferObjects;

namespace FilmoSearch.Service
{
    public sealed class FilmService:IFilmService
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly ILoggerManager loggerManager;
        private readonly IMapper mapper;

        public FilmService(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper)
        {
            this.repositoryManager = repositoryManager;
            this.loggerManager = loggerManager;
            this.mapper = mapper;
        }

        public IEnumerable<FilmDto> GetAllFilms(bool trackChanges)
        {
            var films = repositoryManager.Film.GetAllFilms(trackChanges);

            var filmsDto = mapper.Map<IEnumerable<FilmDto>>(films); 

            return filmsDto; 
        }
    }
}

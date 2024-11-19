using FilmoSearch.Contracts;
using FilmoSearch.Serivce.Contracts;
using FilmoSearch.Shared.DataTranferObjects;

namespace FilmoSearch.Service
{
    public sealed class FilmService:IFilmService
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly ILoggerManager loggerManager;

        public FilmService(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
        {
            this.repositoryManager = repositoryManager;
            this.loggerManager = loggerManager;
        }

        public IEnumerable<FilmDto> GetAllFilms(bool trackChanges)
        {
            try
            {
                var film = repositoryManager.Film.GetAllFilms(trackChanges);
                var filmDto = film.Select(c => new FilmDto(c.FilmId, c.Title, c.Url, c.Country??""));
                return filmDto; 
            }
            catch(Exception ex)
            {
                loggerManager.LogError($"Something went wrong in the {nameof(GetAllFilms)} services methot {ex}");
                throw;
            }
        }
    }
}

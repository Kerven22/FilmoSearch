using FilmoSearch.Contracts;
using FilmoSearch.Serivce.Contracts;

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
    }
}

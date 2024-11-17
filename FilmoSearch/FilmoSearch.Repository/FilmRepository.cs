using FilmoSearch.Contracts;
using FilmoSearch.Entities.Models;
using FilmoSearch.Repository.Contexts;

namespace FilmoSearch.Repository
{
    public class FilmRepository:RepositoryBase<Film>, IFilmRepository
    {
        public FilmRepository(RepositoryMsSqlContext repositoryMsSqlContext):base(repositoryMsSqlContext)

        {
            
        }
    }
}

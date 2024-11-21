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

        public IEnumerable<Film> GetAllFilms(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(c => c.Title).ToList();

        public Film GetFilm(Guid filmId, bool trackChanges) =>
            FindByCondition(c => c.FilmId.Equals(filmId), trackChanges).SingleOrDefault(); 
    }
}

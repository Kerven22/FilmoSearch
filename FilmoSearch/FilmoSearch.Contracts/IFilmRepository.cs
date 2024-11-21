using FilmoSearch.Entities.Models;

namespace FilmoSearch.Contracts
{
    public interface IFilmRepository
    {
        IEnumerable<Film> GetAllFilms(bool trackChanges);

        Film GetFilm(Guid filmId, bool trackChanges); 
    }
}

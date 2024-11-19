using FilmoSearch.Shared.DataTranferObjects;

namespace FilmoSearch.Serivce.Contracts
{
    public interface IFilmService
    {
        IEnumerable<FilmDto> GetAllFilms(bool trackChanges); 
    }
}

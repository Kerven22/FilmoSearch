using Domain.ModelsDto;

namespace Domain.UseCases.FilmUseCase
{
    public interface IFilmStorage
    {
        Task<IEnumerable<FilmDto>> GetAllFilms(CancellationToken cancellationToken);

        Task<FilmDto> GetFilmByName(string title, CancellationToken cancellationToken); 
    }
}

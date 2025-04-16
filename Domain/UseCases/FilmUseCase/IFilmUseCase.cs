using Domain.ModelsDto;

namespace Domain.UseCases.FilmUseCase
{
    public interface IFilmUseCase
    {
        Task<FilmDto> GetFilmByTitle(string title, CancellationToken cancellationToken); 
    }
}

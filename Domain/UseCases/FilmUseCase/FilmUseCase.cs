using Domain.Exveptions;
using Domain.ModelsDto;


namespace Domain.UseCases.FilmUseCase
{
    public class FilmUseCase : IFilmUseCase
    {
        private readonly IFilmStorage _storage;

        public FilmUseCase(IFilmStorage storage)
        {
            _storage = storage;
        }





        public async Task<FilmDto> GetFilmByTitle(string title, CancellationToken cancellationToken)
        {
            var film = await _storage.GetFilmByName(title, cancellationToken);

            if (film is null)
                throw new FilmNotFoundExcetion(title);
            return film; 
        }
    }
}

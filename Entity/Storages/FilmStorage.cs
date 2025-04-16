using Domain.ModelsDto;
using Domain.UseCases.FilmUseCase;
using Entity.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Entity.Storages
{
    public class FilmStorage:IFilmStorage
    {
        private readonly MsDatabaseContext _msDatabaseContext; 

        public FilmStorage(MsDatabaseContext msDatabaseContext)
        {
            _msDatabaseContext = msDatabaseContext; 
        }

        public async Task<IEnumerable<FilmDto>> GetAllFilms(CancellationToken cancellationToken)
        {
            return await _msDatabaseContext.Films.Select(s => new FilmDto()
            {
                Id = s.FilmId,
                Title = s.Title,
                CreationDateDto = s.CreationDate
            }).ToArrayAsync(cancellationToken); 
        }



        public async Task<FilmDto> GetFilmByName(string title, CancellationToken cancellationToken)
        {
            var film = await _msDatabaseContext.Films.Select(f => new FilmDto
            {
                Id = f.FilmId,
                Title = f.Title,
                CreationDateDto = f.CreationDate
            }).Where(s => s.Title.Equals(title)).FirstOrDefaultAsync(cancellationToken);

            return film; 
        }
    }
}

using Domain.Exveptions;
using Domain.ModelsDto;
using Domain.UseCases.FilmUseCase;
using FluentAssertions;
using Moq;
using Moq.Language.Flow;

namespace Tests
{
    public class FilmUseCaseShould
    {
        private readonly Mock<IFilmStorage> storage;
        private readonly ISetup<IFilmStorage, Task<FilmDto>> getFilmSetup;
        private readonly FilmUseCase sut;

        public FilmUseCaseShould()
        {
            storage = new Mock<IFilmStorage>();
            getFilmSetup = storage.Setup(f => f.GetFilmByName(It.IsAny<string>(), It.IsAny<CancellationToken>())); 

            sut = new FilmUseCase(storage.Object); 
        }


        [Fact]
        public async Task ThrowNotFoundException_WhenFilmCuldntExist()
        {
            var filmTitle = "Spiderman";

            await sut.Invoking(s => s.GetFilmByTitle(filmTitle, CancellationToken.None))
                .Should().ThrowAsync<FilmNotFoundExcetion>(); 
        }
    }
}
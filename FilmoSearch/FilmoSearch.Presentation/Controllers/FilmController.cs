using FilmoSearch.Serivce.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmoSearch.Presentation.Controllers
{
    [ApiController]
    [Route("/films")]
    public class FilmController:ControllerBase
    {
        private readonly IServiceManager _service;

        public FilmController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetCompanies()
        {
            var films = _service.FilmService.GetAllFilms(trackChanges: false);
            return Ok(films); 
        }

        [HttpGet("{filmId:guid}")]
        public IActionResult GetFilm(Guid filmId)
        {
            var film = _service.FilmService.GetFilm(filmId, trackChanges: false);
            return Ok(film); 
        }
    }
}

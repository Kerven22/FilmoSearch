using Microsoft.AspNetCore.Mvc;

namespace FilmoSearch.Controllers
{
    [ApiController]
    [Route("/")]
    public class FilmController:ControllerBase
    {
        [HttpGet]
        public async Task GetFilms()
        {

        }
    }
}

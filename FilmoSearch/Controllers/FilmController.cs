using Microsoft.AspNetCore.Mvc;

namespace FilmoSearch.Controllers
{
    [ApiController]
    [Route("/")]
    public class FilmController:ControllerBase
    {
        public IActionResult GetFilms()
        {
            return Ok(); 
        }
    }
}

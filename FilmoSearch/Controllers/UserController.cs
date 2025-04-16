using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace FilmoSearch.Controllers
{
    [ApiController]
    [Route("/user")]
    public class UserController : ControllerBase
    {
        public List<User> Users = new List<User>
            {new User("Kerven", "Jumayev")};

        public async Task<IActionResult> GetUser()
        {
            return Ok(Users);
        }
    }


    public record User(string firstName, string secondName);
}

using MakeCake.API.Controllers.Models.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace MakeCake.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpPost]
        public int AddUser([FromBody] UserInputModel user)
        {
            return 0;
        }
    }
}

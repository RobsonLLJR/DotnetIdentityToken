using Microsoft.AspNetCore.Mvc;

namespace DotnetIdentityToken.Core.Controllers
{
    public class UserController : ControllerBase
    {
        [HttpGet("Registro")]
        public IActionResult Register()
        {
            return View();
        }
    }
}

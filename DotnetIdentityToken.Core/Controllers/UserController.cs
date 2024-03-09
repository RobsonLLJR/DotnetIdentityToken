using DotnetIdentityToken.Core.Models.UserModels;
using Microsoft.AspNetCore.Mvc;

namespace DotnetIdentityToken.Core.Controllers
{
    [Route("User")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public UserController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User newUser = new() { FirstName = model.FirstName, LastName = model.LastName, Surname = model.Surname, UserName = model.UserName };
                IdentityResult result = await _userManager.CreateAsync(newUser, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(newUser, isPersistent: false);
                    return RedirectToAction(nameof(Index), "Home");
                }
                foreach(var error in result.Errors) 
                {
                    ModelState.AddModelError(string.Empty, error.Description); 
                }
            }
            return View(model);
        }
    }
}

using Login_Identity.Models;
using Login_Identity.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Login_Identity.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                //nos logueamos
                var result = await _signInManager.PasswordSignInAsync(model.UserName!, model.Password!, model.RememberMe!, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                //En caso de error
                ModelState.AddModelError("", "login inválido");
                return View(model);
            }

            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }
    }
}

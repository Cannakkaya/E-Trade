using E_Trade.Data.Models.Identity;
using E_Trade.UI.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace E_Trade.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Register()
        {
            if (User.Identity.Name != null)
                return RedirectToAction("Index", "Home");
              return View();
            
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            var user = new AppUser()
            {
                Name = register.Name,
                Surname = register.Surname,
                Email = register.Email,
                UserName = register.Username

            };
            var result=await _userManager.CreateAsync(user,register.Password);
            //role creating or take
            var roleExists = await _roleManager.RoleExistsAsync("Admin");
            AppRole role;
            if (!roleExists)
            {
                //create role
                role = new AppRole("Admin");
            }
            else
            {
                //role
                role = await _roleManager.FindByNameAsync("Admin");

            }
            //submit role
            await _userManager.AddToRoleAsync(user, role.Name);
            if (result.Succeeded)
            {
                return RedirectToAction("Login");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View(register);
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

using ECommerce.Application.Models.DTOs;
using ECommerce.Application.Services.Login_Service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace ECommerce.MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            var loggedUser = await _loginService.Login(loginDTO);
            if (loggedUser != null)
            {
                var jsonUser = JsonConvert.SerializeObject(loggedUser);
                HttpContext.Session.SetString("loggedUser", jsonUser);
                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Role, loggedUser.Role.ToString()));
                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                if (loggedUser.Role == Domain.Enums.Roles.Admin)
                {
                    return RedirectToAction("Index", "Admin", new { area = "Admin" });
                }
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.Response.Cookies.Delete(CookieAuthenticationDefaults.AuthenticationScheme);
            }
            return View(loginDTO);
        }
    }
}

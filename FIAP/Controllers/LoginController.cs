using FIAP.Models;
using FIAP.Models.Repositories;
using FIAP.Models.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FIAP.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginRepository _repo;
        private readonly PasswordService _service;

        public LoginController(ILoginRepository repo, PasswordService service)
        {
            _repo = repo;
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string username, string password)
        {
            var user = _repo.GetLoginByUserName(username);

            if (user != null)
            {
                var storedPassword = password;
                var isAuthenticated = _service.ValidatePassword(password, user.SALT, user.PASSWORD);

                if (isAuthenticated)
                {
                    TempData["User"] = JsonConvert.SerializeObject(user);
                    HttpContext.Session.SetString("isAdmin", user.ADMIN.ToString());
                    return RedirectToAction("Admin","Home");
                }
            }

            return Content("");
        }
    }
}

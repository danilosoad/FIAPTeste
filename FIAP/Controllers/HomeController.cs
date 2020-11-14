using FIAP.Models;
using FIAP.Models.Data.UnityOfWork;
using FIAP.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FIAP.Models.Filters;
using Microsoft.AspNetCore.Authorization;
using X.PagedList;

namespace FIAP.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnityOfWork _uow;
        private readonly IUserRepository _repo;

        public HomeController(ILogger<HomeController> logger, IUnityOfWork uow, IUserRepository repo)
        {
            _logger = logger;
            _uow = uow;
            _repo = repo;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [CustomFilter]
        public IActionResult Admin(string keyword, int qtdRegistros = 10, int pagina = 1)
        {
            IEnumerable<UserModel> result;
            ViewBag.Keyword = keyword;

            if (keyword != null)
            {
                result = _repo.GetUsersByEmail(keyword);
            }
            else
            {
                result = _repo.GetUsers();
            }
            return View(result.ToPagedList(pagina, qtdRegistros));
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertUser(UserModel model)
        {
            try
            {
                _repo.Add(model);
                _uow.Commit();

                return Json("ok");
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        [HttpPost]
        public IActionResult RemoveUser(UserModel model)
        {
            try
            {
                _repo.Delete(model);
                _uow.Commit();
                return Json("ok");
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab21.Models;
using Lab21.Services;

namespace Lab21.Controllers
{
    public class HomeController : Controller
    {

        private readonly IHomeFacade _homeFacade;

        public HomeController(IHomeFacade homeFacade)
        {
            _homeFacade = homeFacade;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register()
        {
            var model = new RegisterViewModel();
            return View(model);
        }

        public IActionResult RegisterDetails(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ErrorMessage = "Please try again";
                return View("Register", model);
            }

            var viewModel = _homeFacade.Map(model);
            return View(viewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

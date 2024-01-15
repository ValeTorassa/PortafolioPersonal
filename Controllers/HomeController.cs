using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProyectoService proyectoService;


        public HomeController(ILogger<HomeController> logger, ProyectoService proyectoService)
        {
            _logger = logger;
            this.proyectoService = proyectoService;
        }

        public IActionResult Index()
        {

            var proyectos = proyectoService.ObtenerTodosLosProyectos();

            ViewModel viewModel = new ViewModel
            {
                Projects = proyectos
            };

            return View(viewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Controllers
{
    public class ProyectoController : Controller
    {
        private readonly ProyectoService proyectoService;

        public ProyectoController(ProyectoService proyectoService)
        {
            this.proyectoService = proyectoService;
        }


        public IActionResult VerProyectos()
        {
            var proyectos = proyectoService.ObtenerTodosLosProyectos();
            return View(proyectos);
        }

        public IActionResult Project(int projectId)
        {
            var proyecto = proyectoService.ObtenerProyectoPorId(projectId);

            if (proyecto == null)
            {
                return NotFound();
            }

            return View(proyecto);
        }

    }

}

using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Services
{
    public class ProyectoService
    {
        private readonly AppDbContext dbContext;

        public ProyectoService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // Agregar un nuevo proyecto a la base de datos
        public void AgregarProyecto(Project nuevoProyecto)
        {
            dbContext.Projects.Add(nuevoProyecto);
            dbContext.SaveChanges();
        }

        // Obtener todos los proyectos
        public List<Project> ObtenerTodosLosProyectos()
        {
            return dbContext.Projects.ToList();
        }

        // Obtener un proyecto por su identificador
        public Project ObtenerProyectoPorId(int projectId)
        {
            return dbContext.Projects.FirstOrDefault(p => p.Id == projectId);
        }
    }

}

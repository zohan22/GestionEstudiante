using EstudiantesApp.Models;
using EstudiantesApp.Services;

namespace EstudiantesApp.Controllers
{
    public class EstudianteController
    {
        private IEstudianteService estudianteService;

        public EstudianteController(IEstudianteService estudianteService)
        {
            this.estudianteService = estudianteService;
        }

        public string ObtenerEstadoDeAprobacion(Estudiante estudiante)
        {
            return estudianteService.HasApproved(estudiante) ? "Aprobado" : "Reprobado";
        }
    }
}
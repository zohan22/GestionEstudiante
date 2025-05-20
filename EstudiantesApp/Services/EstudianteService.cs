using EstudiantesApp.Models;

namespace EstudiantesApp.Services
{
    public class EstudianteService : IEstudianteService
    {
        public bool HasApproved(Estudiante estudiante)
        {
            return estudiante.Nota >= 51;
        }
    }
}
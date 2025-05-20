using EstudiantesApp.Models;

namespace EstudiantesApp.Services
{
    public interface IEstudianteService
    {
        bool HasApproved(Estudiante estudiante);
    }
}
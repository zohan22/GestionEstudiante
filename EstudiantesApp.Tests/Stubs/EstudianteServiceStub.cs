using EstudiantesApp.Models;
using EstudiantesApp.Services;

namespace EstudiantesApp.Tests.Stubs
{
    public class EstudianteServiceStub : IEstudianteService
    {
        private bool resultado;

        public EstudianteServiceStub(bool resultado)
        {
            this.resultado = resultado;
        }
        public bool HasApproved(Estudiante estudiante)
        {
            return resultado;
        }
    }
}
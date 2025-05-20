using EstudiantesApp.Controllers;
using EstudiantesApp.Models;
using EstudiantesApp.Tests.Stubs;

namespace EstudiantesApp.Tests.StubTests
{
    public class EstudianteStubTest
    {
        [Fact]
        public void Retornar_Reprobado_Con_Stub_Manual()
        {
            EstudianteServiceStub stubService = new EstudianteServiceStub(false);
            EstudianteController controller = new EstudianteController(stubService);
            Estudiante estudiante = new Estudiante { CI = 87654321, Nombre = "Carlos", Nota = 40 };

            var resultado = controller.ObtenerEstadoDeAprobacion(estudiante);

            Assert.Equal("Reprobado", resultado);
        }
    }
}
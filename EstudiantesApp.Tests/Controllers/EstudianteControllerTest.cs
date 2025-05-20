using Xunit;
using Moq;
using EstudiantesApp.Models;
using EstudiantesApp.Services;
using EstudiantesApp.Controllers;

namespace EstudiantesApp.Tests.Controllers
{
    public class EstudianteControllerTest
    {
        [Fact]
        public void Retornar_Aprobado_Cuando_Nota_Es_De_Aprobacion()
        {
            var mockService = new Mock<IEstudianteService>();
            Estudiante estudiante = new Estudiante { CI = 12345678, Nombre = "Juan", Nota = 70 };
            mockService.Setup(s => s.HasApproved(estudiante)).Returns(true);

            EstudianteController controller = new EstudianteController(mockService.Object);

            var resultado = controller.ObtenerEstadoDeAprobacion(estudiante);

            Assert.Equal("Aprobado", resultado);

        }
    }
}
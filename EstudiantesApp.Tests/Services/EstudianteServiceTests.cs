using Xunit;
using EstudiantesApp.Models;
using EstudiantesApp.Services;

namespace EstudiantesApp.Tests.Services
{
    public class EstudianteServiceTests
    {
        [Fact]
        public void Estudiante_Con_Nota_De_Aprobacion()
        {
            //Arrange
            Estudiante estudiante = new Estudiante { CI = 12345678, Nombre = "Juan", Nota = 70 };
            IEstudianteService service = new EstudianteService();
            //Act
            var resultado = service.HasApproved(estudiante);
            //Assert
            Assert.True(resultado);
        }

        [Fact]
        public void Estudiante_Con_Nota_De_Reprobacion()
        {
            //Arrange
            Estudiante estudiante = new Estudiante { CI = 87654321, Nombre = "Carlos", Nota = 40 };
            IEstudianteService service = new EstudianteService();
            //Act
            var resultado = service.HasApproved(estudiante);
            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void Estudiante_Con_Nombre_Tal_Como_Se_Escribio()
        {
            //Arrange
            var nombreEsperado = "Juan";
            Estudiante estudiante = new Estudiante { CI = 12345678, Nombre = nombreEsperado, Nota = 70 };

            //Act
            var nombreReal = estudiante.Nombre;

            //Assert
            Assert.False(string.IsNullOrWhiteSpace(nombreReal));
            Assert.Equal(nombreEsperado, estudiante.Nombre);
        }

        [Fact]
        public void Estudiante_Con_CI_Tal_Como_Se_Escribio()
        {
            //Arrange
            var ciEsperado = 12345678;
            Estudiante estudiante = new Estudiante { CI = ciEsperado, Nombre = "Juan", Nota = 70 };

            //Act
            var ciReal = estudiante.CI;

            //Assert
            Assert.True(ciReal > 0);
            Assert.Equal(12345678, estudiante.CI);
        }
    }
}
using ProyectoEmsula.DomainServices;
using ProyectoEmsula.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestTamano
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTamanoGet()
        {
            // Arrange
            var tamano = new Tamano();
            var id = new int();
            tamano = null;
            // Act
            var tamanoDomainService = new TamanoDomainService();
            var resultado = tamanoDomainService.GetTamanoDomainService(id, tamano);

            // Assert
            Assert.AreEqual("No se Encontro el Tamaño", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTamanoPut()
        {
            // Arrange
            var tamano = new Tamano();
            var id = new int();
            tamano = null;
            // Act
            var tamanoDomainService = new TamanoDomainService();
            var resultado = tamanoDomainService.PutTamanoDomainService(id, tamano);

            // Assert
            Assert.AreEqual("No se Encontro el Tamaño", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTamanoDelete()
        {
            // Arrange
            var tamano = new Tamano();
            var id = new int();
            tamano = null;
            // Act
            var tamanoDomainService = new TamanoDomainService();
            var resultado = tamanoDomainService.DeleteTamanoDomainService(id, tamano);

            // Assert
            Assert.AreEqual("No se Encontro el Tamaño", resultado);
        }

       
    }
}

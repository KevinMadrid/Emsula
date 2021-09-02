using ProyectoEmsula.DomainServices;
using ProyectoEmsula.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestCiudad
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaCiudadGet()
        {
            // Arrange
            var ciudad = new Ciudad();
            var id = new int();
            ciudad = null;
            // Act
            var ciudadDomainService= new CiudadDomainService();
            var resultado = ciudadDomainService.GetCiudadDomainService(id, ciudad);

            // Assert
            Assert.AreEqual("No se Encontro la Ciudad", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaCiudadPut()
        {
            // Arrange
            var ciudad = new Ciudad();
            var id = new int();
            ciudad = null;
            // Act
            var ciudadDomainService = new CiudadDomainService();
            var resultado = ciudadDomainService.PutCiudadDomainService(id, ciudad);

            // Assert
            Assert.AreEqual("No se Encontro la Ciudad", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaCiudadDelete()
        {
            // Arrange
            var ciudad = new Ciudad();
            var id = new int();
            ciudad = null;
            // Act
            var ciudadDomainService = new CiudadDomainService();
            var resultado = ciudadDomainService.DeleteCiudadDomainService(id, ciudad);

            // Assert
            Assert.AreEqual("No se Encontro la Ciudad", resultado);
        }

       
    }
}

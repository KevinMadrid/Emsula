using ProyectoEmsula.DomainServices;
using ProyectoEmsula.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestCanal
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnCanalGet()
        {
            // Arrange
            var canal = new Canal();
            var id = new int();
            canal = null;
            // Act
            var canalDomainService= new CanalDomainService();
            var resultado = canalDomainService.GetCanalDomainService(id, canal);

            // Assert
            Assert.AreEqual("No se Encontro el Canal", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnCanalPut()
        {
            // Arrange
            var canal = new Canal();
            var id = new int();
            canal = null;
            // Act
            var canalDomainService = new CanalDomainService();
            var resultado = canalDomainService.PutCanalDomainService(id, canal);

            // Assert
            Assert.AreEqual("No se Encontro el Canal", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnCanalDelete()
        {
            // Arrange
            var canal = new Canal();
            var id = new int();
            canal = null;
            // Act
            var canalDomainService = new CanalDomainService();
            var resultado = canalDomainService.DeleteCanalDomainService(id, canal);

            // Assert
            Assert.AreEqual("No se Encontro el Canal", resultado);
        }

       
    }
}

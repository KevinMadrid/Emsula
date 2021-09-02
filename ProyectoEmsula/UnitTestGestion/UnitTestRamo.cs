using ProyectoEmsula.DomainServices;
using ProyectoEmsula.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestRamo
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnRamoGet()
        {
            // Arrange
            var ramo = new Ramo();
            var id = new int();
            ramo = null;
            // Act
            var ramoDomainService= new RamoDomainService();
            var resultado = ramoDomainService.GetRamoDomainService(id, ramo);

            // Assert
            Assert.AreEqual("No se Encontro el Ramo", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnRamoPut()
        {
            // Arrange
            var ramo = new Ramo();
            var id = new int();
            ramo = null;
            // Act
            var ramoDomainService = new RamoDomainService();
            var resultado = ramoDomainService.PutRamoDomainService(id, ramo);

            // Assert
            Assert.AreEqual("No se Encontro el Ramo", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnRamoDelete()
        {
            // Arrange
            var ramo = new Ramo();
            var id = new int();
            ramo = null;
            // Act
            var ramoDomainService = new RamoDomainService();
            var resultado = ramoDomainService.DeleteRamoDomainService(id, ramo);

            // Assert
            Assert.AreEqual("No se Encontro el Ramo", resultado);
        }

       
    }
}

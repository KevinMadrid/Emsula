using ProyectoEmsula.DomainServices;
using ProyectoEmsula.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestTerritorio
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTerritorioGet()
        {
            // Arrange
            var territorio = new Territorio();
            var id = new int();
            territorio = null;
            // Act
            var territorioDomainService = new TerritorioDomainService();
            var resultado = territorioDomainService.GetTerritorioDomainService(id, territorio);

            // Assert
            Assert.AreEqual("No se Encontro el Territorio", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTerritorioPut()
        {
            // Arrange
            var territorio = new Territorio();
            var id = new int();
            territorio = null;
            // Act
            var territorioDomainService = new TerritorioDomainService();
            var resultado = territorioDomainService.PutTerritorioDomainService(id, territorio);

            // Assert
            Assert.AreEqual("No se Encontro el Territorio", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTerritorioDelete()
        {
            // Arrange
            var territorio = new Territorio();
            var id = new int();
            territorio = null;
            // Act
            var territorioDomainService = new TerritorioDomainService();
            var resultado = territorioDomainService.DeleteTerritorioDomainService(id, territorio);

            // Assert
            Assert.AreEqual("No se Encontro el Territorio", resultado);
        }

       
    }
}

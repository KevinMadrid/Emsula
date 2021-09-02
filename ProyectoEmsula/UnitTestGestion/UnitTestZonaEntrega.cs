using ProyectoEmsula.DomainServices;
using ProyectoEmsula.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestZonaEntrega
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaZonaEntregaGet()
        {
            // Arrange
            var zonaEntrega = new ZonaEntrega();
            var id = new int();
            zonaEntrega = null;
            // Act
            var zonaEntregaDomainService= new ZonaEntregaDomainService();
            var resultado = zonaEntregaDomainService.GetZonaEntregaDomainService(id, zonaEntrega);

            // Assert
            Assert.AreEqual("No se Encontro la Zona de Entrega", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaZonaEntregaPut()
        {
            // Arrange
            var zonaEntrega = new ZonaEntrega();
            var id = new int();
            zonaEntrega = null;
            // Act
            var zonaEntregaDomainService = new ZonaEntregaDomainService();
            var resultado = zonaEntregaDomainService.PutZonaEntregaDomainService(id, zonaEntrega);

            // Assert
            Assert.AreEqual("No se Encontro la Zona de Entrega", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaZonaEntregaDelete()
        {
            // Arrange
            var zonaEntrega = new ZonaEntrega();
            var id = new int();
            zonaEntrega = null;
            // Act
            var zonaEntregaDomainService = new ZonaEntregaDomainService();
            var resultado = zonaEntregaDomainService.DeleteZonaEntregaDomainService(id, zonaEntrega);

            // Assert
            Assert.AreEqual("No se Encontro la Zona de Entrega", resultado);
        }

       
    }
}

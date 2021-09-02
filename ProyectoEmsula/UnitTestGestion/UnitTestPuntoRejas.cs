using ProyectoEmsula.DomainServices;
using ProyectoEmsula.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestPuntoRejas

    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnPuntoRejasGet()
        {
            // Arrange
            var puntoRejas = new PuntoRejas();
            var id = new int();
            puntoRejas = null;
            // Act
            var puntoRejasDomainService= new PuntoRejasDomainService();
            var resultado = puntoRejasDomainService.GetPuntoRejasDomainService(id, puntoRejas);

            // Assert
            Assert.AreEqual("No se Encontro el Punto con Rejas", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnPuntoRejasPut()
        {
            // Arrange
            var puntoRejas = new PuntoRejas();
            var id = new int();
            puntoRejas = null;
            // Act
            var puntoRejasDomainService = new PuntoRejasDomainService();
            var resultado = puntoRejasDomainService.PutPuntoRejasDomainService(id, puntoRejas);

            // Assert
            Assert.AreEqual("No se Encontro el Punto con Rejas", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnPuntoRejasDelete()
        {
            // Arrange
            var puntoRejas = new PuntoRejas();
            var id = new int();
            puntoRejas = null;
            // Act
            var puntoRejasDomainService = new PuntoRejasDomainService();
            var resultado = puntoRejasDomainService.DeletePuntoRejasDomainService(id, puntoRejas);

            // Assert
            Assert.AreEqual("No se Encontro el Punto con Rejas", resultado);
        }

       
    }
}

using ProyectoEmsula.DomainServices;
using ProyectoEmsula.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestPuntoPos
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnPuntoPosGet()
        {
            // Arrange
            var puntoPos = new PuntoPos();
            var id = new int();
            puntoPos = null;
            // Act
            var puntoPosDomainService= new PuntoPosDomainService();
            var resultado = puntoPosDomainService.GetPuntoPosDomainService(id, puntoPos);

            // Assert
            Assert.AreEqual("No se Encontro el Punto Pos", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnPuntoPosPut()
        {
            // Arrange
            var puntoPos = new PuntoPos();
            var id = new int();
            puntoPos = null;
            // Act
            var puntoPosDomainService = new PuntoPosDomainService();
            var resultado = puntoPosDomainService.PutPuntoPosDomainService(id, puntoPos);


            // Assert
            Assert.AreEqual("No se Encontro el Punto Pos", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnPuntoPosDelete()
        {
            // Arrange
            var puntoPos = new PuntoPos();
            var id = new int();
            puntoPos = null;
            // Act
            var puntoPosDomainService = new PuntoPosDomainService();
            var resultado = puntoPosDomainService.DeletePuntoPosDomainService(id, puntoPos);

            // Assert
            Assert.AreEqual("No se Encontro el Punto Pos", resultado);
        }

       
    }
}

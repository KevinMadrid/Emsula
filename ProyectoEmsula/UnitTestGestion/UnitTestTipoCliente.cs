using ProyectoEmsula.DomainServices;
using ProyectoEmsula.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestTipoCliente
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTipoClienteGet()
        {
            // Arrange
            var tipoCliente = new TipoCliente();
            var id = new int();
            tipoCliente = null;
            // Act
            var tipoClienteDomainService = new TipoClienteDomainService();
            var resultado = tipoClienteDomainService.GetTipoTipoClienteDomainService(id, tipoCliente);

            // Assert
            Assert.AreEqual("No se Encontro el Tipo de Cliente", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTipoClientePut()
        {
            // Arrange
            var tipoCliente = new TipoCliente();
            var id = new int();
            tipoCliente = null;
            // Act
            var tipoClienteDomainService = new TipoClienteDomainService();
            var resultado = tipoClienteDomainService.PutTipoClienteDomainService(id, tipoCliente);

            // Assert
            Assert.AreEqual("No se Encontro el Tipo de Cliente", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTipoClienteDelete()
        {
            // Arrange
            var tipoCliente = new TipoCliente();
            var id = new int();
            tipoCliente = null;
            // Act
            var tipoClienteDomainService = new TipoClienteDomainService();
            var resultado = tipoClienteDomainService.DeleteTipoClienteDomainService(id, tipoCliente);

            // Assert
            Assert.AreEqual("No se Encontro el Tipo de Cliente", resultado);
        }

       
    }
}

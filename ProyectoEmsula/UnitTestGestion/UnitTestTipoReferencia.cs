using ProyectoEmsula.DomainServices;
using ProyectoEmsula.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestTipoReferencia
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTipoReferenciaGet()
        {
            // Arrange
            var tipoReferencia = new TipoReferencia();
            var id = new int();
            tipoReferencia = null;
            // Act
            var tipoReferenciaDomainService = new TipoReferenciaDomainService();
            var resultado = tipoReferenciaDomainService.GetTipoReferenciaDomainService(id, tipoReferencia);

            // Assert
            Assert.AreEqual("No se Encontro el Tipo de Referencia", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTipoReferenciaPut()
        {
            // Arrange
            var tipoReferencia = new TipoReferencia();
            var id = new int();
            tipoReferencia = null;
            // Act
            var tipoReferenciaDomainService = new TipoReferenciaDomainService();
            var resultado = tipoReferenciaDomainService.PutTipoReferenciaDomainService(id, tipoReferencia);

            // Assert
            Assert.AreEqual("No se Encontro el Tipo de Referencia", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTipoReferenciaDelete()
        {
            // Arrange
            var tipoReferencia = new TipoReferencia();
            var id = new int();
            tipoReferencia = null;
            // Act
            var tipoReferenciaDomainService = new TipoReferenciaDomainService();
            var resultado = tipoReferenciaDomainService.DeleteTipoReferenciaDomainService(id, tipoReferencia);

            // Assert
            Assert.AreEqual("No se Encontro el Tipo de Referencia", resultado);
        }

       
    }
}

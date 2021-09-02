using ProyectoEmsula.DomainServices;
using ProyectoEmsula.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestFormaAtencion
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaFormaAtencionGet()
        {
            // Arrange
            var formaAtencion= new FormaAtencion();
            var id = new int();
            formaAtencion = null;
            // Act
            var formaAtencionDomainService= new FormaAtencionDomainService();
            var resultado = formaAtencionDomainService.GetFormaAtencionDomainService(id, formaAtencion);

            // Assert
            Assert.AreEqual("No se Encontro el Forma de Atencion", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaFormaAtencionPut()
        {
            // Arrange
            var formaAtencion = new FormaAtencion();
            var id = new int();
            formaAtencion = null;
            // Act
            var formaAtencionDomainService = new FormaAtencionDomainService();
            var resultado = formaAtencionDomainService.PutFormaAtencionDomainService(id, formaAtencion);

            // Assert
            Assert.AreEqual("No se Encontro el Forma de Atencion", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaFormaAtencionDelete()
        {
            // Arrange
            var formaAtencion = new FormaAtencion();
            var id = new int();
            formaAtencion = null;
            // Act
            var formaAtencionDomainService = new FormaAtencionDomainService();
            var resultado = formaAtencionDomainService.DeleteFormaAtencionDomainService(id, formaAtencion);

            // Assert
            Assert.AreEqual("No se Encontro el Forma de Atencion", resultado);
        }

       
    }
}

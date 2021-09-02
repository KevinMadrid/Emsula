using ProyectoEmsula.DomainServices;
using ProyectoEmsula.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestSegmentacion
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaSegmentacionGet()
        {
            // Arrange
            var segmentacion= new Segmentacion();
            var id = new int();
            segmentacion = null;
            // Act
            var segmentacionDomainService= new SegmentacionDomainService();
            var resultado = segmentacionDomainService.GetSegmentacionDomainService(id, segmentacion);

            // Assert
            Assert.AreEqual("No se Encontro el Segmentacion", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaSegmentacionPut()
        {
            // Arrange
            var segmentacion = new Segmentacion();
            var id = new int();
            segmentacion = null;
            // Act
            var segmentacionDomainService = new SegmentacionDomainService();
            var resultado = segmentacionDomainService.PutSegmentacionDomainService(id, segmentacion);

            // Assert
            Assert.AreEqual("No se Encontro el Segmentacion", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaSegmentacionDelete()
        {
            // Arrange
            var segmentacion = new Segmentacion();
            var id = new int();
            segmentacion = null;
            // Act
            var segmentacionDomainService = new SegmentacionDomainService();
            var resultado = segmentacionDomainService.DeleteSegmentacionDomainService(id, segmentacion);

            // Assert
            Assert.AreEqual("No se Encontro el Segmentacion", resultado);
        }

       
    }
}

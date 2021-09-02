using ProyectoEmsula.DomainServices;
using ProyectoEmsula.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestSegmento
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnSegmentoGet()
        {
            // Arrange
            var segmento = new Segmento();
            var id = new int();
            segmento = null;
            // Act
            var segmentoDomainService = new SegmentoDomainService();
            var resultado = segmentoDomainService.GetSegmentoDomainService(id, segmento);

            // Assert
            Assert.AreEqual("No se Encontro el Segmento", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnSegmentoPut()
        {
            // Arrange
            var segmento = new Segmento();
            var id = new int();
            segmento = null;
            // Act
            var segmentoDomainService = new SegmentoDomainService();
            var resultado = segmentoDomainService.PutSegmentoDomainService(id, segmento);

            // Assert
            Assert.AreEqual("No se Encontro el Segmento", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnSegmentoDelete()
        {
            // Arrange
            var segmento = new Segmento();
            var id = new int();
            segmento = null;
            // Act
            var segmentoDomainService = new SegmentoDomainService();
            var resultado = segmentoDomainService.DeleteSegmentoDomainService(id, segmento);

            // Assert
            Assert.AreEqual("No se Encontro el Segmento", resultado);
        }

       
    }
}

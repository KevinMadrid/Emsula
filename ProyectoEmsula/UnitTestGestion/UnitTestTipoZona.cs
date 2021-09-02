using ProyectoEmsula.DomainServices;
using ProyectoEmsula.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestTipoZona
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTipoZonaGet()
        {
            // Arrange
            var tipoZona = new TipoZona();
            var id = new int();
            tipoZona = null;
            // Act
            var tipoZonaDomainService= new TipoZonaDomainService();
            var resultado = tipoZonaDomainService.GetTipoZonaDomainService(id, tipoZona);

            // Assert
            Assert.AreEqual("No se Encontro el Tipo de Zona", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTipoZonaPut()
        {
            // Arrange
            var tipoZona = new TipoZona();
            var id = new int();
            tipoZona = null;
            // Act
            var tipoZonaDomainService = new TipoZonaDomainService();
            var resultado = tipoZonaDomainService.PutTipoZonaDomainService(id, tipoZona);

            // Assert
            Assert.AreEqual("No se Encontro el Tipo de Zona", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTipoZonaDelete()
        {
            // Arrange
            var tipoZona = new TipoZona();
            var id = new int();
            tipoZona = null;
            // Act
            var tipoZonaDomainService = new TipoZonaDomainService();
            var resultado = tipoZonaDomainService.DeleteTipoZonaDomainService(id, tipoZona);

            // Assert
            Assert.AreEqual("No se Encontro el Tipo de Zona", resultado);
        }

       
    }
}

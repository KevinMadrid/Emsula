using ProyectoEmsula.DomainServices;
using ProyectoEmsula.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestCaracteristicaZona
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaCaracteristicaZonaGet()
        {
            // Arrange
            var caracteristicaZona = new CaracteristicaZona();
            var id = new int();
            caracteristicaZona= null;
            // Act
            var caracteristicaZonaDomainService= new CaracteristicaZonaDomainService();
            var resultado = caracteristicaZonaDomainService.GetCaracteristicaZonaDomainService(id, caracteristicaZona);

            // Assert
            Assert.AreEqual("No se Encontro la Caracteristica de la Zona", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaCaracteristicaZonaPut()
        {
            // Arrange
            var caracteristicaZona = new CaracteristicaZona();
            var id = new int();
            caracteristicaZona = null;
            // Act
            var caracteristicaZonaDomainService = new CaracteristicaZonaDomainService();
            var resultado = caracteristicaZonaDomainService.PutCaracteristicaZonaDomainService(id, caracteristicaZona);

            // Assert
            Assert.AreEqual("No se Encontro la Caracteristica de la Zona", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaCaracteristicaZonaDelete()
        {
            // Arrange
            var caracteristicaZona = new CaracteristicaZona();
            var id = new int();
            caracteristicaZona = null;
            // Act
            var caracteristicaZonaDomainService= new CaracteristicaZonaDomainService();
            var resultado = caracteristicaZonaDomainService.DeleteCaracteristicaZonaDomainService(id, caracteristicaZona);

            // Assert
            Assert.AreEqual("No se Encontro la Caracteristica de la Zona", resultado);
        }

       
    }
}

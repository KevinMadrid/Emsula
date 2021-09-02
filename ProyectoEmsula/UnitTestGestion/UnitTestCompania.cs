using ProyectoEmsula.DomainServices;
using ProyectoEmsula.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestCompania
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaCompaniaGet()
        {
            // Arrange
            var compania = new Compania();
            var id = new int();
            compania = null;
            // Act
            var companiaDomainService= new CompaniaDomainService();
            var resultado = companiaDomainService.GetCompaniaDomainService(id, compania);

            // Assert
            Assert.AreEqual("No se Encontro la Compañia", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaCompaniaPut()
        {
            // Arrange
            var compania = new Compania();
            var id = new int();
            compania = null;
            // Act
            var companiaDomainService = new CompaniaDomainService();
            var resultado = companiaDomainService.PutCompaniaDomainService(id, compania);

            // Assert
            Assert.AreEqual("No se Encontro la Compañia", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaCompaniaDelete()
        {
            // Arrange
            var compania = new Compania();
            var id = new int();
            compania = null;
            // Act
            var companiaDomainService = new CompaniaDomainService();
            var resultado = companiaDomainService.DeleteCompaniaDomainService(id, compania);

            // Assert
            Assert.AreEqual("No se Encontro la Compañia", resultado);
        }

       
    }
}

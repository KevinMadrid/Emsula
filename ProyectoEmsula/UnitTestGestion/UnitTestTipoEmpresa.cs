using ProyectoEmsula.DomainServices;
using ProyectoEmsula.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestTipoEmpresa
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTipoEmpresaGet()
        {
            // Arrange
            var tipoEmpresa = new TipoEmpresa();
            var id = new int();
            tipoEmpresa = null;
            // Act
            var tipoEmpresaDomainService = new TipoEmpresaDomainService();
            var resultado = tipoEmpresaDomainService.GetTipoEmpresaDomainService(id, tipoEmpresa);

            // Assert
            Assert.AreEqual("No se Encontro el Tipo de Empresa", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTipoEmpresaPut()
        {
            // Arrange
            var tipoEmpresa = new TipoEmpresa();
            var id = new int();
            tipoEmpresa = null;
            // Act
            var tipoEmpresaDomainService = new TipoEmpresaDomainService();
            var resultado = tipoEmpresaDomainService.PutTipoEmpresaDomainService(id, tipoEmpresa);

            // Assert
            Assert.AreEqual("No se Encontro el Tipo de Empresa", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTipoEmpresaDelete()
        {
            // Arrange
            var tipoEmpresa = new TipoEmpresa();
            var id = new int();
            tipoEmpresa = null;
            // Act
            var tipoEmpresaDomainService = new TipoEmpresaDomainService();
            var resultado = tipoEmpresaDomainService.DeleteTipoEmpresaDomainService(id, tipoEmpresa);

            // Assert
            Assert.AreEqual("No se Encontro el Tipo de Empresa", resultado);
        }

       
    }
}

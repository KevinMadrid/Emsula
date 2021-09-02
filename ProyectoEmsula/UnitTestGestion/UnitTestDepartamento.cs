using ProyectoEmsula.DomainServices;
using ProyectoEmsula.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestDepartamento
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnDepartamentoGet()
        {
            // Arrange
            var departamento = new Departamento();
            var id = new int();
            departamento = null;
            // Act
            var departamentoDomainService= new DepartamentoDomainService();
            var resultado = departamentoDomainService.GetDepartamentoDomainService(id, departamento);

            // Assert
            Assert.AreEqual("No se Encontro el Departamento", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnDepartamentoPut()
        {
            // Arrange
            var departamento = new Departamento();
            var id = new int();
            departamento = null;
            // Act
            var departamentoDomainService = new DepartamentoDomainService();
            var resultado = departamentoDomainService.PutDepartamentoDomainService(id, departamento);

            // Assert
            Assert.AreEqual("No se Encontro el Departamento", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnDepartamentoDelete()
        {
            // Arrange
            var departamento = new Departamento();
            var id = new int();
            departamento = null;
            // Act
            var departamentoDomainService = new DepartamentoDomainService();
            var resultado = departamentoDomainService.DeleteDepartamentoDomainService(id, departamento);

            // Assert
            Assert.AreEqual("No se Encontro el Departamento", resultado);
        }

       
    }
}

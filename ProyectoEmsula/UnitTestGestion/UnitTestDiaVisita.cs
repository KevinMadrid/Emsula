using ProyectoEmsula.DomainServices;
using ProyectoEmsula.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestDiaVisita
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnDiaVisitaGet()
        {
            // Arrange
            var diaVisita = new DiaVisita();
            var id = new int();
            diaVisita = null;
            // Act
            var diaVisitaDomainService= new DiaVisitaDomainService();
            var resultado = diaVisitaDomainService.GetDiaVisitaDomainService(id, diaVisita);

            // Assert
            Assert.AreEqual("No se Encontro el Dia de Visita", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnDiaVisitaPut()
        {
            // Arrange
            var diaVisita = new DiaVisita();
            var id = new int();
            diaVisita = null;
            // Act
            var diaVisitaDomainService = new DiaVisitaDomainService();
            var resultado = diaVisitaDomainService.PutDiaVisitaDomainService(id, diaVisita);

            // Assert
            Assert.AreEqual("No se Encontro el Dia de Visita", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnDiaVisitaDelete()
        {
            // Arrange
            var diaVisita = new DiaVisita();
            var id = new int();
            diaVisita = null;
            // Act
            var diaVisitaDomainService = new DiaVisitaDomainService();
            var resultado = diaVisitaDomainService.DeleteDiaVisitaDomainService(id, diaVisita);

            // Assert
            Assert.AreEqual("No se Encontro el Dia de Visita", resultado);
        }

       
    }
}

using ProyectoEmsula.DomainService;
using ProyectoEmsula.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestGestion
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaGestionGet()
        {
            // Arrange
            var gestion= new Gestion();
            var id = new int();
            gestion = null;
            // Act
            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.GetGestionDomainService(id, gestion);

            // Assert
            Assert.AreEqual("No se Encuentra la Gestion", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnCanalPost()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion= new Segmentacion();
            var segmento= new Segmento();
            var tamano= new Tamano();
            var territorio= new Territorio();
            var tipoCliente= new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia= new TipoReferencia();
            var tipoZona= new TipoZona();
            var zonaEntrega= new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            canal = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania,departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona,zonaEntrega,gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PostGestionDomainService(ajuste);

            // Assert
            Assert.AreEqual("No se encontro el Canal", resultado);
        }

       
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaCaracteristicaZonaPost()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            caracteristicaZona = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega,gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PostGestionDomainService(ajuste);

            // Assert
            Assert.AreEqual("La Caracteristica de esta zona no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnCiudadPost()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            ciudad = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega,gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PostGestionDomainService(ajuste);

            // Assert
            Assert.AreEqual("La Ciudad no existe", resultado);
        }


        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaCompaniaPost()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            compania = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega,gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PostGestionDomainService(ajuste);

            // Assert
            Assert.AreEqual("La Compañia no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnDepartamentoPost()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            departamento = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega,gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PostGestionDomainService(ajuste);

            // Assert
            Assert.AreEqual("No se encontro el Departamento", resultado);
        }


        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaDiaVisitaPost()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            diaVisita = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega,gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PostGestionDomainService(ajuste);

            // Assert
            Assert.AreEqual("No se encontro el dia de visita", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnFormaAtencioPost()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            formaAtencion = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega,gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PostGestionDomainService(ajuste);

            // Assert
            Assert.AreEqual("La Forma de Atencion no existe", resultado);
        }


        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaPuntoPosPost()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            puntoPos = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega,gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PostGestionDomainService(ajuste);

            // Assert
            Assert.AreEqual("El Punto Pos no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnPUntoRejasPost()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            puntoRejas = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega,gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PostGestionDomainService(ajuste);

            // Assert
            Assert.AreEqual("El Punto con Reja no existe", resultado);
        }


        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnRamoPost()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            ramo = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega,gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PostGestionDomainService(ajuste);

            // Assert
            Assert.AreEqual("El Ramo no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaSegmentacionPost()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            segmentacion = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega,gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PostGestionDomainService(ajuste);

            // Assert
            Assert.AreEqual("La Segmantacion no existe", resultado);
        }


        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnSegmentoPost()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            segmento = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega,gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PostGestionDomainService(ajuste);

            // Assert
            Assert.AreEqual("El Segmento no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTamanoPost()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            tamano = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega,gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PostGestionDomainService(ajuste);

            // Assert
            Assert.AreEqual("El tamaño del negocio no existe", resultado);
        }


        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTerritorioPost()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            territorio = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega,gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PostGestionDomainService(ajuste);

            // Assert
            Assert.AreEqual("El territorio no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTipoClientePost()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            tipoCliente = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega,gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PostGestionDomainService(ajuste);

            // Assert
            Assert.AreEqual("El Tipo de Cliente Contable no existe", resultado);
        }


        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTipoEmpresaPost()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            tipoEmpresa = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega,gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PostGestionDomainService(ajuste);

            // Assert
            Assert.AreEqual("El Tipo de Empresa no existe", resultado);
        }



        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTipoReferenciaPost()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            tipoReferencia = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega,gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PostGestionDomainService(ajuste);

            // Assert
            Assert.AreEqual("El Tipo de Referencia no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTipoZonaPost()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            tipoZona = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega,gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PostGestionDomainService(ajuste);

            // Assert
            Assert.AreEqual("El Tipo de Zona no existe", resultado);
        }


        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaZonaEntregaPost()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            zonaEntrega = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega,gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PostGestionDomainService(ajuste);

            // Assert
            Assert.AreEqual("La Zona de Entrega no existe", resultado);
        }
        
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaGestionPut()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            gestion = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega,gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PutGestionDomainService(id, ajuste);

            // Assert
            Assert.AreEqual("No se Encontro la Gestion", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnCanalPut()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            canal = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega, gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PutGestionDomainService(id,ajuste);

            // Assert
            Assert.AreEqual("No se encontro el Canal", resultado);
        }


        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaCaracteristicaZonaPut()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            caracteristicaZona = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega, gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PutGestionDomainService(id,ajuste);

            // Assert
            Assert.AreEqual("La Caracteristica de esta zona no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnCiudadPut()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            ciudad = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega, gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PutGestionDomainService(id,ajuste);

            // Assert
            Assert.AreEqual("La Ciudad no existe", resultado);
        }


        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaCompaniaPut()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            compania = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega, gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PutGestionDomainService(id,ajuste);

            // Assert
            Assert.AreEqual("La Compañia no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnDepartamentoPut()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            departamento = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega, gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PutGestionDomainService(id,ajuste);

            // Assert
            Assert.AreEqual("No se encontro el Departamento", resultado);
        }


        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaDiaVisitaPut()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            diaVisita = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega, gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PutGestionDomainService(id,ajuste);

            // Assert
            Assert.AreEqual("No se encontro el dia de visita", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnFormaAtencioPut()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            formaAtencion = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega, gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PutGestionDomainService(id,ajuste);

            // Assert
            Assert.AreEqual("La Forma de Atencion no existe", resultado);
        }


        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaPuntoPosPut()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            puntoPos = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega, gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PutGestionDomainService(id,ajuste);

            // Assert
            Assert.AreEqual("El Punto Pos no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnPUntoRejasPut()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            puntoRejas = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega, gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PutGestionDomainService(id,ajuste);

            // Assert
            Assert.AreEqual("El Punto con Reja no existe", resultado);
        }


        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnRamoPut()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            ramo = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega, gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PutGestionDomainService(id,ajuste);

            // Assert
            Assert.AreEqual("El Ramo no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaSegmentacionPut()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            segmentacion = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega, gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PutGestionDomainService(id,ajuste);

            // Assert
            Assert.AreEqual("La Segmantacion no existe", resultado);
        }


        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnSegmentoPut()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            segmento = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega, gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PutGestionDomainService(id,ajuste);

            // Assert
            Assert.AreEqual("El Segmento no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTamanoPut()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            tamano = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega, gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PutGestionDomainService(id,ajuste);

            // Assert
            Assert.AreEqual("El tamaño del negocio no existe", resultado);
        }


        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTerritorioPut()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            territorio = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega, gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PutGestionDomainService(id,ajuste);

            // Assert
            Assert.AreEqual("El territorio no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTipoClientePut()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            tipoCliente = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega, gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PutGestionDomainService(id,ajuste);

            // Assert
            Assert.AreEqual("El Tipo de Cliente Contable no existe", resultado);
        }


        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTipoEmpresaPut()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            tipoEmpresa = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega, gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PutGestionDomainService(id,ajuste);

            // Assert
            Assert.AreEqual("El Tipo de Empresa no existe", resultado);
        }



        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTipoReferenciaPut()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            tipoReferencia = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega, gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PutGestionDomainService(id,ajuste);

            // Assert
            Assert.AreEqual("El Tipo de Referencia no existe", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnTipoZonaPut()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            tipoZona = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega, gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PutGestionDomainService(id,ajuste);

            // Assert
            Assert.AreEqual("El Tipo de Zona no existe", resultado);
        }


        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaZonaEntregaPut()
        {
            // Arrange
            var canal = new Canal();
            var caracteristicaZona = new CaracteristicaZona();
            var ciudad = new Ciudad();
            var compania = new Compania();
            var departamento = new Departamento();
            var diaVisita = new DiaVisita();
            var formaAtencion = new FormaAtencion();
            var puntoPos = new PuntoPos();
            var puntoRejas = new PuntoRejas();
            var ramo = new Ramo();
            var segmentacion = new Segmentacion();
            var segmento = new Segmento();
            var tamano = new Tamano();
            var territorio = new Territorio();
            var tipoCliente = new TipoCliente();
            var tipoEmpresa = new TipoEmpresa();
            var tipoReferencia = new TipoReferencia();
            var tipoZona = new TipoZona();
            var zonaEntrega = new ZonaEntrega();
            var gestion = new Gestion();
            var id = new int();
            zonaEntrega = null;
            var ajuste = new Ajuste(canal, caracteristicaZona, ciudad, compania, departamento, diaVisita, formaAtencion,
                      puntoPos, puntoRejas, ramo, segmentacion, segmento,
                      tamano, territorio, tipoCliente, tipoEmpresa, tipoReferencia,
                      tipoZona, zonaEntrega, gestion);

            // Act

            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.PutGestionDomainService(id,ajuste);

            // Assert
            Assert.AreEqual("La Zona de Entrega no existe", resultado);
        }
        public void PruebaParaValidarQueSeEncuentraUnaGestionDelete()
        {
            // Arrange
            var gestion = new Gestion();
            var id = new int();
            gestion = null;
            // Act
            var gestionDomainService = new GestionDomainService();
            var resultado = gestionDomainService.DeletetGestionDomainService(id, gestion);

            //  Assert
            Assert.AreEqual("No se Encuentra la Gestion", resultado);
        }

    }
    }

﻿using Dominio.Entidades;
using Dominio.Enumeraciones;
using Dominio.Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using static Dominio.Enumeraciones.PedidosResult;

namespace Dominio.Test.CU_MPE_03
{
    /// <summary>
    /// Descripción resumida de RegistrarEntrega
    /// </summary>
    [TestClass]
    public class RegistrarEntrega
    {
        public RegistrarEntrega()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ObtenerEstatusTest()
        {
            EstatusPedidoController controller = new EstatusPedidoController();
             Assert.IsNotNull(controller.ObtenerEstatusPedido());
        }

        [TestMethod]
        public void ActualizarEstatus()
        {
            PedidoController controller = new PedidoController();
            EstatusPedidoController controller2 = new EstatusPedidoController();
            List<Tipo> estatus = controller2.ObtenerEstatusPedido();
            List<Pedido> lista = controller.ObtenerPedidos();

            Pedido PedidoEditar = lista.Find(x => x.Id == 20);
            PedidoEditar.Estatus = estatus.Find(x => x.Id == 4);
            Assert.AreEqual(ResultsPedidos.ActualizadoConExito, controller.ActualizarPedidoArticulos(PedidoEditar));
        }

    }
}

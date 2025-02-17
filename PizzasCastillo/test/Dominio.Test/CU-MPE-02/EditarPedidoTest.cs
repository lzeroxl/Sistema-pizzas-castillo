﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Logica;
using Dominio.Entidades;
using static Presentacion.Recursos.PedidosResults;

namespace Dominio.Test.CU_MPE_02
{
    /// <summary>
    /// Descripción resumida de EditarPedidoTest
    /// </summary>
    [TestClass]
    public class EditarPedidoTest
    {
        public EditarPedidoTest()
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
        public void ObtenerPedidosTest()
        {
            Dominio.Logica.PedidoController controller = new Dominio.Logica.PedidoController();
            Assert.IsNotNull(controller.ObtenerPedidos());
        }

        [TestMethod]
        public void ObtenerPedidosNombreTest()
        {
            Dominio.Logica.PedidoController controller = new Dominio.Logica.PedidoController();
            Assert.IsNotNull(controller.ObtenerPedidosCliente("jonathan"));
        }


        [TestMethod]
        public void EditarPedido1Test()
        {
            PedidoController controller = new PedidoController();
           List<Pedido> lista =  controller.ObtenerPedidos();

            Pedido PedidoEditar = lista.Find(x => x.Id == 20);
            PedidoEditar.Total = 20;
            Assert.AreEqual(ResultsPedidos.ActualizadoConExito, controller.ActualizarPedidoArticulos(PedidoEditar)) ;
           
        }


    }
}

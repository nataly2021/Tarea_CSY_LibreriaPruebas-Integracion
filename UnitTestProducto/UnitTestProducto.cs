using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Libreria;

namespace UnitTestProducto
{
    [TestClass]
    public class UnitTestProducto
    {
        [TestMethod]
        public void TestObtenerProductoPorInstancia()
        {
            // arrange 

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            Producto producto = new Producto();
            // Producto.Nomnbre

            AuxProducto auxProducto = new AuxProducto();

            // act

            resultadoEsperado = auxProducto.AgregarProducto(producto);

            // assert 

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);


        }


        //

        

        }


    }
}
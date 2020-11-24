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


        // Metodo Agregar Producto 

        [TestMethod]
        public void TestAgregarProducto()
        {
            //Arrange
            AuxProducto auxProducto = new AuxProducto();
            int resultadoEsperado = 1;
            int resultadoObtenido = 0;
            Producto producto = new Producto();
            producto.IdProducto = 1;
            producto.Nombre = "Libro";
            producto.Precio = 300;
            producto.Stock = 2;
            producto.Estado = true;

            //Act
            resultadoObtenido = AuxProducto.AgregarProducto(producto);

            //Assert 
            Assert.Equal(resultadoEsperado, resultadoObtenido);

        }






    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Libreria;


namespace UnitTestProducto
{
    [TestClass]
    public class UnitTestProducto
    { 
        // Probar Metodo Obtener producto por Instancia 
        [TestMethod]
        public void TestObtenerProductoPorInstancia()
        {
            // arrange 

         

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            AuxProducto auxProducto = new AuxProducto();
            Producto producto = new Producto();

            // act

            resultadoObtenido = auxProducto.AgregarProducto(producto);

            // assert 

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);


        }


        [TestMethod]
        public void TestObtenerProductoPorParametro()
        {
            // arrange 



            int resultadoEsperado = 1;
            int resultadoObtenido = 0;


            ////Asignacion de datos a la categoria y al producto
            Categoria categoria = new Categoria();
            categoria.Idcategoria = 2;
            categoria.Nombre = "Comestica";
            categoria.Descripcion = "Maquillaje";


            Producto producto = new Producto();

            producto.IdProducto = 1;
            producto.Nombre = "Labial MAC orange";
            producto.Precio = 12990;
            producto.Stock = 20;
            producto.Estado = true;
            producto.Cat = categoria;

            AuxProducto auxProducto = new AuxProducto();

            // act

            resultadoObtenido = auxProducto.AgregarProducto(producto);

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

            ////Asignacion de datos a la categoria y al producto
            Categoria categoria = new Categoria();
            categoria.Idcategoria = 1;
            categoria.Nombre = "Cabello";
            categoria.Descripcion = "Shampoo y Balsamo";


            Producto producto = new Producto();
            producto.IdProducto = 1;
            producto.Nombre = "Natura Balsamo ";
            producto.Precio = 20000;
            producto.Stock = 4;
            producto.Estado = true;
            producto.Cat = categoria;

            //Act

            resultadoObtenido = auxProducto.AgregarProducto(producto);


            //Assert 
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        // Metodo Agregar Producto Sin ID

        [TestMethod]
        public void TestAgregarProductoSinId()
        {
            //Arrange
            AuxProducto auxProducto = new AuxProducto();
            int resultadoEsperado = 1;
            int resultadoObtenido = 0;
            Producto producto = new Producto();

            ////Asignacion de datos a la categoria y al producto
            Categoria categoria = new Categoria();
            categoria.Idcategoria = 2;
            categoria.Nombre = "Rostro";
            categoria.Descripcion = "Cuidado Facial";


            producto.Nombre = "Mascarillas de Aloe";
            producto.Precio = 1500;
            producto.Stock = 10;
            producto.Estado = true;
            producto.Cat = categoria;

            //Act

            resultadoObtenido = auxProducto.AgregarProducto(producto);


            //Assert 
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        // Metodo Agregar Producto Sin Nombre 

        [TestMethod]
        public void TestAgregarProductoSinNombre()
        {
            //Arrange
            AuxProducto auxProducto = new AuxProducto();
            int resultadoEsperado = 0;
            int resultadoObtenido = 1;
            Producto producto = new Producto();
            producto.IdProducto = 1;

            ////Asignacion de datos a la categoria y al producto
            Categoria categoria = new Categoria();
            categoria.Idcategoria = 2;
            categoria.Nombre = "Rostro";
            categoria.Descripcion = "Cuidado Facial";


            producto.Precio = 300;
            producto.Stock = 2;
            producto.Estado = true;
            producto.Cat = categoria;

            //Act

            resultadoObtenido = auxProducto.AgregarProducto(producto);


            //Assert 
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        // Metodo Agregar Producto Sin Precio  

        [TestMethod]
        public void TestAgregarProductoSinPrecio()
        {
            //Arrange
            AuxProducto auxProducto = new AuxProducto();
            int resultadoEsperado = 1;
            int resultadoObtenido = 0;
            Producto producto = new Producto();
            producto.IdProducto = 1;
            producto.Nombre = "Balsamo fragacia a Canela";

            ////Asignacion de datos a la categoria y al producto
            Categoria categoria = new Categoria();
            categoria.Idcategoria = 2;
            categoria.Nombre = "Rostro";
            categoria.Descripcion = "Cuidado Facial";


            producto.Stock = 2;
            producto.Estado = true;
            producto.Cat = categoria;

            //Act

            resultadoObtenido = auxProducto.AgregarProducto(producto);


            //Assert 
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        // Metodo Agregar Producto Sin Precio  

        [TestMethod]
        public void TestAgregarProductoSinStock()
        {
            //Arrange
            AuxProducto auxProducto = new AuxProducto();
            int resultadoEsperado = 1;
            int resultadoObtenido = 0;
            Producto producto = new Producto();
            producto.IdProducto = 3;
            producto.Nombre = "Mascara de pestañas Maybelline";
            producto.Precio = 7000;

            ////Asignacion de datos a la categoria y al producto
            Categoria categoria = new Categoria();
            categoria.Idcategoria = 4;
            categoria.Nombre = "Maquillaje";
            categoria.Descripcion = " Maquillaje facial";


            producto.Estado = true;
            producto.Cat = categoria;

            //Act

            resultadoObtenido = auxProducto.AgregarProducto(producto);


            //Assert 
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

         [TestMethod]
     
        public void TestAgregarProductoSinEstado()
        {
            //Arrange
            AuxProducto auxProducto = new AuxProducto();
            int resultadoEsperado = 1;
            int resultadoObtenido = 0;
            Producto producto = new Producto();
            producto.IdProducto = 1;
            producto.Nombre = "Shampoo Flowers ";
            producto.Precio = 11000;

            ////Asignacion de datos a la categoria y al producto
            Categoria categoria = new Categoria();
            categoria.Idcategoria = 1;
            categoria.Nombre = "Cabello";
            categoria.Descripcion = "shampoo y balsamos";

            producto.Cat = categoria;

            //Act

            resultadoObtenido = auxProducto.AgregarProducto(producto);


            //Assert 
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        [TestMethod]

        public void TestAgregarProductoSinCategoria()
        {
            //Arrange
            AuxProducto auxProducto = new AuxProducto();
            int resultadoEsperado = 1;
            int resultadoObtenido = 0;
            Producto producto = new Producto();
            producto.IdProducto = 7;
            producto.Nombre = "Labial rose";
            producto.Precio = 6900;
            producto.Estado = true;



            //Act

            resultadoObtenido = auxProducto.AgregarProducto(producto);


            //Assert 
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        // Obtener producto por  ID 

        [TestMethod]
        public void TestObtenerProductoPorID()
        {
            AuxProducto auxProducto = new AuxProducto();

            int idProducto = 1;
            Producto productoRetornado;
            int resultadoEsperado = 1;
       
            //Act
            productoRetornado = auxProducto.Buscar(idProducto);

      
            //Assert 
                Assert.AreEqual(resultadoEsperado, productoRetornado.IdProducto);



        }


        // Metodo Dar de baja Producto 

        [TestMethod]
        public void TestDarDeBajaPorId()
        {
            //Arrange
            AuxProducto auxProducto = new AuxProducto();
           // int resultadoEsperado = 0; //no lo encuentra
           int resultadoEsperado = 1; //si lo encuentra
            int resultadoObtenido = 0; 
            int productoID = 1;


            //Act
            resultadoObtenido = auxProducto.DardeBaja(productoID);


            //Assert 
          
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

       



    }
}
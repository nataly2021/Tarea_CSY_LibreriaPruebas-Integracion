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
            categoria.Idcategoria = 1;
            categoria.Nombre = "Infantil";
            categoria.Descripcion = "Libros infantiles";


            Producto producto = new Producto();

            producto.IdProducto = 1;
            producto.Nombre = "Libro";
            producto.Precio = 300;
            producto.Stock = 2;
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
            categoria.Nombre = "Infantil";
            categoria.Descripcion = "Libros infantiles";


            Producto producto = new Producto();
            producto.IdProducto = 1;
            producto.Nombre = "Libro";
            producto.Precio = 300;
            producto.Stock = 2;
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
            categoria.Idcategoria = 1;
            categoria.Nombre = "Infantil";
            categoria.Descripcion = "Libros infantiles";


            producto.Nombre = "Libro";
            producto.Precio = 300;
            producto.Stock = 2;
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
            int resultadoEsperado = 1;
            int resultadoObtenido = 0;
            Producto producto = new Producto();
            producto.IdProducto = 1;

            ////Asignacion de datos a la categoria y al producto
            Categoria categoria = new Categoria();
            categoria.Idcategoria = 1;
            categoria.Nombre = "Infantil";
            categoria.Descripcion = "Libros infantiles";


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
            producto.Nombre = "Libro";

            ////Asignacion de datos a la categoria y al producto
            Categoria categoria = new Categoria();
            categoria.Idcategoria = 1;
            categoria.Nombre = "Infantil";
            categoria.Descripcion = "Libros infantiles";


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
            producto.IdProducto = 1;
            producto.Nombre = "Libro";
            producto.Precio = 2000;

            ////Asignacion de datos a la categoria y al producto
            Categoria categoria = new Categoria();
            categoria.Idcategoria = 1;
            categoria.Nombre = "Infantil";
            categoria.Descripcion = "Libros infantiles";


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
            producto.Nombre = "Libro";
            producto.Precio = 2000;

            ////Asignacion de datos a la categoria y al producto
            Categoria categoria = new Categoria();
            categoria.Idcategoria = 1;
            categoria.Nombre = "Infantil";
            categoria.Descripcion = "Libros infantiles";

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
            producto.IdProducto = 1;
            producto.Nombre = "Libro";
            producto.Precio = 2000;
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
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Libreria;


namespace UnitTestProducto
{
    [TestClass]
    public class UnitTestProducto
    { 
        // Probar Metodo Obtener producto por parameto


        [TestMethod]
        public void TestObtenerProductoPorParametro()
        {

            AuxProducto auxProducto = new AuxProducto();

            int idProductoBuscar = 1;
            Producto productoRetornado;


            ////forzar que funione agregando el producto
            Producto producto = new Producto();
            producto.IdProducto = 1;
            producto.Nombre = "Natura Balsamo ";
            producto.Precio = 20000;
            producto.Stock = 4;
            producto.Estado = true;
            auxProducto.AgregarProducto(producto);


            //Act
            productoRetornado = auxProducto.Buscar(idProductoBuscar);

            if (productoRetornado!= null)
            {
                //Assert 
                Assert.AreEqual(idProductoBuscar, productoRetornado.IdProducto);

            }
            else
            {
                throw new Exception("Producto no encontrado ");
            }

        }

        [TestMethod]
        public void TestObtenerProductoPorID()
        {
            AuxProducto auxProducto = new AuxProducto();

            int idProductoBuscar = 1;
            Producto productoRetornado;



            //forzar que funione agregando el producto
            Producto producto = new Producto();
            producto.IdProducto = 1;
            producto.Nombre = "Natura Balsamo ";
            producto.Precio = 20000;
            producto.Stock = 4;
            producto.Estado = true;
            auxProducto.AgregarProducto(producto);

            //Act
            productoRetornado = auxProducto.Buscar(idProductoBuscar);


            //Assert 
            Assert.AreEqual(idProductoBuscar, productoRetornado.IdProducto);



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

            if (producto.IdProducto == 0)
            {
                throw new Exception("Error no se ha ingresado el ID del producto ");
            }
            else
            {
                //Act

                resultadoObtenido = auxProducto.AgregarProducto(producto);

                //Assert 
                Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            }
           

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

            if (producto.Nombre==null)
            {
                throw new Exception("Error no se ha ingresado el Nombre del producto ");
            }
            else
            {
                //Act
                resultadoObtenido = auxProducto.AgregarProducto(producto);

                //Assert 
                Assert.AreEqual(resultadoEsperado, resultadoObtenido);

            }

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

            
            if (producto.Precio==0)
            {
                throw new Exception("Error no se ha ingresado el Precio ");

            }
            else
            {
                //Act
                resultadoObtenido = auxProducto.AgregarProducto(producto);

                //Assert 
                Assert.AreEqual(resultadoEsperado, resultadoObtenido);

            }

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

            if (producto.Stock==0)
            {
                throw new Exception("Error no se ha ingresado el Stock del  producto ");
            } 
            else
            {

                //Act

                resultadoObtenido = auxProducto.AgregarProducto(producto);


                //Assert 
                Assert.AreEqual(resultadoEsperado, resultadoObtenido);


            }



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

            if (producto.Estado==false)
            {
                throw new Exception("Error no se ha ingresado  el Estado del producto ");
            }
            else
            {
                //Act

                resultadoObtenido = auxProducto.AgregarProducto(producto);

                //Assert 
                Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            }
            

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


            //Crear  metodo sino se cumple mensaje de Error
            if (producto.Cat == null)
            {
                throw new Exception("Error no se ha ingresado categoria");
               
            } 
            else
            {

                //Act

                resultadoObtenido = auxProducto.AgregarProducto(producto);


                //Assert 
                Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            }
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


        // Probar Metodo Actualizar  Producto aumentando el stock
        //enviando por parametro un ID existente y nuevo stock 

        [TestMethod]
        public void TestActualizarStockDeProductoPorID()
        {

            //Arrange
            AuxProducto auxProducto = new AuxProducto();
            int resultadoEsperado = 1;
            int resultadoObtenido = 0;
            int aumentoStock = 3;

            ////Asignacion de datos a la categoria y al producto
            Categoria categoria = new Categoria();
            categoria.Idcategoria = 1;
            categoria.Nombre = "Cabello";
            categoria.Descripcion = "shampoo y balsamos";

            Producto producto = new Producto();
            producto.IdProducto = 7;
            producto.Nombre = "Labial rose";
            producto.Cat = categoria;
            producto.Precio = 6900;
            producto.Estado = true;
            producto.Stock = 1; //stock inicial 1
            auxProducto.AgregarProducto(producto);


            //Act
            resultadoObtenido = auxProducto.ActualizarStock(producto.IdProducto, aumentoStock);
  

            if (resultadoObtenido!= -1)
             {

                resultadoObtenido = 1;
                //Assert 
                Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            }
            else
            {
                //producto no encontrado
                throw new Exception("Producto no encopntrado");
            }


          



        }


        //Probar Metodo Modificar   Producto  enviando por parametro un ID existente

        [TestMethod]
        public void TestModificarProductoPorID()
        {

            //Arrange
            AuxProducto auxProducto = new AuxProducto();
            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            ////Asignacion de datos a la categoria y al producto
            Categoria categoria = new Categoria();
            categoria.Idcategoria = 1;
            categoria.Nombre = "Cabello";
            categoria.Descripcion = "shampoo y balsamos";

            Producto producto = new Producto();
            producto.IdProducto = 7;
            producto.Nombre = "Labial rose";
            producto.Cat = categoria;
            producto.Precio = 6900;
            producto.Estado = true;
            producto.Stock = 1;
            auxProducto.AgregarProducto(producto);


            //Act- se modfica nombre y categoria
            Categoria categoriaNueva = new Categoria();
            categoria.Idcategoria = 2;
            categoria.Nombre = "Maquillaje";
            categoria.Descripcion = "Cosmetica";

            resultadoObtenido = auxProducto.Modificar(7, "Labial rose 2", categoriaNueva, 6900,1  );
     
                     


            //Assert 
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);



        }
    }
}
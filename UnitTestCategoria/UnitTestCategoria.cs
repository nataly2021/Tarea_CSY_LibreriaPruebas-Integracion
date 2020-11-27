using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Libreria;

namespace UnitTestCategoria
{

    [TestClass]
    public class UnitTestAuxCategoria
    {


        // Prueba de Agregar una Categoria enviando por parametro un objeto Categoria
        [TestMethod]
        public void TestAgregarCategoriaComoObjeto()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            Categoria categoria = new Categoria();

            categoria.Idcategoria = 1;
            categoria.Nombre = "Shampoo";
            categoria.Descripcion = "El mejor shampoo del mundo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Agregar(categoria);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        // Prueba Agregar una Categoria enviando por parametro las propiedades de una Categoria
        [TestMethod]
        public void TestAgregarCategoriaConParametros()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();

            var Idcategoria = 2;
            var Nombre = "Shampoo";
            var Descripcion = "El mejor shampoo del mundo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Agregar(Idcategoria, Nombre, Descripcion);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }


        // Prueba Agregar una Categoria enviando por parametro un objeto Categoria sin nombre

        [TestMethod]
        public void TestAgregarCategoriaComoObjetoSinNombre()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            Categoria categoria = new Categoria();


            categoria.Idcategoria = 1;
            categoria.Descripcion = "El mejor shampoo del mundo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Agregar(categoria);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        //Prueba Agregar una Categoria enviando por parametro un objeto Categoria sin descripcion

        [TestMethod]
        public void TestAgregarCategoriaComoObjetoSinDescripcion()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            Categoria categoria = new Categoria();


            categoria.Idcategoria = 1;
            categoria.Nombre = "Shampoo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Agregar(categoria);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        // Prueba Agregar una Categoria enviando por parametro un objeto Categoria sin idCategoria

        [TestMethod]
        public void TestAgregarCategoriaComoObjetoSinIdCategoria()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            Categoria categoria = new Categoria();

            categoria.Nombre = "Shampoo";
            categoria.Descripcion = "El mejor shampoo del mundo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Agregar(categoria);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);


        }

        // Prueba Fallida 
        [TestMethod]
        public void TestModificarCategoriaComoObjeto()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            Categoria categoria = new Categoria();


            categoria.Idcategoria = 1;
            categoria.Nombre = "Shampoo";
            categoria.Descripcion = "El mejor shampoo del mundo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;
            //Agregar Categoria
            //ACT
            resultadoObtenido = auxCategoria.Modificar(categoria);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        // Prueba Fallida 
        [TestMethod]
        public void TestModificarCategoriaConParametros()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();

            var Idcategoria = 2;
            var Nombre = "Shampoo";
            var Descripcion = "El mejor shampoo del mundo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Modificar(Idcategoria, Nombre, Descripcion);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        // Prueba Fallida 
        [TestMethod]
        public void TestModificarCategoriaComoObjetoSinNombre()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            Categoria categoria = new Categoria();


            categoria.Idcategoria = 1;
            categoria.Descripcion = "El mejor shampoo del mundo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Modificar(categoria);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        // Prueba Fallida 
        [TestMethod]
        public void TestModificarCategoriaComoObjetoSinDescripcion()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            Categoria categoria = new Categoria();


            categoria.Idcategoria = 1;
            categoria.Nombre = "Shampoo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Modificar(categoria);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        // Prueba Fallida 
        [TestMethod]
        public void TestModificarCategoriaComoObjetoSinIdCategoria()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            Categoria categoria = new Categoria();

            categoria.Nombre = "Shampoo";
            categoria.Descripcion = "El mejor shampoo del mundo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Modificar(categoria);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }


        //Prueba Eliminar una categoria, enviando por parametro un id existente

        [TestMethod]
        public void TestEliminarCategoriaConIdExistente()
        {
            //Arrange Eliminar
            AuxCategoria auxCategoria = new AuxCategoria();
            int idCategoriaExistente = 1;

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;
            //Agregar

            Categoria categoria = new Categoria();
            categoria.Idcategoria = 1;
            categoria.Nombre = "Shampoo";
            categoria.Descripcion = "El mejor shampoo del mundo";
            auxCategoria.Agregar(categoria);

            //ACT
            resultadoObtenido = auxCategoria.Eliminar(idCategoriaExistente);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }


        //Prueba Eliminar una categoria, enviando por parametro un id no existente

        [TestMethod]
        public void TestEliminarCategoriaConIdNoExistente()
        {
            //Arrange Eliminar
            AuxCategoria auxCategoria = new AuxCategoria();
            int idCategoriaNoExistente = 99;

            int? resultadoEsperado = 0;
            int resultadoObtenido = 0;


            //ACT
            resultadoObtenido = auxCategoria.Eliminar(idCategoriaNoExistente);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);


        }



        ///  faltan metodos de buscar categoria 
    }
}
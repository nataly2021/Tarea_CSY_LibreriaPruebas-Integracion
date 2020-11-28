using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Libreria;

namespace UnitTestCatergoria2
{
    [TestClass]
    public class UnitTestAuxCategoria
    {

        private AuxCategoria _auxCategoria = new AuxCategoria();

        //[TestInitialize]
        //public void Inicializar()
        //{
        //    _auxCategoria = new AuxCategoria();

        //    //_auxCategoria.DatosCategorias = new System.Collections.Generic.List<Categoria>();

        //}

        [TestMethod]
        public void TestAgregarCategoriaComoObjeto()
        {
            //Arrange
            //AuxCategoria auxCategoria = new AuxCategoria();
            Categoria categoria = new Categoria();

            categoria.Idcategoria = 1;
            categoria.Nombre = "Shampoo";
            categoria.Descripcion = "El mejor shampoo del mundo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = _auxCategoria.Agregar(categoria);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

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
            resultadoObtenido = _auxCategoria.Modificar(categoria);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
    }

}

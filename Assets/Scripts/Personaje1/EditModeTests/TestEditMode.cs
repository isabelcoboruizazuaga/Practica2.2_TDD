using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Personajes;

namespace Test
{
    public class TestEditMode
    {
        private Personaje1 p1;

        [SetUp]
        public void SetUp() {
            //Arrange
            this.p1 = new Personaje1();
        }

        [TearDown]
        public void TearDown()
        {
            Debug.Log("Fin");
        }

        [TestCase(0, 0)]
        [TestCase(4, 1)]
        [TestCase(5, 2)]
        [TestCase(7, 2)]
        [TestCase(10, 2)]
        [TestCase(15, -1)]
        public void test1(int altura,int resultadoEsperado)
        {
            //Arrange
            int resultadoActual = p1.saltar(altura);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoActual,"Algo ha ido mal");

        }
        [Test]
        public void test2()
        {
            //Arrange
            var a = 2;
            var b = 3;

            //Act
            var result = a * b;

            //Asserts
            Assert.AreEqual(5, result, "Algo ha ido mal");

        }
    }
}

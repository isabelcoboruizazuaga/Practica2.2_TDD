using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Personajes;

namespace Test
{
    public class EditModeTest2
    {
        private Personaje2 p2;
        [SetUp]
        public void SetUp() {
            //Arrange
            this.p2 = new Personaje2();
        }

        [TestCase(0,300)]
        [TestCase(300,0)]
        [TestCase(150,150)]
        [TestCase(160, 140)]
        [TestCase(1, 299)]
        public void Test1(int danio, int resultadoEsperado)
        {
            int resultadoActual = p2.RecibirDanio(danio);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoActual,"Algo ha ido mal");
        }
    }
}

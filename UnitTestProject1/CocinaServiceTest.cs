using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejer08;

namespace UnitTestProject1
{
    [TestClass]
    public class CocinaServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Alimento alimento1 = new Alimento();
            Alimento alimento2 = new Alimento();
            ICocina sut = new CocinaService();

            sut.Calentar(alimento1, alimento2);
            Assert.IsTrue(alimento1.Calentado);
            Assert.IsTrue(alimento2.Calentado);
        }
    }
}

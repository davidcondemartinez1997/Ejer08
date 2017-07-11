using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejer08;

namespace Ejer08Test
{
    [TestClass]
    public class TurboMixTest
    {
        
        [TestMethod]
        public void TestPesar()
        {
            TurboMix sut = new TurboMix();
            Alimento alimento1 = new Alimento("Zanahoria", 1);
            int peso = sut.Pesar(alimento1);

            Assert.AreEqual(alimento1.Peso, peso);
        }

        [TestMethod]
        public void TestCocinarPlato()
        {
            TurboMix sut = new TurboMix();
            Alimento alimento1 = new Alimento("Zanahoria", 1);
            Alimento alimento2 = new Alimento("Queso", 2);
            Plato plato = sut.Calentar(alimento1, alimento2);
        }
    }
}

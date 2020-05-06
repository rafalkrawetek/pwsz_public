using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab6_1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Silnia_0()
        {
            Silnia SS1 = new Silnia();
            SS1.n = 0;
            Assert.AreEqual(SS1.oblicz(), 1);
        }
        [TestMethod]
        public void Silnia_1()
        {
            Silnia SS1 = new Silnia();
            SS1.n = 1;
            Assert.AreEqual(SS1.oblicz(), 1);
        }
        [TestMethod]
        public void Silnia_5()
        {
            Silnia SS1 = new Silnia();
            SS1.n = 5;
            Assert.AreEqual(SS1.oblicz(), 120);
        }
    }
}

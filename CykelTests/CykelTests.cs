using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cykel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cykel.Tests
{
    [TestClass()]
    public class CykelTests
    {
        [TestMethod()]
        // Her testes cyklens ID
        public void IdTest()
        {
            Cyklen cyklen = new Cyklen(5, "Rød", 50, 23);
            Assert.AreEqual(5, cyklen.Id);
        }

        [TestMethod()]
        // Her testes cyklens farve, og hvis tesken er mindre end et tegn, så vises der en ArgumentException.
        public void FarveTest()
        {
            Cyklen cyklen = new Cyklen(5, "Rød", 50, 23);
            Assert.AreEqual("Rød", cyklen.Farve);
            Assert.ThrowsException<ArgumentException>(() => cyklen.Farve = "");
        }

        [TestMethod()]
        // Her testes prisen på cyklen, og hvis prisen er 0 eller mindre, så vil der laves ArgumentOutOfRangeException.
        public void PrisTest()
        {
            Cyklen cyklen = new Cyklen(5, "Rød", 50, 23);
            Assert.AreEqual(50, cyklen.Pris);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => cyklen.Pris = 0);
        }

        [TestMethod()]
        // Her testes cyklens gear, og hvis dens gear er mindre end 3 eller større end 32, så vil der laves en ArgumentOutOfRangeException.
        public void GearTest()
        {
            Cyklen cyklen = new Cyklen(5, "Rød", 50, 25);
            Assert.AreEqual(25, cyklen.Gear);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => cyklen.Gear = 2);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => cyklen.Gear = 33);
        }

        [TestMethod()]
        public void ToStringTest()
        {
        }
    }
}
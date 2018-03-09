using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomansProject;

namespace RomansUnitTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class RomansToInt
    {
        [TestMethod]
        public void Roman_I_1()
        {
            Assert.AreEqual(1, Romans.Convert("I"));
        }

        [TestMethod]
        public void Roman_II_2()
        {
            Assert.AreEqual(2, Romans.Convert("II"));
        }

        [TestMethod]
        public void Roman_III_3()
        {
            Assert.AreEqual(3, Romans.Convert("III"));
        }

        [TestMethod]
        public void Roman_IV_4()
        {
            Assert.AreEqual(4, Romans.Convert("IV"));
        }

        [TestMethod]
        public void Roman_V_5()
        {
            Assert.AreEqual(5, Romans.Convert("V"));
        }

        [TestMethod]
        public void Roman_IX_9()
        {
            Assert.AreEqual(9, Romans.Convert("IX"));
        }

        [TestMethod]
        public void Roman_X_10()
        {
            Assert.AreEqual(10, Romans.Convert("X"));
        }

        [TestMethod]
        public void Roman_XLIX_49()
        {
            Assert.AreEqual(49, Romans.Convert("XLIX"));
        }

        [TestMethod]
        public void Roman_L_50()
        {
            Assert.AreEqual(50, Romans.Convert("L"));
        }

        [TestMethod]
        public void Roman_C_100()
        {
            Assert.AreEqual(100, Romans.Convert("C"));
        }

        [TestMethod]
        public void Roman_CD_400()
        {
            Assert.AreEqual(400, Romans.Convert("CD"));
        }

        [TestMethod]
        public void Roman_D_500()
        {
            Assert.AreEqual(500, Romans.Convert("D"));
        }

        [TestMethod]
        public void Roman_CM_900()
        {
            Assert.AreEqual(900, Romans.Convert("CM"));
        }

        [TestMethod]
        public void Roman_M_1000()
        {
            Assert.AreEqual(1000, Romans.Convert("M"));
        }

        [TestMethod]
        public void Roman_MMXVIII_2018()
        {
            Assert.AreEqual(2018, Romans.Convert("MMXVIII"));
        }
    }
}

using System;
using RomansProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomansUnitTest
{
    [TestClass]
    public class IntToRomansUnitTest
    {
        [TestMethod]
        public void Roman_1_I()
        {
            Assert.AreEqual("I", Romans.Convert(1));
        }

        [TestMethod]
        public void Roman_2_II()
        {
            Assert.AreEqual("II", Romans.Convert(2));
        }

        [TestMethod]
        public void Roman_3_III()
        {
            Assert.AreEqual("III", Romans.Convert(3));
        }

        [TestMethod]
        public void Roman_4_IV()
        {
            Assert.AreEqual("IV", Romans.Convert(4));
        }

        [TestMethod]
        public void Roman_5_V()
        {
            Assert.AreEqual("V", Romans.Convert(5));
        }

        [TestMethod]
        public void Roman_9_IX()
        {
            Assert.AreEqual("IX", Romans.Convert(9));
        }

        [TestMethod]
        public void Roman_10_X()
        {
            Assert.AreEqual("X", Romans.Convert(10));
        }

        [TestMethod]
        public void Roman_49_XLIX()
        {
            Assert.AreEqual("XLIX", Romans.Convert(49));
        }

        [TestMethod]
        public void Roman_50_L()
        {
            Assert.AreEqual("L", Romans.Convert(50));
        }

        [TestMethod]
        public void Roman_100_C()
        {
            Assert.AreEqual("C", Romans.Convert(100));
        }

        [TestMethod]
        public void Roman_400_CD()
        {
            Assert.AreEqual("CD", Romans.Convert(400));
        }

        [TestMethod]
        public void Roman_500_D()
        {
            Assert.AreEqual("D", Romans.Convert(500));
        }

        [TestMethod]
        public void Roman_900_CM()
        {
            Assert.AreEqual("CM", Romans.Convert(900));
        }

        [TestMethod]
        public void Roman_1000_M()
        {
            Assert.AreEqual("M", Romans.Convert(1000));
        }

        [TestMethod]
        public void Roman_2018_MMXVIII()
        {
            Assert.AreEqual("MMXVIII", Romans.Convert(2018));
        }
    }
}

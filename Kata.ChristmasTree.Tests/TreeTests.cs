using System;
using System.Collections.Generic;
using System.Linq;
using Kata.ChristmasTree.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata.ChristmasTree.Tests
{
    [TestClass]
    public class TreeTests
    {
        [TestMethod]
        public void SimpleTreeWithoutStar()
        {
            Tree sut = new Tree();

            List<String> actual = sut.GetLines(1, false).ToList();

            Assert.AreEqual(2, actual.Count);
            Assert.AreEqual("X", actual[0]);
            Assert.AreEqual("I", actual[1]);           
        }

        [TestMethod]
        public void SimpleTreeWithStar()
        {
            Tree sut = new Tree();

            List<String> actual = sut.GetLines(1, true).ToList();

            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual("*", actual[0]);
            Assert.AreEqual("X", actual[1]);
            Assert.AreEqual("I", actual[2]);           
        }

        [TestMethod]
        public void ComplexTreeWithoutStar()
        {
            Tree sut = new Tree();

            List<String> actual = sut.GetLines(5, false).ToList();

            Assert.AreEqual(6, actual.Count);
            Assert.AreEqual("    X", actual[0]);
            Assert.AreEqual("   XXX", actual[1]);
            Assert.AreEqual("  XXXXX", actual[2]);
            Assert.AreEqual(" XXXXXXX", actual[3]);
            Assert.AreEqual("XXXXXXXXX", actual[4]);
            Assert.AreEqual("    I", actual[5]);           
        }

        [TestMethod]
        public void ComplexTreeWithStar()
        {
            Tree sut = new Tree();

            List<String> actual = sut.GetLines(5, true).ToList();

            Assert.AreEqual(7, actual.Count);
            Assert.AreEqual("    *", actual[0]);
            Assert.AreEqual("    X", actual[1]);
            Assert.AreEqual("   XXX", actual[2]);
            Assert.AreEqual("  XXXXX", actual[3]);
            Assert.AreEqual(" XXXXXXX", actual[4]);
            Assert.AreEqual("XXXXXXXXX", actual[5]);
            Assert.AreEqual("    I", actual[6]);           
        }
    }
}

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
        public void SimpleTreewithoutStar()
        {
            Tree sut = new Tree();

            List<String> actual = sut.GetLines(1, false).ToList();

            Assert.AreEqual(2, actual.Count);
            Assert.AreEqual("X", actual[0]);
            Assert.AreEqual("I", actual[1]);           
        }
    }
}
